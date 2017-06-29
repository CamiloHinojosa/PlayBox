using System;
using System.Collections.Generic;

namespace PlayBoxSharedLibrary
{
    public class DACOReportManager:ReportManager
    {
        protected DACOReport report;
        protected Dictionary<uint,DACOReport> reports;

        public DACOReport Report { get { return report; } }
        public Dictionary<uint,DACOReport> Reports { get { return reports; } }

        public DACOReportManager()
        {
            reports=new Dictionary<uint,DACOReport> { };
        }

        public string Load(string reportName)
        {
            if((report=(DACOReport)LoadReport(reportName))!=null)
                if(VerifyDate(report.Date)||Create())
                {
                    if(!reports.ContainsKey(report.Id))
                        reports.Add(report.Id,report);
                    if(SaveReport(reportName,report))
                        return report.FullFileName;
                }
            return "Error";
        }

        private bool Create()
        {
            Console.WriteLine("REPORT MANAGER ==> Creating DACO Report...");
            try
            {
                uint id = (uint)GetLastReportNumberID(DACODirectory);
                report=new DACOReport(id,DACODirectory);
                return true;
            } catch(Exception e)
            {
                Console.WriteLine("REPORT MANAGER ==> DACO Report failed to create: "+e.Message);
                return false;
            }
        }
        
        public string load(uint id)
        {
            Console.WriteLine("REPORT MANAGER ==> Loading DACO Report...");
            try
            {
                report=reports[id];
                Console.WriteLine("REPORT MANAGER ==> DACO Report loaded: "+report.FullFileName);
                return report.FullFileName;
            } catch(Exception e)
            {
                Console.WriteLine("REPORT MANAGER ==> DACO Report failed to load: "+e.Message);
                return "Error";
            }
        }
    }
}