using System;
using System.Collections.Generic;
using System.IO;

namespace PlayBoxSharedLibrary
{
    public class YECOReportManager:ReportManager
    {
        protected YECOReport report;
        protected Dictionary<uint,YECOReport> reports;

        public YECOReport Report { get { return report; } }
        public Dictionary<uint,YECOReport> Reports { get { return reports; } }

        public YECOReportManager()
        {
            reports=new Dictionary<uint,YECOReport> { };
        }

        public bool LoadOnly(string reportName)
        {
            MessageLogManager.LogMessage("YECO REPORT MANAGER - LRO ==> Loading YECO Report...");
            if(((report=(YECOReport)LoadReport(reportName))!=null)&&SaveReport(reportName,report))
            {
                if(!reports.ContainsKey(report.Id))
                    reports.Add(report.Id,report);
                MessageLogManager.LogMessage("YECO REPORT MANAGER - LRO ==> YECO Report loaded: "+report.FullFileName);
                return true;
            }
            MessageLogManager.LogMessage("YECO REPORT MANAGER - LRO ==> YECO Report failed to load: "+reportName);
            return false;
        }

        public string Load(string reportName)
        {
            MessageLogManager.LogMessage("YECO REPORT MANAGER - LR+CR ==> Loading YECO Report...");
            if(((((report=(YECOReport)LoadReport(reportName))!=null&&VerifyYear(report.Date)))||Create())&&SaveReport(reportName,report))
            {
                if(!reports.ContainsKey(report.Id))
                    reports.Add(report.Id,report);
                    MessageLogManager.LogMessage("YECO REPORT MANAGER - LR+CR ==> YECO Report loaded: "+report.FullFileName);
                    return report.FullFileName;
            }
            MessageLogManager.LogMessage("YECO REPORT MANAGER - LR+CR ==> YECO Report failed to load: "+reportName);
            return "Error";
        }

        protected bool LoadCurrent()
        {
            MessageLogManager.LogMessage("YECO REPORT MANAGER - LCR ==> Loading current YECO Report...");
            string[] files = Directory.GetFiles(CODirectory);
            foreach(string file in files)
            {
                report=(YECOReport)LoadReport(file);
                if(report.Date.Year.ToString()==DateTime.Now.Year.ToString())
                {
                    if(!reports.ContainsKey(report.Id))
                        reports.Add(report.Id,report);
                    MessageLogManager.LogMessage("YECO REPORT MANAGER - LCR ==> YECO Report loaded: "+report.FullFileName);
                    return true;
                }
            }
            MessageLogManager.LogMessage("YECO REPORT MANAGER - LCR ==> YECO Report failed to load.");
            return false;
        }

        protected bool Create()
        {
            MessageLogManager.LogMessage("YECO REPORT MANAGER - CR ==> Creating YECO Report...");
            try
            {
                uint id = (uint)GetLastReportNumberID(CODirectory);
                report=new YECOReport(id,CODirectory);
                MessageLogManager.LogMessage("YECO REPORT MANAGER - CR ==> YECO Report created: "+report.FullFileName);
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("YECO REPORT MANAGER - CR ==> YECO Report failed to create:\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public string load(uint id)
        {
            MessageLogManager.LogMessage("YECO REPORT MANAGER - LR(bI) ==> Loading YECO Report...");
            try
            {
                report=reports[id];
                MessageLogManager.LogMessage("YECO REPORT MANAGER - LR(bI) ==> YECO Report loaded: "+report.FullFileName);
                return report.FullFileName;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("YECO REPORT MANAGER - LR(bI) ==> YECO Report failed to load: "+id.ToString()+"\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return "Error";
            }
        }

        public bool DeleteAll()
        {
            MessageLogManager.LogMessage("YECO REPORT MANAGER - DA ==> Deleting YECO Reports...");
            try
            {
                Directory.Delete(CODirectory,true);
                reports.Clear();
                MessageLogManager.LogMessage("YECO REPORT MANAGER - DA ==> YECO Reports delted.");
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("YECO REPORT MANAGER - DA ==> YECO Reports failed to delete:\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }
    }
}