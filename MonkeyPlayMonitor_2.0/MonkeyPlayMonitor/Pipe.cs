using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Threading;

namespace PlayBoxMonitor
{
    public class Pipe
    {
        private static List<PipeCommands> commands, tempCommands;

        private static AutoResetEvent wait = new AutoResetEvent(true);

        private StreamWriter sw;
        private StreamReader sr;

        public Pipe()
        {
            tempCommands=new List<PipeCommands> { };
            commands=new List<PipeCommands> { };
        }

        public Action<string,string,object> SendPackage = delegate (string type,string action,object data)
          {
              commands.Add(new PipeCommands(type,action,data));
              wait.Set();
          };

        private static string Parse(string[] args,char separator)
        {
            string result = args[0];
            if(args.Length>1)
                for(int i = 1;i<args.Length;i++)
                    result+=(separator.ToString()+args[i]);
            return result;
        }

        private string CLINReportPayload(string action,object data)
        {
            GameConsoleSetup consoleSettings = data as GameConsoleSetup;
            switch(action)
            {
                case "start":
                    Setup temp = data as Setup;
                    return temp.CLINReportName;

                case "addclient":
                    return Parse(new string[] {
                        consoleSettings.ReportProperties.CLINxR_Name,
                        consoleSettings.ClientData.Name,
                        consoleSettings.ClientData.DocId,
                        consoleSettings.ClientData.PhoneNumber,
                        consoleSettings.ClientData.DateOfBirth
                    },'#');

                default:
                    return "";
            }
        }

        private string COSEReportPayload(string action,object data)
        {
            GameConsoleSetup consoleSettings = data as GameConsoleSetup;
            switch(action)
            {
                case "start"://Load or Create COSE Report
                    return Parse(new string[] {
                        consoleSettings.ReportProperties.COSExR_Name,
                        (consoleSettings.NumberID+1).ToString(),
                        consoleSettings.Name
                    },'#');

                default:
                    return "";
            }
        }

        private string COSESessionPayload(string action,object data)
        {
            string temp;
            GameConsoleSetup consoleSettings = data as GameConsoleSetup;
            switch(action)
            {
                case "start"://Create and Start COSE Session
                    return Parse(new string[] {
                        consoleSettings.ReportProperties.COSExR_Id.ToString(),
                        consoleSettings.ClientData.Id.ToString(),
                        consoleSettings.Properties.StartTime.ToString()
                    },'#');

                case "end"://End COSE Session
                    if(consoleSettings.Properties.PrePaid)
                        temp=TimeSpan.FromSeconds(consoleSettings.Properties.PrePaidTime).ToString();
                    else
                        temp=TimeSpan.FromSeconds(consoleSettings.Properties.LastTimeElapsed+consoleSettings.Properties.TimeElapsed).ToString();
                    return Parse(new string[] {
                        consoleSettings.ReportProperties.COSExR_Id.ToString(),
                        consoleSettings.Properties.EndTime.ToString(),
                        temp,
                        consoleSettings.Properties.TempConsumption.ToString(),
                        consoleSettings.ReportProperties.CLINxR_Name
                    },'#');

                case "copy"://Copy COSE Session//*
                    return Parse(new string[] {
                        consoleSettings.ReportProperties.COSExR_Id.ToString(),
                        consoleSettings.ReportProperties.COSExR_InputReportId.ToString()
                    },'#');

                case "deletelast"://Delete COSE Session//*
                    return consoleSettings.ReportProperties.COSExR_InputReportId.ToString();

                default:
                    return "";
            }
        }

        private string COSESessionLogPayload(string action,object data)
        {
            GameConsoleSetup consoleSettings = data as GameConsoleSetup;
            switch(action)
            {
                case "start"://Create and Start COSE Session Log
                    return Parse(new string[] {
                        consoleSettings.ReportProperties.COSExR_Id.ToString(),
                        consoleSettings.Properties.Status.ToString(),
                        consoleSettings.Properties.ExtraControls.ToString(),
                        consoleSettings.Properties.StartTime.ToString()
                    },'#');

                case "end"://End COSE Session Log
                    return Parse(new string[] {
                        consoleSettings.ReportProperties.COSExR_Id.ToString(),
                        consoleSettings.Properties.EndTime.ToString(),
                        consoleSettings.Properties.TempConsumption.ToString()
                    },'#');

                default:
                    return "";
            }
        }

        private string InternalActionPayload(string action,object data)//Add Security using payload
        {
            string payload = data as string;
            switch(action)
            {
                case "close":
                case "deletereport":
                case "deleteall":
                    return payload;

                default:
                    return "";
            }
        }

        private string GeneratePayload(string type,string action,object data)
        {
            switch(type)
            {
                case "CLINxR":
                    return CLINReportPayload(action,data);

                case "DACOxR":
                    return "";

                case "MOCOxR":
                    return "";

                case "YECOxR":
                    return "";

                case "COSExR":
                    return COSEReportPayload(action,data);

                case "COSExS":
                    return COSESessionPayload(action,data);

                case "COSExL":
                    return COSESessionLogPayload(action,data);

                case "INACxCOM":
                    return InternalActionPayload(action,data);

                default:
                    return "";
            }
        }

        private string GeneratePackege(string type,string action,object data)
        {
            string payload = GeneratePayload(type,action,data);
            if(payload!="")
                return Parse(new string[] { type,action,payload },'$');
            else
                return "";
        }

        public void CommandListener()
        {
            bool stop = false;
            string package = "";
            string[] response;
            try
            {
                using(NamedPipeClientStream client = new NamedPipeClientStream(".","ReportGenerator",PipeDirection.InOut,PipeOptions.Asynchronous))
                {
                    client.Connect(5000);
                    using(sw=new StreamWriter(client))
                    using(sr=new StreamReader(client))
                    {
                        while(!stop)
                        {
                            if(commands.Count>0)
                            {
                                package=GeneratePackege(commands[0].Type,commands[0].Action,commands[0].Properties);
                                sw.WriteLine(package);
                                sw.Flush();
                                response=sr.ReadLine().Split('$');
                                if(response[0]=="closingserver")
                                    stop=true;
                                else if(response[0]!="Error")
                                    InterpretResponse(response,commands[0].Type,commands[0].Action,commands[0].Properties);
                                commands.Remove(commands[0]);
                            }
                            else
                                wait.WaitOne();
                        }
                    }
                    client.Close();
                }
            } catch(Exception e)
            {
                Program.Reporting=false;
                MessageLogManager.LogMessage("PBM - PP ::::> Error Command Listener Failed: "+e.Message+"\n"+e.Source);
            }
        }

        private void InterpretResponse(string[] response,string type,string action,object data)
        {
            switch(type)
            {
                case "CLINxR":
                    CLINReportInterpreter(response,action,data);
                    break;

                case "DACOxR":
                    break;

                case "MOCOxR":
                    break;

                case "YECOxR":
                    break;

                case "COSExR":
                    COSEReportInterpreter(response,action,data);
                    break;

                case "COSExS":
                    COSESessionInterpreter(response,action,data);
                    break;

                case "COSExL":
                    COSESessionLogInterpreter(response,action,data);
                    break;

                default:
                    foreach(string arg in response)
                        MessageLogManager.LogMessage("PBM - PP ::::> Error interpreting response (UNKNOWN)"+arg);
                    break;
            }
        }

        private void CLCOReportInterpreter(string[] response,string action,object data)
        {
            GameConsoleSetup consoleSettings = data as GameConsoleSetup;
            switch(action)
            {
                case "updatelog":
                    break;
            }
        }

        private void CLINReportInterpreter(string[] response,string action,object data)
        {
            GameConsoleSetup consoleSettings = data as GameConsoleSetup;
            switch(action)
            {
                case "start":
                    Setup temp = data as Setup;
                    temp.CLINReportName=response[0];
                    break;

                case "addclient":
                    consoleSettings.ClientData.Id=uint.Parse(response[0]);
                    consoleSettings.ClientData.Name=response[1];
                    consoleSettings.ClientData.DocId=response[2];
                    consoleSettings.ClientData.PhoneNumber=response[3];
                    consoleSettings.ClientData.DateOfBirth=response[4];
                    consoleSettings.ReportProperties.CLINxR_Flag=true;
                    break;
            }
        }

        private void COSEReportInterpreter(string[] response,string action,object data)
        {
            GameConsoleSetup consoleSettings = data as GameConsoleSetup;

            switch(action)
            {
                case "start"://Load or Create COSE Report
                    consoleSettings.ReportProperties.COSExR_Name=response[0];
                    consoleSettings.ReportProperties.COSExR_Id=uint.Parse(response[1]);
                    consoleSettings.ReportProperties.COSExR_Flag=true;
                    break;

                default:
                    break;
            }
        }

        private void COSESessionInterpreter(string[] response,string action,object data)
        {
            GameConsoleSetup consoleSettings = data as GameConsoleSetup;
            switch(action)
            {
                case "start"://Create and Start COSE Session
                    break;

                case "End"://End COSE Session
                    break;

                case "copy"://Copy COSE Session//*
                    break;

                case "deletelast"://Delete COSE Session//*
                    break;

                default:
                    break;
            }
        }

        private void COSESessionLogInterpreter(string[] response,string action,object data)
        {
            GameConsoleSetup consoleSettings = data as GameConsoleSetup;
            switch(action)
            {
                case "start"://Create and Start COSE Session Log
                    break;

                case "End"://End COSE Session Log
                    break;

                default:
                    break;
            }
        }
    }
}