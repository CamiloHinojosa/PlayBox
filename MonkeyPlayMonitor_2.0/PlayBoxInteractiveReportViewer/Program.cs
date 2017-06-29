using PlayBoxSharedLibrary;
using System;
using System.Windows.Forms;

namespace PlayBoxInteractiveReportViewer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///

        private static string @errorLogPath = "Report Viewer Logs", @errorLogName = "Error Log.txt";

        private static void StartMessageLog()
        {
            MessageLogManager mlm = new MessageLogManager();
            mlm.StartMLM(new string[] { "Extensions",errorLogPath,errorLogName });
        }

        private static void ParseArguments(string[] args)
        {
            foreach(string arg in args)
            {
                switch(arg)
                {
                    case "OpenReport":
                        ReportViewerDisplay rvd = new ReportViewerDisplay();
                        rvd.ShowOpenFileDialog();
                        break;

                    default:
                        break;
                }
            }
        }

        [STAThread]
        private static void Main()
        {
            if(Environment.OSVersion.Version.Major>=6)
                NativeMethods.SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartMessageLog();
            string[] args = Environment.GetCommandLineArgs();
            if(args.Length>1)
                ParseArguments(args);
            else
                Application.Run(new MainWindow());
        }
    }
}