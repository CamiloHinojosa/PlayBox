using System;
using System.Linq;

namespace PlayBoxSharedLibrary
{
    public class COLogManager:YECOReportManager
    {
        public bool AddSession(COSELog session)
        {
            try
            {
                if(LoadCurrent()||Create())
                {
                    if(!report.MOCOLogs.Keys.Contains(DateTime.Now.ToString("MMMM")))
                        report.MOCOLogs.Add(DateTime.Now.ToString("MMMM"),new MOCOLog((uint)report.MOCOLogs.Count));
                    if(!report.MOCOLogs[DateTime.Now.ToString("MMMM")].DACOLogs.Keys.Contains(DateTime.Now.Date.ToShortDateString()))
                        report.MOCOLogs[DateTime.Now.ToString("MMMM")].DACOLogs.Add(DateTime.Now.ToShortDateString(),new DACOLog((uint)report.MOCOLogs[DateTime.Now.ToString("MMMM")].DACOLogs.Count));
                    report.MOCOLogs[DateTime.Now.ToString("MMMM")].DACOLogs[DateTime.Now.Date.ToShortDateString()].Sessions.Add(session);
                    return SaveReport(report.FullFileName,report);
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Failed to add session to DACO log: "+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
            }
            return false;
        }
    }
}