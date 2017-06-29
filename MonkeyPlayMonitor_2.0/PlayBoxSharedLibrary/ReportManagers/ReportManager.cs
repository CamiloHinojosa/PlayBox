using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayBoxSharedLibrary
{
    public class ReportManager
    {
        protected FileStream fStream;
        protected BinaryFormatter bFormatter;
        
        public static string @reportsDirectory = Environment.CurrentDirectory+@"\Reports";

        public static string @CNDirectory = reportsDirectory+@"\Console Reports";
        public static string @CLDirectory = reportsDirectory+@"\Client Reports";
        public static string @CODirectory = reportsDirectory+@"\Consumption Reports";

        public static string @COSEDirectory = CNDirectory+@"\Console Session Reports";
        public static string @CLINDirectory = CLDirectory+@"\Clients Information";
        public static string @CLCODirectory = CLDirectory+@"\Clients Consumption";

        public ReportManager()
        {
            VerifyDirectories();
        }

        public static bool DeleteReport(string reportFullName)
        {
            try
            {
                FileInfo report = new FileInfo(reportFullName);
                report.Delete();
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("REPORT MANAGER ==> Error deleting report:\n"+reportFullName+"\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public static bool DeleteAllReports()
        {
            try
            {
                Directory.Delete(reportsDirectory,true);
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("REPORT MANAGER ==> Error deleting reports:\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
        }

        public static string Parse(string[] args,string separator)
        {
            string result = args[0];
            if(args.Length>1)
                for(int i = 1;i<args.Length;i++)
                    result+=(separator+args[i]);
            return result;
        }

        public static string DetermineStatus(uint status)
        {
            switch(status)
            {
                case 0:
                    return "RESET";

                case 1:
                    return "START";

                case 2:
                    return "STOP";

                case 3:
                    return "RESUME";

                case 4:
                    return "CASH";

                case 5:
                    return "PPSTART";

                default:
                    return "NONE";
            }
        }

        public bool VerifyDate(DateTime date)
        {
            if(date.Date.ToShortDateString()==DateTime.Now.Date.ToShortDateString())
                return true;
            else
                return false;
        }

        public bool VerifyYear(DateTime date)
        {
            if(date.Year.ToString()==DateTime.Now.Year.ToString())
                return true;
            else
                return false;
        }

        public bool VerifyMonth(DateTime date)
        {
            if(date.ToString("MMMM")==DateTime.Now.ToString("MMMM"))
                return true;
            else
                return false;
        }

        public static void VerifyDirectories()
        {
            try
            {
                if(!Directory.Exists(reportsDirectory))
                    Directory.CreateDirectory(reportsDirectory);

                if(!Directory.Exists(CNDirectory))
                    Directory.CreateDirectory(CNDirectory);
                if(!Directory.Exists(CODirectory))
                    Directory.CreateDirectory(CODirectory);
                if(!Directory.Exists(CLDirectory))
                    Directory.CreateDirectory(CLDirectory);

                if(!Directory.Exists(COSEDirectory))
                    Directory.CreateDirectory(COSEDirectory);
                if(!Directory.Exists(CLCODirectory))
                    Directory.CreateDirectory(CLCODirectory);
                if(!Directory.Exists(CLINDirectory))
                    Directory.CreateDirectory(CLINDirectory);
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("REPORT MANAGER - VD ==> Unable to verify directories:\n"+reportsDirectory+" | "+COSEDirectory+" | "+CODirectory+" |\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
            }
        }

        protected int GetLastReportNumberID(string @directory)
        {
            int x = 0;
            string temp = "";
            if(Directory.EnumerateFileSystemEntries(directory).Any())
            {
                try
                {
                    foreach(string fName in Directory.GetFiles(directory,"*"))
                    {
                        temp="";
                        int i = fName.LastIndexOf("xR")+2;
                        while(fName[i]!=' '&&fName[i]!='.')
                        {
                            temp+=fName[i];
                            i++;
                        }
                        if(Convert.ToInt32(temp)>x)
                            x=Convert.ToInt32(temp);
                    }
                    x+=1;
                } catch(Exception e)
                {
                    MessageLogManager.LogMessage("REPORT MANAGER - GLRNI ==> Unable to retrieve ID:\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                    x=-2;
                }
            }
            return x;
        }

        public bool SaveReport(string fullReportName,object report)
        {
            try
            {
                bFormatter=new BinaryFormatter();
                fStream=new FileStream(fullReportName,FileMode.Create,FileAccess.ReadWrite,FileShare.ReadWrite);
                fStream.Seek(0,SeekOrigin.Begin);
                using(Stream stream = fStream)
                {
                    bFormatter.Serialize(stream,report);
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("REPORT MANAGER - SR ==> Failed to save report: "+fullReportName+"\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return false;
            }
            return true;
        }

        protected object LoadReport(string fullReportName)
        {
            try
            {
                bFormatter=new BinaryFormatter();
                fStream=new FileStream(fullReportName,FileMode.Open,FileAccess.ReadWrite,FileShare.ReadWrite);
                using(Stream stream = fStream)
                {
                    return bFormatter.Deserialize(stream);
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("REPORT MANAGER - LR ==> failed to load: "+fullReportName+"\n"+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
                return null;
            }
        }
    }
}