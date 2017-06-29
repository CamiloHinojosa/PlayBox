using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace PlayBoxMonitor
{
    internal class MessageLogManager
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

        private void VerifyLogsDirectory(string[] paths)
        {
            foreach(string path in paths)
            {
                if(!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }
        }

        private void MLM(object files)
        {
            string[] fileNames = files as string[];
            bool close = false;
            VerifyLogsDirectory(new string[] { fileNames[0] });
            using(fs=new FileStream(fileNames[0]+@"\"+fileNames[1],FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite))
            {
                fs.Seek(0,SeekOrigin.End);
                sw=new StreamWriter(fs);
                VerifyLogsDirectory(new string[] { fileNames[0] });
                while(!close)
                {
                    pause.WaitOne();
                    if(messages.Count>0)
                    {
                        VerifyLogsDirectory(new string[] { fileNames[0] });
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