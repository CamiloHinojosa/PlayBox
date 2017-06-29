using System;

namespace PlayBoxSharedLibrary
{
    public class COSELogManager:COSEReportManager
    {
        public uint AddSession()
        {
            uint id = 0;
            try
            {
                id=(uint)report.Sessions.Count;
                report.Sessions.Add(new COSELog(id));
                SaveReport(report.FullFileName,report);
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("COSESM ==> Error adding session: "+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
            }
            return id;
        }

        public bool StartSession(uint clientId,DateTime startTime)
        {
            try
            {
                report.Sessions[report.Sessions.Count-1].ClientId=clientId;
                report.Sessions[report.Sessions.Count-1].StartTime=startTime;
                return SaveReport(report.FullFileName,report);
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("COSESM ==> Error starting session: "+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public bool EndSession(DateTime endTime,TimeSpan totalTime,double totalConsumption)
        {
            try
            {
                report.Sessions[report.Sessions.Count-1].EndTime=endTime;
                report.Sessions[report.Sessions.Count-1].TotalTime=totalTime;
                report.Sessions[report.Sessions.Count-1].TotalConsumption=totalConsumption;
                return SaveReport(report.FullFileName,report);
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("COSESM ==> Error ending session: "+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public uint AddLog()
        {
            uint logId;
            try
            {
                logId=(uint)report.Sessions[report.Sessions.Count-1].Logs.Count;
                report.Sessions[report.Sessions.Count-1].Logs.Add(new COACLog(logId));
                SaveReport(report.FullFileName,report);
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("COSESM ==> Error adding log: "+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return 0;
            }
            return logId;
        }

        public bool StartLog(string eventName,uint extraConstrols,DateTime startTime)
        {
            try
            {
                report.Sessions[report.Sessions.Count-1].Logs[report.Sessions[report.Sessions.Count-1].Logs.Count-1].Date=DateTime.Now;
                report.Sessions[report.Sessions.Count-1].Logs[report.Sessions[report.Sessions.Count-1].Logs.Count-1].EventName=eventName;
                report.Sessions[report.Sessions.Count-1].Logs[report.Sessions[report.Sessions.Count-1].Logs.Count-1].ExtraControls=extraConstrols;
                report.Sessions[report.Sessions.Count-1].Logs[report.Sessions[report.Sessions.Count-1].Logs.Count-1].StartTime=startTime;
                return SaveReport(report.FullFileName,report);
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("COSESM ==> Error starting log: "+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public bool EndLog(DateTime endTime,TimeSpan totalTime,double totalConsumption)
        {
            try
            {
                report.Sessions[report.Sessions.Count-1].Logs[report.Sessions[report.Sessions.Count-1].Logs.Count-1].EndTime=endTime;
                report.Sessions[report.Sessions.Count-1].Logs[report.Sessions[report.Sessions.Count-1].Logs.Count-1].TotalTime=totalTime;
                report.Sessions[report.Sessions.Count-1].Logs[report.Sessions[report.Sessions.Count-1].Logs.Count-1].TotalConsumption=totalConsumption;
                return SaveReport(report.FullFileName,report);
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("COSESM ==> Error ending log: "+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public void DeleteLastSession()
        {
            report.Sessions.RemoveAt(report.Sessions.Count-1);
            SaveReport(report.FullFileName,report);
        }

        public void CopySession(uint reportId,uint inputReportId)
        {
            reports[reportId].Sessions[reports[reportId].Sessions.Count-1].ClientId=reports[inputReportId].Sessions[reports[inputReportId].Sessions.Count-1].ClientId;
            reports[reportId].Sessions[reports[reportId].Sessions.Count-1].Date=reports[inputReportId].Sessions[reports[inputReportId].Sessions.Count-1].Date;
            reports[reportId].Sessions[reports[reportId].Sessions.Count-1].EndTime=reports[inputReportId].Sessions[reports[inputReportId].Sessions.Count-1].EndTime;
            reports[reportId].Sessions[reports[reportId].Sessions.Count-1].Name=reports[inputReportId].Sessions[reports[inputReportId].Sessions.Count-1].Name;
            reports[reportId].Sessions[reports[reportId].Sessions.Count-1].StartTime=reports[inputReportId].Sessions[reports[inputReportId].Sessions.Count-1].StartTime;
            reports[reportId].Sessions[reports[reportId].Sessions.Count-1].TotalConsumption=reports[inputReportId].Sessions[reports[inputReportId].Sessions.Count-1].TotalConsumption;
            reports[reportId].Sessions[reports[reportId].Sessions.Count-1].TotalTime=reports[inputReportId].Sessions[reports[inputReportId].Sessions.Count-1].TotalTime;
            reports[reportId].Sessions[reports[reportId].Sessions.Count-1].Type=reports[inputReportId].Sessions[reports[inputReportId].Sessions.Count-1].Type;
            foreach(COACLog log in reports[inputReportId].Sessions[reports[inputReportId].Sessions.Count-1].Logs)
                reports[reportId].Sessions[reports[reportId].Sessions.Count-1].Logs.Add(log.CreateCopy());
            SaveReport(report.FullFileName,report);
        }
    }
}