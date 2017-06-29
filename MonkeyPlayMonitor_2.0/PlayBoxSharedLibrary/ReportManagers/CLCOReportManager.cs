using System;
using System.Collections.Generic;
using System.IO;

namespace PlayBoxSharedLibrary
{
    public class CLCOReportManager:ReportManager
    {
        protected CLCOReport report;
        protected Dictionary<uint,CLCOReport> reports;

        public CLCOReport Report { get { return report; } }
        public Dictionary<uint,CLCOReport> Reports { get { return reports; } }

        public CLCOReportManager()
        {
            reports=new Dictionary<uint,CLCOReport> { };
        }

        private bool Create()
        {
            MessageLogManager.LogMessage("CLCO REPORT MANAGER - CR ==> Creating CLCO Report...");
            try
            {
                uint id = (uint)GetLastReportNumberID(CLCODirectory);
                report=new CLCOReport(id,CLCODirectory);
                MessageLogManager.LogMessage("CLCO REPORT MANAGER - CR ==> CLCO Report created: "+report.FullFileName);
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("CLCO REPORT MANAGER - CR ==> CLCO Report failed to create: "+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public bool DeleteAll()
        {
            MessageLogManager.LogMessage("CLCO REPORT MANAGER - DA ==> Deleting CLCO Reports...");
            try
            {
                foreach(KeyValuePair<uint,CLCOReport> report in reports)
                    File.Delete(report.Value.FullFileName);
                reports.Clear();
                MessageLogManager.LogMessage("CLCO REPORT MANAGER - DA ==> CLCO Reports delted.");
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("CLCO REPORT MANAGER - DA ==> CLCO Reports failed to delete: "+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public bool Load(uint id)
        {
            MessageLogManager.LogMessage("CLCO REPORT MANAGER - LR(bI) ==> Loading CLCO Report...");
            try
            {
                report=reports[id];
                MessageLogManager.LogMessage("CLCO REPORT MANAGER - LR(bI) ==> CLCO Report loaded: "+report.FullFileName);
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("CLCO REPORT MANAGER - LR(bI) ==> CLCO Report failed to load: "+id.ToString()+"\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
            return true;
        }

        public string Load(string @fullReportName)
        {
            MessageLogManager.LogMessage("CLCO REPORT MANAGER - LR+CR ==> Loading CLCO Report...");
            if(((report=(CLCOReport)LoadReport(fullReportName))!=null||Create())&&SaveReport(report.FullFileName,report))
            {
                if(!reports.ContainsKey(report.Id))
                    reports.Add(report.Id,report);
                MessageLogManager.LogMessage("CLCO REPORT MANAGER - LR+CR ==> CLCO Report loaded:\n"+report.FullFileName);
                return report.FullFileName;
            }
            MessageLogManager.LogMessage("CLCO REPORT MANAGER - LR+CR ==> CLCO Report failed to load: "+fullReportName);
            return "Error";
        }
    }
}