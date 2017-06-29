using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PlayBox
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App:Application
    {
        private static ProgramProperties mainProperties=new ProgramProperties();

        public static ProgramProperties MainProperties { get { return mainProperties; } }

        private static PropertiesManager manager = new PropertiesManager();

        public static PropertiesManager Manager { get { return manager; } }

        private void Application_Startup(object sender,StartupEventArgs e)
        {
            DirectoryManager.VerifyDirectoriesExist();
            mainProperties.Settings = manager.CurrentSettings;
            mainProperties.Setup = manager.CurrentSetup;
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
