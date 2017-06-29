using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlayBoxMonitor
{
    public partial class GameConsole:Control
    {
        private double consumtionPrice = MainWindow.SettingsConfiguration.Price, extraControlPrice = MainWindow.SettingsConfiguration.ExtraControlPrice, minimumConsumption = MainWindow.SettingsConfiguration.MinimumConsumption;

        private string currency = MainWindow.SettingsConfiguration.Currency;

        private GameConsole dropSource;

        private bool resuming = false, lapsConsumptionActive = MainWindow.SettingsConfiguration.LapsConsumption;

        private GameConsoleSetup settings;

        private Timer timeControl, prePaidControl, notificationTimer;

        private int timeInterval = MainWindow.SettingsConfiguration.TimeInterval, perDivisor = MainWindow.SettingsConfiguration.PerDivisor, timeDivisor = MainWindow.SettingsConfiguration.TimeDivisor, minimumTime = MainWindow.SettingsConfiguration.MinimumTime;

        private System.Media.SoundPlayer splayer;

        public GameConsoleSetup Settings
        {
            get { return settings; }
            //set { this.settings=value; }
        }

        public GameConsole()
        {
            InitializeComponent();
        }

        public GameConsole(GameConsoleSetup settings)
        {
            try
            {
                splayer=new System.Media.SoundPlayer(PlayBoxMonitor.Properties.Resources.Ring01);
                settings.Properties.EndTime=new DateTime();
                timeControl=new Timer();
                this.settings=settings;
                if(settings.ReportProperties.COSExR_Name==null)
                    settings.ReportProperties.COSExR_Name=" ";
                if(settings.ReportProperties.CLINxR_Name==null)
                    settings.ReportProperties.CLINxR_Name=MainWindow.SetupConfiguration.CLINReportName;
                InitializeComponent();
                InitializeControls();
                InitializeTimeControl();
                InitializePrePaidControl();
                InitializeCOSEReport();
                AddControls();
                DisplayExtraControls();
                DisplayConsumption();
                DisplayTime();
                ResumeStatus();
                Click+=_GameConsoleControl_Click;
            } catch(Exception e)
            { MessageLogManager.LogMessage("PBM - GCC ::::> Error GC failed to build: "+e.Message); }
        }

        //--------------------------------------------------------------------------------Setup------------------------------------------------------------------------------------------------------------

        private void InitializeControls()
        {
            _nameLabel.Text=settings.Name+": ("+(settings.NumberID+1)+")";
            _startStop.BackColor=ColorTranslator.FromHtml(settings.ColorID);
            _startStop.Text="START";
            _startStop.Click+=_start_Click;
            _extraControlsDisplay.ValueChanged+=_controls_ValueChanged;
            _cashReset.BackColor=ColorTranslator.FromHtml(settings.ColorID);
            _cashReset.Text="CASH";
            _startStop.MouseEnter+=GameConsoleControl_MouseHover;
            _cashReset.MouseEnter+=GameConsoleControl_MouseHover;
            _consumptionDisplay.MouseEnter+=GameConsoleControl_MouseHover;
            _nameLabel.MouseEnter+=GameConsoleControl_MouseHover;
            _extraControlsLabel.MouseEnter+=GameConsoleControl_MouseHover;
            _pictureBox.MouseEnter+=GameConsoleControl_MouseHover;
            _timeDisplay.MouseEnter+=GameConsoleControl_MouseHover;
            _timeLabel.MouseEnter+=GameConsoleControl_MouseHover;
            _totalConsumptionLabel.MouseEnter+=GameConsoleControl_MouseHover;
            _startStop.MouseLeave+=GameConsoleControl_MouseLeave;
            _cashReset.MouseLeave+=GameConsoleControl_MouseLeave;
            _consumptionDisplay.MouseLeave+=GameConsoleControl_MouseLeave;
            _nameLabel.MouseLeave+=GameConsoleControl_MouseLeave;
            _pictureBox.MouseLeave+=GameConsoleControl_MouseLeave;
            _extraControlsLabel.MouseLeave+=GameConsoleControl_MouseLeave;
            _timeDisplay.MouseLeave+=GameConsoleControl_MouseLeave;
            _timeLabel.MouseLeave+=GameConsoleControl_MouseLeave;
            _totalConsumptionLabel.MouseLeave+=GameConsoleControl_MouseLeave;
        }

        private void AddControls()
        {
            Controls.Add(_nameLabel);
            Controls.Add(_cashReset);
            Controls.Add(_consumptionDisplay);
            Controls.Add(_extraControlsDisplay);
            Controls.Add(_extraControlsLabel);
            Controls.Add(_pictureBox);
            Controls.Add(_startStop);
            Controls.Add(_timeDisplay);
            Controls.Add(_timeLabel);
            Controls.Add(_totalConsumptionLabel);
            Refresh();
        }

        public void ResumeStatus()
        {
            if(settings.Properties.Status!=0)
            {
                resuming=true;
                if(settings.Properties.PrePaid)
                    _consumptionDisplay.Text=currency+" "+(settings.Properties.TotalConsumption).ToString("00.00");
                if(settings.Properties.Status==1||settings.Properties.Status==3||settings.Properties.Status==5)
                {
                    settings.Properties.Status=0;
                    _start_Click(null,null);
                }
                else if(settings.Properties.Status==2)
                {
                    settings.Properties.Status=0;
                    _cashReset.Click+=_cash_Click;
                    _stop_Click(null,null);
                }
                else if(settings.Properties.Status==4)
                {
                    settings.Properties.Status=0;
                    _cash_Click(null,null);
                }
            }
        }

        private void InitializePrePaidControl()
        {
            prePaidControl=new Timer();
            prePaidControl.Tick+=_prePaidControl_Tick;
            prePaidControl.Interval=timeInterval;
            notificationTimer=new Timer();
            notificationTimer.Tick+=_notificationTimer_Tick;
            notificationTimer.Interval=1000;

        }

        private void InitializeTimeControl()
        {
            timeControl.Tick+=_timeControl_Tick;
            timeControl.Interval=timeInterval;
        }

        //--------------------------------------------------------------------------------Graphics---------------------------------------------------------------------------------------------------------

        protected override void OnPaint(PaintEventArgs pe)
        {
            InitializeBoders();
            base.OnPaint(pe);
        }

        private void InitializeBoders(bool hover = false)
        {
            Rectangle border, subBorder;
            Graphics cg = CreateGraphics();
            if(!hover)
            {
                border=new Rectangle(new Point(BorderProperties.Width,BorderProperties.Height),new Size(Width-(2*BorderProperties.Width),Height-(2*BorderProperties.Height)));
                border.Inflate(BorderProperties.Width,BorderProperties.Height);
                ControlPaint.DrawBorder(cg,border,Color.FromArgb(BorderProperties.Red,BorderProperties.Green,BorderProperties.Blue),ButtonBorderStyle.Solid);
            }
            else
            {
                border=new Rectangle(new Point(BorderProperties.WidthHover,BorderProperties.HeightHover),new Size(Width-(2*BorderProperties.WidthHover),Height-(2*BorderProperties.HeightHover)));
                border.Inflate(BorderProperties.WidthHover,BorderProperties.HeightHover);
                ControlPaint.DrawBorder(cg,border,Color.FromArgb(BorderProperties.RedHover,BorderProperties.GreenHover,BorderProperties.BlueHover),ButtonBorderStyle.Solid);
            }
            subBorder=new Rectangle(new Point(3,3),new Size(Width-6,Height-6));
            subBorder.Inflate(2,2);
            ControlPaint.DrawBorder(cg,subBorder,Color.FromArgb(190,190,200),ButtonBorderStyle.Solid);
        }

        public void DisableEditDeleteModeGraphics()
        {
            BorderProperties.HoverValue("normal");
            BackColor=Color.White;
        }

        public void EnableDeleteModeGraphics()
        {
            BorderProperties.HoverValue("delete");
            BackColor=Color.Brown;
        }

        public void EnableEditModeGraphics()
        {
            BorderProperties.HoverValue("edit");
            BackColor=Color.DodgerBlue;
        }

        public void RefreshSettings()
        {
            _startStop.BackColor=ColorTranslator.FromHtml(settings.ColorID);
            _cashReset.BackColor=ColorTranslator.FromHtml(settings.ColorID);
            _nameLabel.Text=settings.Name+": ("+(settings.NumberID+1)+")";
        }

        private void SetCashGraphicSetup()
        {
            _cashReset.Text="RESET";
            _startStop.BackColor=ColorTranslator.FromHtml(settings.ColorID);
            if(!settings.Properties.PrePaid)
            {
                BackColor=ColorTranslator.FromHtml("#DFDF2A");
                _cashReset.BackColor=Color.RoyalBlue;
            }
            else
            {
                BackColor=ColorTranslator.FromHtml("#DFDF2F");
                _cashReset.BackColor=Color.MediumSlateBlue;
            }
        }

        private void SetStartGraphicSetup()
        {
            _startStop.Text="STOP";
            if(!settings.Properties.PrePaid)
            {
                BackColor=ColorTranslator.FromHtml("#1589FF");
                _startStop.BackColor=Color.Crimson;
            }
            else
            {
                BackColor=ColorTranslator.FromHtml("#2AAF2F");
                _startStop.BackColor=Color.OrangeRed;
            }
        }

        private void SetStopGraphicSetup()
        {
            _startStop.Text="RESUME";
            if(!settings.Properties.PrePaid)
            {
                BackColor=ColorTranslator.FromHtml("#C11B17");
                _startStop.BackColor=Color.DodgerBlue;
            }
            else
            {
                BackColor=ColorTranslator.FromHtml("#566D7E");
                _startStop.BackColor=Color.SteelBlue;
            }
        }

        private void ResetGraphicSetup()
        {
            _cashReset.BackColor=ColorTranslator.FromHtml(settings.ColorID);
            _startStop.BackColor=ColorTranslator.FromHtml(settings.ColorID);
            _startStop.Text="START";
            _cashReset.Text="CASH";
            BackColor=Color.White;
        }

        private void DisplayConsumption()
        {
            _consumptionDisplay.Text=currency+" "+(settings.Properties.TotalConsumption+settings.Properties.LastTotalConsumption).ToString("00.00");
            _consumptionDisplay.Refresh();
        }

        private void DisplayExtraControls()
        {
            _extraControlsDisplay.Value=settings.Properties.ExtraControls;
            _extraControlsDisplay.Refresh();
        }

        private void DisplayTime()
        {
            _timeDisplay.Text=TimeSpan.FromSeconds(settings.Properties.TimeElapsed+settings.Properties.LastTimeElapsed).ToString();
            _timeDisplay.Refresh();
        }

        //-------------------------------------------------------------------------------Calculations----------------------------------------------------------------------------------------------------

        private void ConsumptionCalculation()
        {
            if(!lapsConsumptionActive||settings.Properties.PrePaid)
                settings.Properties.TotalConsumption=ConsumptionCalculator(settings.Properties.TimeElapsed);
            else
                settings.Properties.TotalConsumption=ConsumptionCalculatorByLaps(settings.Properties.TimeElapsed);
            if(settings.Properties.TotalConsumption<=minimumConsumption)
                settings.Properties.TotalConsumption=minimumConsumption;
        }

        private double ConsumptionCalculator(double timeElapsed)
        {
            return Math.Round(((timeElapsed/timeDivisor)/perDivisor)*(consumtionPrice+((double)settings.Properties.ExtraControls*extraControlPrice)),2);
        }

        private double ConsumptionCalculatorByLaps(double timeElapsed)
        {
            return Math.Round(((timeElapsed/timeDivisor/perDivisor)+1)*(consumtionPrice+(extraControlPrice*(int)settings.Properties.ExtraControls)),2);
        }

        private void PerformPrePaidStopCalculation()
        {
            prePaidControl.Stop();
            DisplayTime();
        }

        private void PerformStopCalculation()
        {
            timeControl.Stop();
            TimeCalculation();
            DisplayTime();
            DisplayConsumption();
        }

        private void PrePaidTimeCalulation()
        {
            settings.Properties.EndTime=DateTime.Now;
            settings.Properties.TimeElapsed-=(int)Math.Round(settings.Properties.EndTime.Subtract(settings.Properties.StartTime).TotalSeconds,0);
            settings.Properties.StartTime=settings.Properties.EndTime;
        }

        private void TimeCalculation()
        {
            settings.Properties.EndTime=DateTime.Now;
            settings.Properties.TimeElapsed+=(int)Math.Round(settings.Properties.EndTime.Subtract(settings.Properties.StartTime).TotalSeconds,0);
            settings.Properties.StartTime=settings.Properties.EndTime;
            if(((settings.Properties.TimeElapsed+settings.Properties.LastTimeElapsed)%minimumTime)==0)
                ConsumptionCalculation();
        }

        private double TimeOffset()//Calculates if time to calculate passed 50% of minimum time!!
        {
            return (((double)settings.Properties.TimeElapsed/(perDivisor*timeDivisor)))-Math.Floor((double)(settings.Properties.TimeElapsed/(perDivisor*timeDivisor)));
        }

        //---------------------------------------------------------------------------------Methods----------------------------------------------------------------------------------------------------------
        public void DropReset()
        {
            if(settings.Properties.Status!=4)
                _cash_Click(null,null);
            _reset_Click(null,null);
            DeleteLastCOSESession();
        }

        private void HandleDropSession()
        {
            InitializeCOSEWithCLINSession();
            CopyCOSESession();
            dropSource.DropReset();
        }

        private void ResetControls()
        {
            settings.Properties.EndTime=new DateTime();
            settings.Properties.StartTime=new DateTime();
            timeControl.Interval=timeInterval;
            settings.Properties=new GameConsoleProperties();
            settings.ClientData=new GameConsoleClientInformation();
            DisplayExtraControls();
            DisplayTime();
            DisplayConsumption();
            _startStop.Click+=_start_Click;
        }

        //-------------------------------------------------------------------------------Event Methods-----------------------------------------------------------------------------------------------------

        private void DetermineStartStatus()
        {
            if(settings.Properties.Status==2)
            {
                settings.Properties.StartTime=DateTime.Now;
                settings.Properties.EndTime=DateTime.Now;
                settings.Properties.Status=3;
            }
            else if(settings.Properties.Status==0)
            {
                if(!resuming)
                {
                    settings.Properties.StartTime=DateTime.Now;
                    settings.Properties.EndTime=DateTime.Now;
                }
                if(!settings.Properties.PrePaid)
                {
                    TimeCalculation();
                    settings.Properties.Status=1;
                }
                else
                {
                    PrePaidTimeCalulation();
                    settings.Properties.Status=5;
                }
                _cashReset.Click+=_cash_Click;
            }
        }

        private void ShowClickWindow()
        {
            using(GameConsoleClickWindow gcppo = new GameConsoleClickWindow(settings))
            {
                if(gcppo.ShowDialog()==DialogResult.OK&&settings.Properties.PrePaid)
                {
                    if(settings.Properties.Status==0)
                        settings.Properties.TimeElapsed=0;
                    settings.Properties.TimeElapsed+=settings.Properties.PrePaidTime;
                    ConsumptionCalculation();
                    DisplayTime();
                    DisplayConsumption();
                        _startStop.BackColor=Color.DarkCyan;
                }
                else if(!settings.Properties.PrePaid)
                {
                    ResetGraphicSetup();
                    ResetControls();
                }
            }
        }

        private void ShowPrePaidWindow()
        {
            int lastPPTime=settings.Properties.PrePaidTime, lastTimeElapsed;
            using(GameConsolePPClickWindow gcppo = new GameConsolePPClickWindow(settings))
            {
                if(gcppo.ShowDialog()==DialogResult.OK)
                {
                    lastTimeElapsed=settings.Properties.TimeElapsed;
                    settings.Properties.TimeElapsed=settings.Properties.PrePaidTime+lastPPTime;
                    ConsumptionCalculation();
                    settings.Properties.TimeElapsed=lastTimeElapsed+settings.Properties.PrePaidTime;
                    DisplayTime();
                    DisplayConsumption();
                }
            }
        }

        //-------------------------------------------------------------------------------Events------------------------------------------------------------------------------------------------------------

        private void _GameConsoleControl_Click(object sender,EventArgs e)
        {
            if(settings.Properties.Status==0)
            {
                if(MainWindow.EditModeEnabled)
                    MainWindow.EditGameConsoleControl(this);
                else if(MainWindow.DeleteModeEnabled)
                    MainWindow.DeleteGameConsoleControl(this);
                else
                    ShowClickWindow();
            }
        }

        private void _pictureBox_Click(object sender,EventArgs e)
        {
            if(settings.Properties.PrePaid&&settings.Properties.Status!=0)
                ShowPrePaidWindow();
        }

        private void GameConsoleControl_DragDrop(object sender,DragEventArgs e)
        {
            if(dropSource.Settings!=null)
                if(settings.Properties.Status==0&&dropSource.Settings.NumberID!=settings.NumberID)
                {
                    settings.Properties.Copy(dropSource.settings.Properties);
                    settings.ReportProperties.COSExR_InputReportId=dropSource.settings.ReportProperties.COSExR_Id;
                    settings.ClientData=dropSource.settings.ClientData;
                    ResumeStatus();
                    HandleDropSession();
                }
        }

        private void GameConsoleControl_DragEnter(object sender,DragEventArgs e)
        {
            dropSource=e.Data.GetData(GetType().ToString(),true) as GameConsole;
            if(dropSource!=null)
            {
                if(settings.Properties.Status==0&&dropSource.Settings.NumberID!=settings.NumberID)
                {
                    BackColor=Color.GreenYellow;
                    e.Effect=DragDropEffects.Copy;
                }
                else
                    e.Effect=DragDropEffects.None;
            }
        }

        private void GameConsoleControl_DragLeave(object sender,EventArgs e)
        {
            if(dropSource.Settings!=null)
                if(settings.Properties.Status==0&&dropSource.Settings.NumberID!=settings.NumberID)
                    BackColor=Color.White;
        }

        private void GameConsoleControl_DragOver(object sender,DragEventArgs e)
        {
            BackColor=Color.GreenYellow;
        }

        private void GameConsoleControl_MouseDown(object sender,MouseEventArgs e)
        {
            if(settings.Properties.Status!=0)
                DoDragDrop(this,DragDropEffects.Copy);
        }

        private void GameConsoleControl_MouseHover(object sender,EventArgs e)
        {
            InitializeBoders(true);
        }

        private void GameConsoleControl_MouseLeave(object sender,EventArgs e)
        {
            InitializeBoders();
        }

        private void _cash_Click(object sender,EventArgs e)
        {
            if(settings.Properties.Status!=4)
            {
                bool flag = false;
                SetCashGraphicSetup();
                if(!resuming)
                {
                    if(settings.Properties.Status==1||settings.Properties.Status==3||settings.Properties.Status==5)
                    {
                        _startStop.Click-=_stop_Click;
                        flag=true;
                    }
                    else if(settings.Properties.Status==2)
                        _startStop.Click-=_start_Click;
                    if(!settings.Properties.PrePaid)
                    {
                        if(TimeOffset()>=0.5&&!lapsConsumptionActive)
                        {
                            settings.Properties.TimeElapsed+=(int)Math.Round(TimeOffset()*perDivisor*60,0);
                            DisplayConsumption();
                        }
                        PerformStopCalculation();
                    }
                    else
                        PerformPrePaidStopCalculation();
                }
                settings.Properties.Status=4;
                UpdateCOACLog(flag);
                EndCOACLog(true);
                EndCOSELog();
                _cashReset.Click-=_cash_Click;
                _cashReset.Click+=_reset_Click;
            }
        }

        private void _controls_ValueChanged(object sender,EventArgs e)
        {
            if(!settings.Properties.PrePaid)
            {
                settings.Properties.ExtraControls=_extraControlsDisplay.Value;
                if(settings.Properties.TimeElapsed>=perDivisor)
                {
                    settings.Properties.LastTotalConsumption+=settings.Properties.TotalConsumption;
                    settings.Properties.LastTimeElapsed+=settings.Properties.TimeElapsed;
                    settings.Properties.TimeElapsed=0;
                }
            }
            else
            {
                if(settings.Properties.ExtraControls>_extraControlsDisplay.Value)
                    settings.Properties.TotalConsumption+=(extraControlPrice*(int)settings.Properties.ExtraControls);
                else
                    settings.Properties.TotalConsumption-=(extraControlPrice*(int)settings.Properties.ExtraControls);
                DisplayConsumption();
            }
        }


        private void _prePaidControl_Tick(object sender,EventArgs e)
        {
            PrePaidTimeCalulation();
            DisplayTime();
            if(settings.Properties.TimeElapsed<=0)
            {
                settings.Properties.TimeElapsed=0;
                _cash_Click(null,null);
                splayer.PlayLooping();
                notificationTimer.Start();
                IntPtr handle = Parent.Parent.Parent.Handle;
                NativeMethods.FlashWindow(handle,true);
            }
        }

        private void _notificationTimer_Tick(object sender,EventArgs e)
        {
            if(BackColor!=Color.White)
                BackColor=Color.White;
            else
                BackColor=ColorTranslator.FromHtml("#DFDF2A");
            if(Program.ApplicationIsActivated())
                splayer.Stop();
        }

        private void _reset_Click(object sender,EventArgs e)
        {
            settings.Properties.Status=0;
            notificationTimer.Stop();
            ResetGraphicSetup();
            ResetControls();

            _cashReset.Click-=_reset_Click;
        }

        private void _start_Click(object sender,EventArgs e)
        {
            if(settings.Properties.Status!=3&&settings.Properties.Status!=1&&settings.Properties.Status!=5)
            {
                SetStartGraphicSetup();

                if(!settings.ReportProperties.COSExR_Flag)//FLAG
                    InitializeCOSEReport();

                DetermineStartStatus();

                if(!resuming)
                {
                    if(settings.Properties.Status==1||settings.Properties.Status==5)
                        InitializeCOSEWithCLINSession();
                }
                UpdateCOACLog(false);

                if(!settings.Properties.PrePaid)
                    timeControl.Start();
                else
                    prePaidControl.Start();
                _startStop.Click-=_start_Click;
                _startStop.Click+=_stop_Click;
            }
        }

        private void _stop_Click(object sender,EventArgs e)
        {
            if(Settings.Properties.Status!=2)
            {
                SetStopGraphicSetup();
                settings.Properties.Status=2;
                if(!settings.Properties.PrePaid&&!resuming)
                    PerformStopCalculation();
                else
                    PerformPrePaidStopCalculation();
                UpdateCOACLog();
                _startStop.Click-=_stop_Click;
                _startStop.Click+=_start_Click;
            }
        }

        private void _timeControl_Tick(object sender,EventArgs e)
        {
            TimeCalculation();
            DisplayTime();
            DisplayConsumption();
        }

        //------------------------------------------------------------------------------------Reporting----------------------------------------------------------------------------------------------------

        private void InitializeCOSEWithCLINSession()
        {
            AddCLINLog();
            StartCOSESession();
        }

        private void AddCLINLog()
        {
            if(Program.Reporting)
                Program.ReportPipe.SendPackage("CLINxR","addclient",settings);
        }

        private void StartCOSESession()
        {
            if(Program.Reporting)
                Program.ReportPipe.SendPackage("COSExS","start",settings);
        }

        private void InitializeCOSEReport()
        {
            if(Program.Reporting)
                Program.ReportPipe.SendPackage("COSExR","start",settings);
        }

        private void StartCOACLog()
        {
            if(Program.Reporting)
                Program.ReportPipe.SendPackage("COSExL","start",settings);
        }

        private void EndCOSELog()
        {
            if(Program.Reporting)
            {
                Program.ReportPipe.SendPackage("COSExS","end",settings);
            }
        }

        private void EndCOACLog(bool calculateConsumption = true)
        {
            if(Program.Reporting)
            {
                if(calculateConsumption)
                    settings.Properties.TempConsumption=settings.Properties.LastTotalConsumption+settings.Properties.TotalConsumption;
                else
                    settings.Properties.TempConsumption=0;
                Program.ReportPipe.SendPackage("COSExL","end",settings);
            }
        }

        private void UpdateCOACLog(bool calculateConsumption = true)
        {
            if(Program.Reporting)
            {
                if(!resuming)
                {
                    EndCOACLog(calculateConsumption);
                    StartCOACLog();
                }
                else
                    resuming=false;
            }
        }

        private void DeleteLastCOSESession()
        {
            if(Program.Reporting)
                Program.ReportPipe.SendPackage("COSExS","deletelast",settings);
        }

        private void CopyCOSESession()
        {
            if(Program.Reporting)
                Program.ReportPipe.SendPackage("COSExS","copy",settings);
        }

        //----------------------------------------------------------------------------------Internal Classes-----------------------------------------------------------------------------------------------
        private static class BorderProperties
        {
            private static int blue = 45;
            private static int blueHover = 255;
            private static int green = 35;
            private static int greenHover = 60;
            private static int height = 1;
            private static int heightHover = 5;
            private static int red = 35;
            private static int redHover = 60;
            private static int width = 1;
            private static int widthHover = 5;
            public static int Blue { get { return blue; } set { blue=value; } }
            public static int BlueHover { get { return blueHover; } set { blueHover=value; } }
            public static int Green { get { return green; } set { green=value; } }
            public static int GreenHover { get { return greenHover; } set { greenHover=value; } }
            public static int Height { get { return height; } set { height=value; } }
            public static int HeightHover { get { return heightHover; } set { heightHover=value; } }
            public static int Red { get { return red; } set { red=value; } }
            public static int RedHover { get { return redHover; } set { redHover=value; } }
            public static int Width { get { return width; } set { width=value; } }
            public static int WidthHover { get { return widthHover; } set { widthHover=value; } }

            public static void HoverValue(string mode)
            {
                switch(mode)
                {
                    case "normal":
                        redHover=50;
                        greenHover=50;
                        blueHover=255;
                        break;

                    case "edit":
                        redHover=250;
                        greenHover=250;
                        blueHover=0;
                        break;

                    case "delete":
                        redHover=0;
                        greenHover=0;
                        blueHover=0;
                        break;

                    default:
                        break;
                }
            }

            public static void Reset()
            {
                red=35;
                green=35;
                blue=45;
                width=1;
                height=1;
            }
        }
    }
}