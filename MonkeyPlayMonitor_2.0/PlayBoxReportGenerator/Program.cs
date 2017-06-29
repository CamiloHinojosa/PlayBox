using PlayBoxSharedLibrary;
using System.IO;
using System.IO.Pipes;

namespace PlayBoxReportGenerator
{
    internal class Program
    {
        private static string @errorLogPath = "Report Generator Logs", @errorLogName = "Error Log.txt";

        private static void StartMessageLog()
        {
            MessageLogManager mlm = new MessageLogManager();
            mlm.StartMLM(new string[] { "Extensions",errorLogPath,errorLogName });
        }

        private static void StartListening()
        {
            bool close = false;
            string message = "";
            Interpreter ittp = new Interpreter();
            using(NamedPipeServerStream reportGeneratorServer = new NamedPipeServerStream("ReportGenerator",PipeDirection.InOut))
            {
                MessageLogManager.LogMessage("Waiting for connection with PlayBoxMonitor");
                reportGeneratorServer.WaitForConnection();
                MessageLogManager.LogMessage("Connection stablished with PlayBoxMonitor");
                using(StreamReader reciever = new StreamReader(reportGeneratorServer))
                using(StreamWriter sender = new StreamWriter(reportGeneratorServer))
                {
                    while(!close)
                    {
                        message=ittp.InterpreteData(reciever.ReadLine());
                        if(message!=null)
                        {
                            sender.WriteLine(message);
                            if(message!="closingserver")
                                sender.Flush();
                            else
                                close=true;
                            MessageLogManager.LogMessage("\n\n\nWaiting for packet...\n\n");
                        }
                        if(reciever.BaseStream==null||!reportGeneratorServer.IsConnected)
                            close=true;
                    }
                }
                reportGeneratorServer.Close();
            }
        }

        private static void Main(string[] args)
        {
            StartMessageLog();
            StartListening();
        }
    }
}