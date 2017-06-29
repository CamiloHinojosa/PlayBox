using System;
using System.Windows.Forms;

namespace PlayBoxMonitor
{
    public partial class MainWindow:Form
    {
        private static Settings settingsConfiguration;
        private static Setup setupConfiguration;
        private static bool editModeEnabled = false, deleteModeEnabled = false, loadFinished = false, errorLoadingSettings = false;

        public static Setup SetupConfiguration
        {
            get { return setupConfiguration; }
            //set { setupConfiguration=value; }
        }

        public static Settings SettingsConfiguration
        {
            get { return settingsConfiguration; }
            //set { settingsConfiguration=value; }
        }

        public static bool EditModeEnabled
        {
            get { return editModeEnabled; }
        }

        public static bool DeleteModeEnabled
        {
            get { return deleteModeEnabled; }
        }

        public bool LoadFinished
        {
            get { return loadFinished; }
        }

        public bool ErrorLoadingSettings
        {
            get { return errorLoadingSettings; }
        }

        public MainWindow()
        {
            InitializeComponent();
            UpdateTextPosition();
            if(LoadSettings()!=1||LoadSetup()!=1)
                errorLoadingSettings=true;
            else
            {
                InitializeCLINReport();
                errorLoadingSettings=false;
                _autoSaveTimer.Start();
                _autoSaveTimer_Tick(null,null);
            }
            loadFinished=true;
        }

        private void InitializeCLINReport()
        {
            if(Program.Reporting)
                Program.ReportPipe.SendPackage("CLINxR","start",setupConfiguration);
        }

        private void InitializeIDs()
        {
            for(int i = 0;i<setupConfiguration.MaxNumberOFConsoles;i++)
                setupConfiguration.AvailableNumberIDs.Add(i);
        }

        private void UpdateTextPosition()
        {
            System.Drawing.Graphics g = CreateGraphics();
            double startingPoint = (Width/2)-(g.MeasureString(Text.Trim(),Font).Width/2);
            double widthOfASpace = g.MeasureString(" ",Font).Width;
            string tmp = " ";
            double tmpWidth = 0;

            while((tmpWidth+widthOfASpace)<startingPoint)
            {
                tmp+=" ";
                tmpWidth+=widthOfASpace;
            }
            Text=tmp+Text.Trim();
        }

        public uint LoadSetup()
        {
            uint flag = 0;
            try
            {
                SettingsManager sm = new SettingsManager(true);
                setupConfiguration=sm.LoadSetup();
                if(setupConfiguration!=null)
                    flag=RestoreConsoles();
                else
                {
                    setupConfiguration=new Setup();
                    flag=1;
                }
                if(setupConfiguration.AvailableNumberIDs.Count<=0&&setupConfiguration.ConsolesSetup.Count<=0)
                    InitializeIDs();
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("PBM  - MW ::::> Error failed to restore setup: "+e.Message);
            }
            return flag;
        }

        public uint LoadSettings()
        {
            try
            {
                SettingsManager sm = new SettingsManager();
                settingsConfiguration=sm.LoadSettings();
                if(settingsConfiguration==null)
                    settingsConfiguration=new Settings();
                sm.SaveSettings(settingsConfiguration);
                return 1;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("PBM  - MW ::::> Error failed to load settings: "+e.Message);
                return 2;
            }
        }

        private uint RestoreConsoles()
        {
            try
            {
                foreach(GameConsoleSetup consoleSetup in setupConfiguration.ConsolesSetup)
                {
                    GameConsole gc = new GameConsole(consoleSetup);
                    _consolesContainer.Controls.Add(gc);
                }
                _consolesContainer.Update();
                _consolesContainer.Refresh();
                _consolesContainer.PerformLayout();
                return 1;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("PBM  - MW ::::> Error failed to restore console: "+e.Message);
                return 0;
            }
        }

        private void CreateConsoles(int count,GameConsoleSetup consoleSettings)
        {
            try
            {
                for(int i = 0;i<count;i++)
                {
                    GameConsoleSetup cs = new GameConsoleSetup();
                    consoleSettings.CopySettings(cs);
                    cs.NumberID=setupConfiguration.AvailableNumberIDs[0];
                    setupConfiguration.ConsolesSetup.Add(cs);
                    GameConsole gc = new GameConsole(cs);
                    _consolesContainer.Controls.Add(gc);
                    setupConfiguration.AvailableNumberIDs.Remove(setupConfiguration.AvailableNumberIDs[0]);
                    setupConfiguration.NumberOfConsoles++;
                }
                MessageBox.Show(_consolesContainer.Controls.Count.ToString());
                _consolesContainer.Update();
                _consolesContainer.Refresh();
                _consolesContainer.PerformLayout();
                SaveSetup();
            } catch(Exception e)
            { MessageLogManager.LogMessage("PBM  - MW ::::> Error failed to create console: "+e.Message); }
        }

        public static void DeleteGameConsoleControl(GameConsole gc)
        {
            using(ConfirmationWindow confirmation = new ConfirmationWindow("#delete"))
            {
                if(confirmation.ShowDialog()==DialogResult.OK)
                {
                    Program.ReportPipe.SendPackage("INACxCOM","deletereport",gc.Settings.ReportProperties.COSExR_Name);
                    setupConfiguration.ConsolesSetup.Remove(gc.Settings);
                    gc.Parent.Controls.Remove(gc);
                    setupConfiguration.AvailableNumberIDs.Add(gc.Settings.NumberID);
                    gc.Dispose();
                    setupConfiguration.NumberOfConsoles--;
                }
                SaveSetup();
            }
        }

        public static void EditGameConsoleControl(GameConsole gc)
        {
            using(CreateConsoleWindow editConsole = new CreateConsoleWindow(new CreateConsoleParameters(gc.Settings,1),true))
            {
                if(editConsole.ShowDialog()==DialogResult.OK)
                {
                    gc.RefreshSettings();
                    SaveSetup();
                }
            }
        }

        private static void SaveSettings()
        {
            SettingsManager sm = new SettingsManager();
            sm.SaveSettings(settingsConfiguration);
            sm=null;
        }

        private static void SaveSetup()
        {
            SettingsManager sm = new SettingsManager(true);
            sm.SaveSetup(setupConfiguration);
            sm=null;
        }

        private void _settingsToolStripMenuItem_Click(object sender,EventArgs e)
        {
            using(EditSettingsWindows editSettings = new EditSettingsWindows(settingsConfiguration))
            {
                if(editSettings.ShowDialog()==DialogResult.OK)
                {
                    SettingsManager sManager = new SettingsManager();
                    sManager.SaveSettings(editSettings.editedSettings);
                    sManager=new SettingsManager(true);
                    sManager.SaveSetup(setupConfiguration);
                    _consolesContainer.Controls.Clear();
                    LoadSettings();
                    LoadSetup();
                    sManager=null;
                }
            }
        }

        public void AddConsoles(int count,GameConsoleSetup cs) //Check if if statement really needed!!!!!!
        {
            try
            {
                if(setupConfiguration.AvailableNumberIDs.Count>=count)
                {
                    CreateConsoles(count,cs);
                    MessageBox.Show("\nAvailable Number IDs: "+setupConfiguration.AvailableNumberIDs.Count+"\nNumber Of Console To Create: "+count);
                }
                else if(setupConfiguration.AvailableNumberIDs.Count<count)
                    MessageBox.Show("You've reached the limit amount of Consoles");
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("PBM  - MW ::::> Error failed to add console: "+e.Message);
            }
        }

        private void _addConsole_Click(object sender,EventArgs e)
        {
            try
            {
                if(setupConfiguration.NumberOfConsoles<10)
                {
                    CreateConsoleParameters ccp = new CreateConsoleParameters();
                    ccp.Count=setupConfiguration.AvailableNumberIDs.Count;
                    using(CreateConsoleWindow ccw = new CreateConsoleWindow(ccp))
                    {
                        if(ccw.ShowDialog()==DialogResult.OK)
                            AddConsoles(ccp.Count,ccp.Setup);
                    }
                }
                else
                {
                    MessageBox.Show("You've reached the limit amount of Consoles");
                }
            } catch(Exception ex)
            { MessageLogManager.LogMessage("PBM  - MW ::::> Error failed to start Add Console:"+ex.Message); }
        }

        private void EnableDisbaleGameConsoleControlEditMode(bool enable,bool editMode = true)
        {
            foreach(GameConsole gc in _consolesContainer.Controls)
            {
                if(enable)
                    if(editMode)
                        gc.EnableEditModeGraphics();
                    else
                        gc.EnableDeleteModeGraphics();
                else
                    gc.DisableEditDeleteModeGraphics();
            }
            SaveSetup();
        }

        private void _removeConsole_Click(object sender,EventArgs e)
        {
            if(!editModeEnabled)
            {
                if(!deleteModeEnabled)
                {
                    deleteModeEnabled=true;
                    _removeConsole.BackColor=System.Drawing.ColorTranslator.FromHtml("#A1A122");
                    _removeConsole.FlatAppearance.BorderColor=System.Drawing.ColorTranslator.FromHtml("#F1F133");
                    EnableDisbaleGameConsoleControlEditMode(deleteModeEnabled,false);
                }
                else
                {
                    deleteModeEnabled=false;
                    _removeConsole.BackColor=System.Drawing.Color.FromArgb(90,90,95);
                    _removeConsole.FlatAppearance.BorderColor=System.Drawing.Color.FromArgb(90,90,95);
                    EnableDisbaleGameConsoleControlEditMode(deleteModeEnabled);
                }
            }
            else
                MessageBox.Show("Error(AxM1xRCx0): Unable to delete while edit mode is enabled. Please desable edit mode to enable delete mode.");
        }

        private void _editConsole_Click(object sender,EventArgs e)
        {
            if(!deleteModeEnabled)
            {
                if(!editModeEnabled)
                {
                    editModeEnabled=true;
                    _editConsole.BackColor=System.Drawing.ColorTranslator.FromHtml("#A1A122");
                    _editConsole.FlatAppearance.BorderColor=System.Drawing.ColorTranslator.FromHtml("#F1F133");
                    EnableDisbaleGameConsoleControlEditMode(editModeEnabled,true);
                }
                else
                {
                    editModeEnabled=false;
                    _editConsole.BackColor=System.Drawing.Color.FromArgb(90,90,95);
                    _editConsole.FlatAppearance.BorderColor=System.Drawing.Color.FromArgb(90,90,95);
                    EnableDisbaleGameConsoleControlEditMode(editModeEnabled);
                }
            }
            else
                MessageBox.Show("Error(AxM1xRCx0): Unable to edit while delete mode is enabled. Please desable delete mode to enable edit mode.");
        }

        private void _removeAllConsoles_Click(object sender,EventArgs e)
        {
            using(ConfirmationWindow confirmation = new ConfirmationWindow("#deleteAll"))
            {
                _autoSaveTimer.Stop();
                if(confirmation.ShowDialog()==DialogResult.OK)
                {
                    Program.ReportPipe.SendPackage("INACxCOM","deleteall","cosexr");
                    _consolesContainer.Controls.Clear();
                    setupConfiguration.AvailableNumberIDs.Clear();
                    setupConfiguration.ConsolesSetup.Clear();
                    setupConfiguration.NumberOfConsoles=0;
                    InitializeIDs();
                }
                SaveSetup();
                _autoSaveTimer.Start();
            }
        }

        private void _save_Click(object sender,EventArgs e)
        {
            SaveSettings();
            SaveSetup();
        }

        private void MainWindow_FormClosing(object sender,FormClosingEventArgs e)
        {
            _autoSaveTimer_Tick(null,null);
        }

        private void _deleteCOSExRToolStrip_Click(object sender,EventArgs e)
        {
            SaveSetup();
            Program.ReportPipe.SendPackage("INACxCOM","deleteall","cosexr");
            _consolesContainer.Controls.Clear();
            LoadSetup();
        }

        private void _deleteAllToolStrip_Click(object sender,EventArgs e)
        {
            SaveSetup();
            Program.ReportPipe.SendPackage("INACxCOM","deleteall","all");
            _consolesContainer.Controls.Clear();
            LoadSetup();
        }

        private void _consolesContainer_Paint(object sender,PaintEventArgs e)
        {
            _consolesContainer.PerformLayout();
        }

        private void _deleteCLINxRToolStrip_Click(object sender,EventArgs e)
        {
            Program.ReportPipe.SendPackage("INACxCOM","deleteall","clinxr");
        }

        private void _reportsOpenToolStrip_Click(object sender,EventArgs e)
        {
            ToolStripMenuItem selection = sender as ToolStripMenuItem;
            switch(selection.Tag.ToString())
            {
                case "open":
                    System.Diagnostics.Process.Start(@"Extensions\PlayBoxInteractiveReportViewer.exe","OpenReport");
                    break;

                case "opencurrent":
                    /*InitializeCLSEReport();
                    System.Diagnostics.Process.Start("PlayBoxInteractiveReportViewer.exe",("ShowCLSEReport$"+settingsConfiguration.CLSEReportName));
                    */
                    break;

                case "openreportviewer":
                    System.Diagnostics.Process.Start(@"Extensions\PlayBoxInteractiveReportViewer.exe");
                    break;
            }
            _consolesContainer.Update();
            _consolesContainer.Refresh();
        }

        private void MainWindow_Load(object sender,EventArgs e)
        {
            TopMost=false;
        }

        private void _autoSaveTimer_Tick(object sender,EventArgs e)
        {
            SaveSetup();
        }
    }
}