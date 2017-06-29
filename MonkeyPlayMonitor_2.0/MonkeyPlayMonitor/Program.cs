using System;
using System.Threading;
using System.Windows.Forms;

namespace PlayBoxMonitor
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///
        public static bool Reporting = false;

        public static Pipe ReportPipe;

        private static Thread reportPipeProc;

        public static bool ApplicationIsActivated()
        {
            var activatedHandle = NativeMethods.GetForegroundWindow();
            if(activatedHandle==IntPtr.Zero)
            {
                return false;       // No window is currently activated
            }

            var procId = System.Diagnostics.Process.GetCurrentProcess().Id;
            int activeProcId;
            NativeMethods.GetWindowThreadProcessId(activatedHandle,out activeProcId);

            return activeProcId==procId;
        }

        private static void StartMessageLog()
        {
            Settings set = new Settings();
            MessageLogManager mlm = new MessageLogManager();
            mlm.StartMLM(new string[] { set.LogsPath,set.ErrorLogName });
        }

        private static void StartReporting()
        {
            try
            {
                //System.Diagnostics.Process.Start(@"Extensions\PlayBoxReportGenerator.exe");
                System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
                start.FileName=@"Extensions\PlayBoxReportGenerator.exe";
                start.WindowStyle=System.Diagnostics.ProcessWindowStyle.Hidden;
                System.Diagnostics.Process.Start(start);
                ReportPipe=new Pipe();
                reportPipeProc=new Thread(ReportPipe.CommandListener);
                reportPipeProc.Start();
                reportPipeProc.Name="PlayBox Monitor - PPRep Manager";
                Reporting=true;
                //ADD CLIENTS REPORT COMMAND!
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("PBM - PGM ::::> Error Report Process failed to start: "+e.Message);
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
            StartReporting();
            MainWindow mainWindow = new MainWindow();
            IntroLoadingWindow intro = new IntroLoadingWindow();
            intro.InitializeIntroDisplay();
            while(!mainWindow.LoadFinished||mainWindow.ErrorLoadingSettings)
                intro.Continue();
            if(!mainWindow.ErrorLoadingSettings)
                Application.Run(mainWindow);
            if(ReportPipe!=null)
                ReportPipe.SendPackage("INACxCOM","close","closeserver");
            MessageLogManager.LogMessage("close");
        }
    }
}