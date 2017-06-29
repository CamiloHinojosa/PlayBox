using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayBoxReporting
{
    internal class COSEReportManager:ReportManager
    {
        public bool CreateCOSExR(uint consoleId,string consoleName)
        {
            try
            {
                uint id = (uint)GetLastReportNumberID(COSEDirectory);
                COSExR=new COSEReport(id,COSEDirectory,consoleId,consoleName);
                SaveCOSExR(COSExR.FullFileName);
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("CreateCOSExR ERROR: "+e.Message);
                return false;
            }
            return true;
        }

        public bool LoadCOSExR(string fullReportName)
        {
            try
            {
                bFormatter=new BinaryFormatter();
                fStream=new FileStream(fullReportName,FileMode.Open,FileAccess.ReadWrite,FileShare.ReadWrite);
                using(Stream stream = fStream)
                {
                    FileInfo reportFile = new FileInfo(fullReportName);
                    COSExR=(COSEReport)bFormatter.Deserialize(stream);
                }
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("LoadCOSExR ERROR: "+e.Message+"\n");
                return false;
            }
            System.Diagnostics.Debug.WriteLine("OUTPUT: "+fullReportName+" loaded.");
            return true;
        }

        public bool SaveCOSExR(string fullReportName)
        {
            try
            {
                FileInfo temp = new FileInfo(fullReportName);
                temp.Delete();
                fStream=new FileStream(fullReportName,FileMode.Create,FileAccess.ReadWrite,FileShare.ReadWrite);
                fStream.Seek(0,SeekOrigin.Begin);
                using(Stream stream = fStream)
                {
                    bFormatter.Serialize(stream,COSExR);
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