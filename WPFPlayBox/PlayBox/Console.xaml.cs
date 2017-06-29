using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Windows.Threading;

namespace PlayBox
{
    /// <summary>
    /// Interaction logic for Console.xaml
    /// </summary>
    public partial class Console:Button, INotifyPropertyChanged
    {
        private ConsoleSettings settings;
        private DispatcherTimer _timeControl, _prePaidTimeControl, _notificationTimer;

        public ConsoleSettings Settings { get { return settings; } }

        private Settings programSettings = App.MainProperties.Settings.GameSettings;

        public Settings ProgramSettings { get { return programSettings; } }

        private bool resuming = false;

        private uint layoutStatus = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }

        public string Currency
        {
            get
            {
                return App.MainProperties.Settings.Currency;
            }
        }

        public int NumberID
        {
            get
            {
                return settings.NumberID + 1;
            }
        }

        public string ConsoleName
        {
            get
            {
                return settings.Name;
            }
            set
            {
                settings.Name = value;
            }
        }

        public uint LayoutStatus
        {
            get
            {
                return layoutStatus;
            }
            set
            {
                layoutStatus = value;
                OnPropertyChanged("ConsoleStyle");
            }
        }

        public string ConsumptionType
        {
            get
            {
                string t = settings.Properties.PrePaid ? "PREP" : "NORM";
                switch(settings.Properties.ConsumptionType)
                {
                    case 0:
                        programSettings = App.MainProperties.Settings.GameSettings;
                        return t + " GM";
                    case 1:
                        programSettings = App.MainProperties.Settings.VideoSettings;
                        return t + " MV";
                    default:
                        programSettings = App.MainProperties.Settings.GameSettings;
                        return t + " GM";
                }
            }
        }

        public Style ConsoleStyle
        {
            get
            {
                switch(LayoutStatus)
                {
                    case 0:
                        return (Style)FindResource("Console");
                    case 1:
                        return (Style)FindResource("EditConsole");
                    case 2:
                        return (Style)FindResource("DeleteConsole");
                    default:
                        return (Style)FindResource("Console");

                }
            }
        }

        public Console(ConsoleSettings settings)
        {
            InitializeComponent();
            this.settings = settings;
            InitializeTimers();
            DataContext = this;
            ResumeStatus();
        }

        public void ResumeStatus()
        {
            if(settings.Properties.Status != 0)
            {
                resuming = true;
                if(settings.Properties.Status == 1 || settings.Properties.Status == 3 || settings.Properties.Status == 5)
                {
                    ConsumptionCalculation();
                    _startBTN.IsChecked = true;
                    _startBTNAnimation.Begin();
                    settings.Properties.Status = 0;
                    _startBTN_Click(null,null);
                }
                else if(settings.Properties.Status == 2)
                {
                    _startBTN.IsChecked = false;
                    _stopBTNAnimation.Begin();
                    settings.Properties.Status = 0;
                    _stopBTN_Click(null,null);
                }
                else if(settings.Properties.Status == 4)
                {
                    _cashBTN.IsChecked = true;
                    _cashBTNAnimation.Begin();
                    settings.Properties.Status = 1;
                    _cashBTN_Click(null,null);
                }
            }
        }

        private void InitializeTimers()
        {
            _timeControl = new DispatcherTimer();
            _timeControl.Interval = new TimeSpan(0,0,1);
            _prePaidTimeControl = new DispatcherTimer();
            _prePaidTimeControl.Interval = new TimeSpan(0,0,1);
            _notificationTimer = new DispatcherTimer();
            _notificationTimer.Interval = new TimeSpan(0,0,1);
            _timeControl.Tick += _timeControl_Tick;
            _prePaidTimeControl.Tick += _prePaidTimeControl_Tick;
            _notificationTimer.Tick += _notificationTimer_Tick;
        }

        private void DisplayConsumption()
        {
            _consumptionLBL.Content = settings.Properties.DisplayConsumption;
        }

        private void DisplayTime()
        {
            _consumptionTimeLBL.Content = settings.Properties.DisplayTime;
        }

        private double ConsumptionCalculator(double timeElapsed)
        {
            return Math.Round(((timeElapsed / programSettings.TimeDivisor) / programSettings.PerDivisor) * programSettings.Price,2);
        }

        private double ConsumptionCalculatorByLaps(double timeElapsed)
        {
            double a = settings.Properties.TimeElapsed;
            double b = programSettings.PerDivisor;
            double c = programSettings.TimeDivisor;
            double d = programSettings.Price;
            if((a >= (b * c)))
                return Math.Round((((a - (a % (b * c))) / (b * c)) + 1) * d,2);
            return 0;
            //return Math.Round(((timeElapsed / programSettings.TimeDivisor / programSettings.PerDivisor) + 1) * programSettings.Price,2);
        }

        private void PerformPrePaidStopCalculation()
        {
            _prePaidTimeControl.Stop();
            ConsumptionCalculation();
            PrePaidTimeCalulation();
            DisplayConsumption();
            DisplayTime();
        }

        private void PerformStopCalculation()
        {
            if(!resuming)
            {
                _timeControl.Stop();
                TimeCalculation();
            }
            DisplayTime();
            DisplayConsumption();
        }

        private double MinimumConsumptionCalculation()
        {
            if((settings.Properties.TimeElapsed > (programSettings.PerDivisor * programSettings.TimeDivisor)))
                return settings.Properties.TotalConsumption = Math.Round(((settings.Properties.TimeElapsed - (settings.Properties.TimeElapsed % (programSettings.PerDivisor * programSettings.TimeDivisor))) / (programSettings.PerDivisor * programSettings.TimeDivisor)) * programSettings.Price,2);
            else
                return 0;
        }

        private void ConsumptionCalculation()
        {
            if(settings.Properties.PrePaid)
                settings.Properties.TotalConsumption = ConsumptionCalculator(settings.Properties.PrePaidTime);
            else if(programSettings.LapsConsumptionEnabled)
                settings.Properties.TotalConsumption = ConsumptionCalculatorByLaps(settings.Properties.TimeElapsed);
            else if(programSettings.MinimumConsumptionEnabled)
                settings.Properties.TotalConsumption = MinimumConsumptionCalculation();
            else
                settings.Properties.TotalConsumption = ConsumptionCalculator(settings.Properties.TimeElapsed);
            if((settings.Properties.TotalConsumption < programSettings.MinimumConsumption) && programSettings.MinimumConsumptionEnabled)
                settings.Properties.TotalConsumption = programSettings.MinimumConsumption;
        }

        private void PrePaidTimeCalulation()
        {
            settings.Properties.EndTime = DateTime.Now;
            settings.Properties.TimeElapsed -= (int)Math.Round(settings.Properties.EndTime.Subtract(settings.Properties.StartTime).TotalSeconds,0);
            settings.Properties.StartTime = settings.Properties.EndTime;
        }

        private void TimeCalculation()
        {
            settings.Properties.EndTime = DateTime.Now;
            settings.Properties.TimeElapsed += (int)Math.Round(settings.Properties.EndTime.Subtract(settings.Properties.StartTime).TotalSeconds,0);
            settings.Properties.StartTime = settings.Properties.EndTime;
            if((((settings.Properties.TimeElapsed) % (programSettings.MinimumTime * programSettings.TimeDivisor)) == 0) || !programSettings.MinimumConsumptionEnabled)
                ConsumptionCalculation();
        }

        //Calculates if time to calculate passed 50% of minimum time!!
        private double TimeOffset()
        {
            return ((settings.Properties.TimeElapsed / (programSettings.PerDivisor * programSettings.TimeDivisor))) - Math.Floor((double)(settings.Properties.TimeElapsed / (programSettings.PerDivisor * programSettings.TimeDivisor)));
        }

        private void ResetControls()
        {
            _startBTN.IsChecked = false;
            _cashBTN.IsChecked = false;
            resuming = false;
            settings.Properties.EndTime = new DateTime();
            settings.Properties.StartTime = new DateTime();
            _timeControl.Interval = new TimeSpan(0,0,1);
            settings.Properties = new ConsoleProperties();
            DisplayTime();
            DisplayConsumption();
        }

        private void _startBTN_Click(object sender,RoutedEventArgs e)
        {
            if(settings.Properties.Status != 4)
            {
                _startBTN.Content = "STOP";
                if(!resuming)
                {
                    settings.Properties.StartTime = DateTime.Now;
                    settings.Properties.EndTime = DateTime.Now;
                }
                if(settings.Properties.PrePaid)
                {
                    ConsumptionCalculation();
                    PrePaidTimeCalulation();
                    settings.Properties.Status = (uint)(settings.Properties.Status != 2 ? 5 : 3);
                    _prePaidTimeControl.Start();
                }
                else
                {
                    TimeCalculation();
                    settings.Properties.Status = (uint)(settings.Properties.Status != 2 ? 1 : 3);
                    _timeControl.Start();
                }
            }
            resuming = false;
        }

        private void _stopBTN_Click(object sender,RoutedEventArgs e)
        {
            if(settings.Properties.Status != 4)
            {
                _startBTN.Content = "RESUME";
                if(!settings.Properties.PrePaid)
                    PerformStopCalculation();
                else
                    PerformPrePaidStopCalculation();
                settings.Properties.Status = 2;
                resuming = false;
            }
        }

        private void _cashBTN_Click(object sender,RoutedEventArgs e)
        {
            if(settings.Properties.Status != 0)
            {
                _cashBTN.Content = "RESET";
                _startBTN.IsChecked = false;
                if(!resuming)
                {
                    if(!settings.Properties.PrePaid)
                    {
                        if(TimeOffset() >= 0.5 && !programSettings.LapsConsumptionEnabled)
                        {
                            settings.Properties.TimeElapsed += (int)Math.Round(TimeOffset() * programSettings.PerDivisor * 60,0);
                            DisplayConsumption();
                        }
                        PerformStopCalculation();
                    }
                    else
                    {
                        settings.Properties.TimeElapsed = settings.Properties.PrePaidTime;
                        PerformPrePaidStopCalculation();
                    }
                }
                settings.Properties.Status = 4;
                resuming = false;
            }
        }

        private void _resetBTN_Click(object sender,RoutedEventArgs e)
        {
            _cashBTN.Content = "CASH";
            _startBTN.Content = "START";
            _notificationTimer.Stop();
            ResetControls();
            settings.Properties.Status = 0;
        }

        private void _clientInfoBTN_Click(object sender,RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _consumptionTypeBTN_Click(object sender,RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _consumptionType_MouseDoubleClick(object sender,MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _console_Click(object sender,RoutedEventArgs e)
        {
            StartOptions so;
            if(
                (e.Source.ToString() != _cashBTN.ToString()) &&
                (e.Source.ToString() != _startBTN.ToString()) &&
                (e.Source.ToString() != _imageBTN.ToString()) &&
                (e.Source.ToString() != _clientInfoBTN.ToString()))
                switch(layoutStatus)
                {
                    case 0:
                        if(settings.Properties.Status == 0 || settings.Properties.PrePaid)
                        {
                            so = new StartOptions(settings,settings.Properties.Status == 0 ? false : true && settings.Properties.PrePaid);
                            if(so.ShowDialog() == true)
                            {
                                OnPropertyChanged("ConsumptionType");
                                if(settings.Properties.PrePaid)
                                {
                                    ConsumptionCalculation();
                                    DisplayTime();
                                    DisplayConsumption();
                                }
                                else
                                    ResetControls();
                            }
                        }
                        break;
                    case 1:
                        _name.IsReadOnly = false;
                        _name.Foreground = Brushes.Black;
                        _name.SelectAll();
                        _name.Focus();
                        break;
                    case 2:
                        MainWindow.DeleteConsole(this);
                        break;
                    case 3:
                        break;
                }
        }

        private void _notificationTimer_Tick(object sender,EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _prePaidTimeControl_Tick(object sender,EventArgs e)
        {
            PrePaidTimeCalulation();
            DisplayTime();
            if(settings.Properties.TimeElapsed <= 0)
            {
                settings.Properties.TimeElapsed = 0;
                _cashBTN_Click(null,null);
            }
        }

        private void _timeControl_Tick(object sender,EventArgs e)
        {
            TimeCalculation();
            DisplayTime();
            DisplayConsumption();
        }
    }
}
