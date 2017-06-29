using System;

namespace PlayBoxSharedLibrary
{
    public class CLINLogManager:CLINReportManager
    {
        public uint AddClient(string clientName,string docId,string phoneNumber,string dateOfBirth)
        {
            uint id = 0;
            try
            {
                id=(uint)report.Clients.Count;
                report.Clients.Add(clientName,new CLINLog(id,clientName,docId,phoneNumber,dateOfBirth));
                report.ClientKeys.Add(docId,clientName);
                SaveReport(report.FullFileName,report);
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("CLINCM ==> Error adding client: "+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
            }
            return id;
        }
    }
}