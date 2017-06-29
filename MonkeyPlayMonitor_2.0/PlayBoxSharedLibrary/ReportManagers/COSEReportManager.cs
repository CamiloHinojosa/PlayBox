using System;
using System.Collections.Generic;
using System.IO;

namespace PlayBoxSharedLibrary
{
    public class COSEReportManager:ReportManager
    {
        protected COSEReport report;
        protected Dictionary<uint,COSEReport> reports;

        public COSEReport Report { get { return report; } }
        public Dictionary<uint,COSEReport> Reports { get { return reports; } }

        public COSEReportManager()
        {
            reports=new Dictionary<uint,COSEReport> { };
        }

        private bool Create(uint consoleId,string consoleName)
        {
            MessageLogManager.LogMessage("COSE REPORT MANAGER - CR ==> Creating COSE Report...");
            try
            {
                uint id = (uint)GetLastReportNumberID(COSEDirectory);
                report=new COSEReport(id,COSEDirectory,consoleId,consoleName);
                MessageLogManager.LogMessage("COSE REPORT MANAGER - CR ==> COSE Report created: "+report.FullFileName);
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("COSE REPORT MANAGER - CR ==> COSE Report failed to create:\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public bool DeleteAll()
        {
            MessageLogManager.LogMessage("COSE REPORT MANAGER - DA ==> Deleting COSE Reports...");
            try
            {
                Directory.Delete(COSEDirectory,true);
                reports.Clear();
                MessageLogManager.LogMessage("COSE REPORT MANAGER - DA ==> COSE Reports delted.");
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("COSE REPORT MANAGER - DA ==> COSE Reports failed to delete:\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public bool Load(uint id)
        {
            MessageLogManager.LogMessage("COSE REPORT MANAGER - LR(bI) ==> Loading COSE Report...");
            try
            {
                report=reports[id];
                MessageLogManager.LogMessage("COSE REPORT MANAGER - LR(bI) ==> COSE Report loaded:\n"+report.FullFileName);
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("COSE REPORT MANAGER - LR(bI) ==> COSE Report failed to load: "+id.ToString()+"\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public bool Load(string @fullReportName)
        {
            MessageLogManager.LogMessage("COSE REPORT MANAGER - LR(bN) ==> Loading COSE Report...");
            if((report=(COSEReport)LoadReport(fullReportName))!=null&&SaveReport(report.FullFileName,report))
            {
                if(!reports.ContainsKey(report.Id))
                    reports.Add(report.Id,report);
                MessageLogManager.LogMessage("COSE REPORT MANAGER - LR(bN) ==> COSE Report loaded:\n"+report.FullFileName);
                return true;
            }
            MessageLogManager.LogMessage("COSE REPORT MANAGER - LR(bN) ==> COSE Report failed to load: "+fullReportName);
            return false;
        }

        public string Load(string @fullReportName,uint consoleId,string consoleName)
        {
            MessageLogManager.LogMessage("COSE REPORT MANAGER - LR+CR ==> Loading COSE Report...");
            if(((report=(COSEReport)LoadReport(fullReportName))!=null||Create(consoleId,consoleName))&&SaveReport(report.FullFileName,report))
            {
                if(!reports.ContainsKey(report.Id))
                    reports.Add(report.Id,report);
                    MessageLogManager.LogMessage("COSE REPORT MANAGER - LR+CR ==> COSE Report loaded:\n"+report.FullFileName);
                    return report.FullFileName;
            }
            MessageLogManager.LogMessage("COSE REPORT MANAGER - LR+CR ==> COSE Report failed to load: "+fullReportName);
            return "Error";
        }
    }
}