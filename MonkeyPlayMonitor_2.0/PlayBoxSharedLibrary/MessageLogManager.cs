using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace PlayBoxSharedLibrary
{
    public class MessageLogManager
    {
        private static FileStream fs;
        private static StreamWriter sw;
        private Thread mlmProc;
        private static List<string> messages = new List<string> { };
        private static ManualResetEvent pause = new ManualResetEvent(false);

        public void StartMLM(object fileNames)
        {
            mlmProc=new Thread(new ParameterizedThreadStart(MLM));
            mlmProc.Start(fileNames);
            mlmProc.Name="PlayBox - Message Log Manager";
            mlmProc.IsBackground=true;
        }

        private string @VerifyLogsDirectory(string[] fileNames)
        {
            string @path = "";
            for(int i = 0;i<fileNames.Length-1;i++)
            {
                path+=fileNames[i]+@"\";
                if(!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                System.Diagnostics.Debug.WriteLine(path+": "+i);
            }
            return path;
        }

        private void MLM(object files)
        {
            bool close = false;
            string[] fileNames = files as string[];
            string @path = VerifyLogsDirectory(fileNames);
            if(File.Exists(path+fileNames[fileNames.Length-1]))
            {
                FileInfo fi = new FileInfo(path+fileNames[fileNames.Length-1]);
                if(fi!=null)
                {
                    if(fi.CreationTime.ToString("MM/yy")==DateTime.Now.ToString("MM/yy"))
                    {
                        System.Diagnostics.Debug.WriteLine("File Time: "+(int.Parse(fi.CreationTime.ToString("dd"))+7).ToString());
                        System.Diagnostics.Debug.WriteLine("Present Time: "+int.Parse(DateTime.Now.ToString("dd")));
                        if(int.Parse(fi.CreationTime.ToString("dd"))+7<=int.Parse(DateTime.Now.ToString("dd")))
                        {
                            fi.Delete();
                        }
                    }
                    fi.Delete();
                }
            }
            using(fs=new FileStream(path+fileNames[fileNames.Length-1],FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite))
            {
                fs.Seek(0,SeekOrigin.End);
                sw=new StreamWriter(fs);
                VerifyLogsDirectory(fileNames);
                while(!close)
                {
                    pause.WaitOne();
                    if(messages.Count>0)
                    {
                        VerifyLogsDirectory(fileNames);
                        sw.WriteLine("["+DateTime.Now.ToString()+"] "+messages[0]);
                        sw.Flush();
                        if(messages[0]=="close")
                            close=true;
                        messages.RemoveAt(0);
                    }
                    else
                        pause.Reset();
                }
            }
        }

        public static void LogMessage(string log)
        {
            messages.Add(log);
            pause.Set();
        }
    }
}