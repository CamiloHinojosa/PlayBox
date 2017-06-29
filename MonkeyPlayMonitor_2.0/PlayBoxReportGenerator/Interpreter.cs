using PlayBoxSharedLibrary;
using System;

namespace PlayBoxReportGenerator
{
    public class Interpreter
    {
        private ReportActions ra;

        public Interpreter()
        {
            MessageLogManager.LogMessage("Initializing Interpreter...");
            ra=new ReportActions();
            MessageLogManager.LogMessage("Interpreter initialized.");
        }

        public string InterpreteData(string data)
        {
            string[] args;
            string message = null;
            if(data!=null)
            {
                ReportActions.VerifyDirectories();
                MessageLogManager.LogMessage("\n\n\n\n+______________________________________________________________________ R G    P A C K E T ______________________________________________________________________________________+");
                MessageLogManager.LogMessage("INPUT DATA:: "+data);
                args=data.Split('$');
                string type = args[0], action = args[1], payload = args[2];
                args=payload.Split('#');
                switch(type)
                {
                    case "CLINxR":
                        message=CLINReportActions(action,args);
                        break;

                    case "COSExR":
                        message=COSEReportActions(action,args);
                        break;

                    case "COSExS":
                        message=COSESessionActions(action,args);
                        break;

                    case "COSExL":
                        message=COSESessionLogActions(action,args);
                        break;

                    case "INACxCOM":
                        message=InternalActions(action,args);
                        break;

                    default:
                        message="Error";
                        break;
                }
                ReportActions.VerifyDirectories();
                MessageLogManager.LogMessage("+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+");
                MessageLogManager.LogMessage("O U T P U T    D A T A::> ");
                foreach(string str in message.Split('$'))
                    MessageLogManager.LogMessage("\t- "+str);
                MessageLogManager.LogMessage("---------------------------------------------------------------------------------------------------------------------------------------------");
            }
            return message;
        }

        private string InternalActions(string action,string[] args)//USE PAYLOAD AS SECURITY MEASURE
        {
            switch(action)
            {
                case "close":
                    MessageLogManager.LogMessage("CLOSING!!!");
                    if(args[0]=="closeserver")
                        return "closingserver";
                    else
                        return "Error";

                case "deletereport":
                    return ra.DeleteReport(args[0]);

                case "deleteall":
                    return ra.DeleteAllReports(args[0]);

                default:
                    return "Error";
            }
        }

        private string CLINReportActions(string action,string[] args)
        {
            switch(action)
            {
                case "start":
                    return ra.StartCLINReport(args[0]);

                case "addclient":
                    return ra.AddCLINLog(args[0],args[1],args[2],args[3],args[4]);

                default:
                    return "Error";
            }
        }

        private string COSEReportActions(string action,string[] args)
        {
            switch(action)
            {
                case "start":
                    return ra.StartCOSEReport(args[0],uint.Parse(args[1]),args[2]);

                default:
                    return "Error";
            }
        }

        private string COSESessionActions(string action,string[] args)
        {
            switch(action)
            {
                case "start":
                    return ra.StartCOSESession(uint.Parse(args[0]),uint.Parse(args[1]),DateTime.Parse(args[2]));

                case "end":
                    return ra.EndCOSESession(uint.Parse(args[0]),DateTime.Parse(args[1]),TimeSpan.Parse(args[2]),double.Parse(args[3]),args[4]);

                case "copy":
                    return ra.CopyCOSESession(uint.Parse(args[0]),uint.Parse(args[1]));

                case "deletelast":
                    return ra.DeleteLastCOSESession(uint.Parse(args[0]));

                default:
                    return "Error";
            }
        }

        private string COSESessionLogActions(string action,string[] args)
        {
            switch(action)
            {
                case "start":
                    return ra.StartCOSESessionLog(uint.Parse(args[0]),uint.Parse(args[1]),uint.Parse(args[2]),DateTime.Parse(args[3]));

                case "end":
                    return ra.EndCOSESessionLog(uint.Parse(args[0]),DateTime.Parse(args[1]),double.Parse(args[2]));

                default:
                    return "Error";
            }
        }
    }
}