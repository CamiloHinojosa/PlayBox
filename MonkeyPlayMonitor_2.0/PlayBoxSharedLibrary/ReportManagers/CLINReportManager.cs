using System;
using System.Collections.Generic;
using System.IO;

namespace PlayBoxSharedLibrary
{
    public class CLINReportManager:ReportManager
    {
        protected CLINReport report;
        protected Dictionary<uint,CLINReport> reports;

        public CLINReport Report { get { return report; } }
        protected Dictionary<uint,CLINReport> Reports { get { return reports; } }

        public CLINReportManager()
        {
            reports=new Dictionary<uint,CLINReport> { };
        }

        private bool Create()
        {
            MessageLogManager.LogMessage("CLIN REPORT MANAGER - CR ==> Creating CLIN Report...");
            try
            {
                uint id = (uint)GetLastReportNumberID(CLINDirectory);
                report=new CLINReport(id,CLINDirectory);
                MessageLogManager.LogMessage("CLIN REPORT MANAGER - CR ==> CLIN Report created: "+report.FullFileName);
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("CLIN REPORT MANAGER - CR ==> CLIN Report failed to create:\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public bool DeleteAll()
        {
            MessageLogManager.LogMessage("CLIN REPORT MANAGER - DA ==> Deleting CLIN Reports...");
            try
            {
                Directory.Delete(CLINDirectory,true);
                reports.Clear();
                MessageLogManager.LogMessage("CLIN REPORT MANAGER - DA ==> CLIN Reports delted.");
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("CLIN REPORT MANAGER - DA ==> CLIN Reports failed to delete:\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public bool Load(uint id)
        {
            MessageLogManager.LogMessage("CLIN REPORT MANAGER - LR(bI) ==> Loading CLIN Report...");
            try
            {
                report=reports[id];
                MessageLogManager.LogMessage("CLIN REPORT MANAGER - LR(bI) ==> CLIN Report loaded: "+report.FullFileName);
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("CLIN REPORT MANAGER - LR(bI) ==> CLIN Report failed to load: "+id.ToString()+"\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
            return true;
        }

        public bool Load(string @fullReportName)
        {
            MessageLogManager.LogMessage("CLIN REPORT MANAGER - LR+CR ==> Loading CLIN Report...");
            if(((report=(CLINReport)LoadReport(fullReportName))!=null||Create())&&SaveReport(report.FullFileName,report))
            {
                if(!reports.ContainsKey(report.Id))
                    reports.Add(report.Id,report);
                MessageLogManager.LogMessage("CLIN REPORT MANAGER - LR+CR ==> CLIN Report loaded:\n"+report.FullFileName);
                return true;
            }
            MessageLogManager.LogMessage("CLIN REPORT MANAGER - LR+CR ==> CLIN Report failed to load: "+fullReportName);
            return false;
        }

        public bool Save()
        {
            MessageLogManager.LogMessage("CLIN REPORT MANAGER - SR ==> Saving CLIN Report...");
            if(SaveReport(report.FullFileName,report))
            {
                MessageLogManager.LogMessage("CLIN REPORT MANAGER - SR ==> CLIN Report saved:\n"+report.FullFileName);
                return true;
            }
            MessageLogManager.LogMessage("CLIN REPORT MANAGER - SR ==> CLIN Report failed to save: "+report.FullFileName);
            return false;
        }
    }
}