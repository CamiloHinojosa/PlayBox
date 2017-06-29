using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayBoxSharedLibrary
{
    public class DACOLogManager:DACOReportManager
    {
        public bool AddSession(COSELog session)
        {
            try
            {
                report.Sessions.Add(session);
                return SaveReport(report.FullFileName,report);
            } catch(Exception e)
            {
                Console.WriteLine("Failed to add session to DACO report: "+e.Message);
                return false;
            }
        }

        public bool ReloadData(CLSEReport clseReport)
        {
            try
            {
                report.Sessions.Clear();
                foreach(KeyValuePair<uint,CLSELog> log in clseReport.Clients)
                    foreach(COSELog session in log.Value.Sessions)
                        if(report.Date.ToShortDateString()==session.Date.ToShortDateString())
                            report.Sessions.Add(session);
                return SaveReport(report.FullFileName,report);
            } catch(Exception e)
            {
                Console.WriteLine("REPORT MANAGER ==> DACO Report failed to load data: "+e.Message);
                return false;
            }
        }
    }
}
