using PlayBoxSharedLibrary;
using System;

namespace PlayBoxReportGenerator
{
    public class ReportActions
    {
        private COSELogManager coselm;
        private CLINLogManager clinlm;
        private CLCOLogManager clcolm;
        private COLogManager colm;

        public ReportActions()
        {
            coselm=new COSELogManager();
            clinlm=new CLINLogManager();
            clcolm=new CLCOLogManager();
            colm=new COLogManager();
        }

        public static void VerifyDirectories()
        {
            ReportManager.VerifyDirectories();
        }

        public string DeleteReport(string reportName)
        {
            return ReportManager.DeleteReport(reportName).ToString();
        }

        public string DeleteAllReports(string type)
        {
            try
            {
                switch(type)
                {
                    case "all":
                        return (coselm.DeleteAll()&clinlm.DeleteAll()&clcolm.DeleteAll()&colm.DeleteAll()).ToString();

                    case "cosexr":
                        return coselm.DeleteAll().ToString();

                    case "clinxr":
                        return clinlm.DeleteAll().ToString();

                    case "clcoxr":
                        return clcolm.DeleteAll().ToString();

                    case "clsexr":
                        return false.ToString();

                    case "dacoxr":
                        return false.ToString();

                    case "mocoxr":
                        return false.ToString();
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Error deleting reports(s): "+type+"\n"+e.Message);
            }
            return "Error";
        }

        private bool AddCLCOLog(string reportFullName,uint clientId,string clientName)
        {
            if(clcolm.Load(reportFullName)!="Error")
            {
                clcolm.AddLog(clientId,clientName);
                return true;
            }
            else
                return false;
        }

        private string UpdateCLCOLog(string clinReportFullName,COSELog session)
        {
            try
            {
                if((clinReportFullName=StartCLINReport(clinReportFullName).Split('$')[0])!="Error")
                {
                    MessageLogManager.LogMessage("OUTPUT::Updating CLCO log...");
                    clinlm.Report.CLCOReportName=clcolm.Load(clinlm.Report.CLCOReportName).Split('$')[0];
                    if(clinlm.Report.CLCOReportName!="Error")
                        return clcolm.UpdateLog(session).ToString();
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("OUTPUT::Error Updating CLCO client consumption log:\n"+e.Message);
            }
            return "Error";
        }

        public string StartCLINReport(string reportFullName)
        {
            MessageLogManager.LogMessage("OUTPUT::Initializeing CLIN Report...");
            try
            {
                if(clinlm.Load(reportFullName))
                {
                    MessageLogManager.LogMessage("OUTPUT::CLIN Report initialized succesfully.");
                    if(((clinlm.Report.CLCOReportName=clcolm.Load(clinlm.Report.CLCOReportName))!="Error")&&clinlm.Save())
                        return clinlm.Report.FullFileName+"$"+true.ToString();
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("OUTPUT::Error CLIN Report did not initialize: "+e.Message);
            }
            return "Error";
        }

        public string AddCLINLog(string reportFullName,string clientName,string docId,string phoneNumber,string dateOfBirth)
        {
            MessageLogManager.LogMessage("OUTPUT::Adding CLIN client log...");
            try
            {
                reportFullName=StartCLINReport(reportFullName).Split('$')[0];
                if(reportFullName!="Error")
                {
                    if(clientName=="Unknown"&&clinlm.Report.ClientKeys.ContainsKey(docId))
                        clientName=clinlm.Report.ClientKeys[docId];
                    if(!clinlm.Report.Clients.ContainsKey(clientName))
                    {
                        clinlm.AddClient(clientName,docId,phoneNumber,dateOfBirth);
                        if(AddCLCOLog(clinlm.Report.CLCOReportName,clinlm.Report.Clients[clientName].Id,clientName))
                            return clinlm.Report.Clients[clientName].Id.ToString()+"$"
                            +clinlm.Report.Clients[clientName].ClientName.ToString()+"$"
                            +clinlm.Report.Clients[clientName].DocId.ToString()+"$"
                            +clinlm.Report.Clients[clientName].PhoneNumber.ToString()+"$"
                            +clinlm.Report.Clients[clientName].DateOfBirth.ToString()+"$true";
                    }
                    return clinlm.Report.Clients[clientName].Id.ToString()+"$"
                           +clinlm.Report.Clients[clientName].ClientName.ToString()+"$"
                           +clinlm.Report.Clients[clientName].DocId.ToString()+"$"
                           +clinlm.Report.Clients[clientName].PhoneNumber.ToString()+"$"
                           +clinlm.Report.Clients[clientName].DateOfBirth.ToString()+"$true";
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("OUTPUT::Error Adding CLIN client log:\n"+e.Message);
            }
            return "Error";
        }

        public string StartCOSEReport(string reportFullName,uint consoleId,string consoleName)
        {
            MessageLogManager.LogMessage("Initializeing COSE Report...");
            try
            {
                MessageLogManager.LogMessage("COSE Report initialized succesfully.");
                return coselm.Load(reportFullName,consoleId,consoleName)+"$"+coselm.Report.Id+"$"+true.ToString();
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("COSE Report failed to initialize: "+e.Message);
                return "Error";
            }
        }

        public string StartCOSESession(uint reportId,uint clientId,DateTime startTime)
        {
            MessageLogManager.LogMessage("Initializing COSE Session...");
            try
            {
                if(coselm.Load(reportId))
                {
                    uint sessionId = coselm.AddSession();
                    if(coselm.StartSession(clientId,startTime))
                    {
                        MessageLogManager.LogMessage("COSE Session initialized.");
                        return "true";
                    }
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("OUTPUT::Error Starting COSE Session:\n"+e.Message+"\n"+e.Source+"\n"+e.StackTrace+"\n"+e.TargetSite);
            }
            return "Error";
        }

        public string StartCOSESessionLog(uint reportId,uint status,uint extraControls,DateTime startTime)
        {
            try
            {
                if(coselm.Load(reportId))
                {
                    uint logId = coselm.AddLog();
                    if(coselm.StartLog(ReportManager.DetermineStatus(status),extraControls,startTime))
                        return logId.ToString()+"$true";
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("OUTPUT::Error Starting COSE Session Log:\n"+e.Message+"\n"+e.Source+"\n"+e.StackTrace+"\n"+e.TargetSite);
            }
            return "Error";
        }

        public string EndCOSESession(uint reportId,DateTime endTime,TimeSpan totalTime,double totalConsumption,string clinReportFullName)
        {
            try
            {
                if(coselm.Load(reportId)&&coselm.EndSession(endTime,totalTime,totalConsumption))
                {
                    UpdateCLCOLog(clinReportFullName,coselm.Report.Sessions[coselm.Report.Sessions.Count-1]);
                    colm.AddSession(coselm.Report.Sessions[coselm.Report.Sessions.Count-1]);
                    return true.ToString();
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("OUTPUT::Error Ending COSE Session:\n"+e.Message+"\n"+e.Source+"\n"+e.StackTrace+"\n"+e.TargetSite);
            }
            return "Error";
        }

        public string EndCOSESessionLog(uint reportId,DateTime endTime,double totalConsumption)
        {
            MessageLogManager.LogMessage("Ending COSE Session Log...");
            try
            {
                if(coselm.Load(reportId)&&coselm.Report.Sessions[coselm.Report.Sessions.Count-1].Logs.Count>0)
                {
                    double totalTime = Math.Round(endTime.Subtract(coselm.Report.Sessions[coselm.Report.Sessions.Count-1].Logs[coselm.Report.Sessions[coselm.Report.Sessions.Count-1].Logs.Count-1].StartTime).TotalSeconds,0);
                    if(coselm.EndLog(endTime,TimeSpan.FromSeconds(totalTime),totalConsumption))
                    {
                        MessageLogManager.LogMessage("COSE Session Log ended.");
                        return true.ToString();
                    }
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("OUTPUT::Error Ending COSE Session Log:\n"+e.Message+"\n"+e.Source+"\n"+e.StackTrace+"\n"+e.TargetSite);
            }
            return "Error";
        }

        public string CopyCOSESession(uint reportId,uint inputReportId)
        {
            MessageLogManager.LogMessage("Copying COSE Session...");
            try
            {
                if(coselm.Load(reportId))
                {
                    coselm.CopySession(reportId,inputReportId);
                    MessageLogManager.LogMessage("COSE Session copied.");
                    return "Session Copied";
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("OUTPUT::Error Copying COSE Session:\n"+e.Message+"\n"+e.Source+"\n"+e.StackTrace+"\n"+e.TargetSite);
            }
            return "Error";
        }

        public string DeleteLastCOSESession(uint reportId)
        {
            MessageLogManager.LogMessage("Deleting COSE Session...");
            try
            {
                if(coselm.Load(reportId))
                {
                    coselm.DeleteLastSession();
                    MessageLogManager.LogMessage("COSE Session deleted.");
                    return "Session Deleted";
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("OUTPUT::Error Deleting COSE Session:\n"+e.Message+"\n"+e.Source+"\n"+e.StackTrace+"\n"+e.TargetSite);
            }
            return "Error";
        }
    }
}