using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PlayBox
{
    static class DirectoryManager
    {
        private static string appDataDirectory="App Data", configurationDirectory="Configuration", settingsFileName="Settings.dat", setupFileName="Setup.dat", logsDirectory="Logs", errorLogFileName="Error Log";

        public static string @AppDataDirectory { get { return Directory.GetCurrentDirectory()+@"\"+appDataDirectory; } set { appDataDirectory = value; } }
        public static string @ConfigurationDirectory { get { return AppDataDirectory + @"\"+ configurationDirectory; }  set { configurationDirectory = value; } }
        public static string @LogsDirectory { get { return AppDataDirectory + @"\" + logsDirectory; } set { logsDirectory = value; } }
        public static string @SettingsFileName { get { return ConfigurationDirectory + @"\" + settingsFileName; } }
        public static string @SetupFileName { get { return ConfigurationDirectory + @"\" + setupFileName; } }
        public static string @ErrorLogFileName { get { return LogsDirectory + @"\" + errorLogFileName; } }

        public static void VerifyDirectoriesExist()
        {
            if(!Directory.Exists(AppDataDirectory))
                Directory.CreateDirectory(AppDataDirectory);
            if(!Directory.Exists(ConfigurationDirectory))
                Directory.CreateDirectory(ConfigurationDirectory);
            if(!Directory.Exists(LogsDirectory))
                Directory.CreateDirectory(LogsDirectory);
        }
    }
}
