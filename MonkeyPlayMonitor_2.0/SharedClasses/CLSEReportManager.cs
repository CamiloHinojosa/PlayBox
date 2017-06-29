using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayBoxReporting
{
    public class CLSEReportManager:ReportManager
    {
        public bool CreateCLSExR()
        {
            try
            {
                uint id = (uint)GetLastReportNumberID(CLCODirectory);
                CLSExR=new CLSEReport(id,CLCODirectory);
                SaveCLSExR(CLSExR.FullFileName);
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("CLSEReportManager - CreateCLSExR ERROR: "+e.Message);
                return false;
            }
            return true;
        }

        public bool LoadCLSExR(string fullReportName)
        {
            try
            {
                bFormatter=new BinaryFormatter();
                fStream=new FileStream(fullReportName,FileMode.Open,FileAccess.ReadWrite,FileShare.ReadWrite);
                using(Stream stream = fStream)
                {
                    FileInfo reportFile = new FileInfo(fullReportName);
                    CLSExR=(CLSEReport)bFormatter.Deserialize(stream);
                }
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("CLSEReportManager - LoadCOSExR ERROR: "+e.Message+"\n");
                return false;
            }
            System.Diagnostics.Debug.WriteLine("OUTPUT: "+fullReportName+" loaded.");
            return true;
        }

        public bool SaveCLSExR(string fullReportName)
        {
            try
            {
                FileInfo temp = new FileInfo(fullReportName);
                temp.Delete();
                fStream=new FileStream(fullReportName,FileMode.Create,FileAccess.ReadWrite,FileShare.ReadWrite);
                fStream.Seek(0,SeekOrigin.Begin);
                using(Stream stream = fStream)
                {
                    bFormatter.Serialize(stream,CLSExR);
                }
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("SaveCOSExR ERROR: "+e.Message);
                return false;
            }
            return true;
        }
    }
}