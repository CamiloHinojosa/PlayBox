using System;

namespace PlayBoxSharedLibrary
{
    public class CLCOLogManager:CLCOReportManager
    {
        public bool AddLog(uint clientId,string clientName)
        {
            try
            {
                report.Clients.Add(clientId,new CLCOLog(clientId,clientName,0,0,TimeSpan.FromSeconds(0)));
                return SaveReport(report.FullFileName,report);
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("CLCOCCM ==> Error adding client console log: "+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public bool UpdateLog(COSELog session)
        {
            try
            {
                report.Clients[session.ClientId].Sessions.Add(session);
                return SaveReport(report.FullFileName,report);
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("CLCOCCM ==> Error updating client console log: "+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }
        
    }
}