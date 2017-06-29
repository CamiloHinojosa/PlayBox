using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayBoxReporting
{
    public class ReportManager
    {
        protected FileStream fStream;
        protected BinaryFormatter bFormatter;
        protected COSEReport COSExR;
        protected CLSEReport CLSExR;

        public static string @reportsDirectory = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments)+@"\PlayBox Reports";
        public static string @COSEDirectory = reportsDirectory+@"\Session Reports";
        public static string @CODirectory = reportsDirectory+@"\Consumption Reports";
        public static string @CLCODirectory = CODirectory+@"\Client Session Reports";
        public static string @DACODirectory = CODirectory+@"\Daily Consumption Reports";
        public static string @MOCODirectory = CODirectory+@"\Monthly Consumption Reports";

        public COSEReport COSExReport { get { return COSExR; } }
        public CLSEReport CLSExReport { get { return CLSExR; } }

        public ReportManager()
        {
            VerifyDirectories();
        }

        public bool VerifyDate(DateTime date)
        {
            if(date.Date.ToShortDateString()==DateTime.Now.Date.ToShortDateString())//CHECK LIBRARY REFERENCE TO SEE IF THERE IS A YEARMONTHDATE VALUE
                return true;
            else
                return false;
        }

        public void VerifyDirectories()
        {
            try
            {
                if(!Directory.Exists(reportsDirectory))
                    Directory.CreateDirectory(reportsDirectory);
                if(!Directory.Exists(COSEDirectory))
                    Directory.CreateDirectory(COSEDirectory);
                if(!Directory.Exists(CODirectory))
                    Directory.CreateDirectory(CODirectory);
                if(!Directory.Exists(CLCODirectory))
                    Directory.CreateDirectory(CLCODirectory);
                if(!Directory.Exists(DACODirectory))
                    Directory.CreateDirectory(DACODirectory);
                if(!Directory.Exists(MOCODirectory))
                    Directory.CreateDirectory(MOCODirectory);
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("VerifyDirectories ERROR: "+e.Message+"\n"+reportsDirectory+"\n"+COSEDirectory+"\n"+CODirectory+"\n"+CLCODirectory+"\n"+DACODirectory+"\n"+MOCODirectory);
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
                            x=Convert.ToInt32(temp);//(int)char.GetNumericValue((fName[fName.LastIndexOf('R')+1]));
                    }
                    x+=1;
                } catch(Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("Error(CxRPMxGLRNx0):"+e.Message);
                    x=-2;
                }
            }
            return x;
        }
    }
}