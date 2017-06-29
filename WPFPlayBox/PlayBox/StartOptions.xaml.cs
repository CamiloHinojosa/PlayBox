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
using System.Windows.Shapes;
using System.ComponentModel;

namespace PlayBox
{
    /// <summary>
    /// Interaction logic for StartOptions.xaml
    /// </summary>
    public partial class StartOptions:Window, INotifyPropertyChanged 
    {
        ConsoleSettings settings;

        private bool addMode = false;

        private double prePaidConsumption = 0;

        private double consumtionPrice = App.MainProperties.Settings.GameSettings.Price;

        private int perDivisor = App.MainProperties.Settings.GameSettings.PerDivisor, timeDivisor = App.MainProperties.Settings.GameSettings.TimeDivisor;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }

        public string InputValue
        {
            get
            {
                if(settings.Properties.PrePaid&&!addMode)
                    if(_prepaidType.SelectedIndex==0)
                        return (settings.Properties.PrePaidTime/timeDivisor).ToString();
                    else
                        return (settings.Properties.TotalConsumption).ToString("00.00");
                else
                    return "";
            }
        }

        public int Service
        {
            get
            {
                return (int)settings.Properties.ConsumptionType;
            }
            set
            {
                settings.Properties.ConsumptionType = (uint)value;
            }
        }

        public int StartType
        {
            get
            {
                if(settings.Properties.PrePaid)
                    return 1;
                else
                    return 0;
            }
            set
            {
                settings.Properties.PrePaid=value==0?false:true;
            }
        }

        public bool PrepaidEnabled
        {
            get
            {
                if(_startType.SelectedIndex == 0)
                {
                    settings.Properties.PrePaid = false;
                    return false;
                }
                else
                {
                    settings.Properties.PrePaid = true;
                    return true;
                }
            }
        }

        public bool AddModeEnabled
        {
            get
            {
                return !addMode;
            }
        }

        public string InputUnit
        {
            get
            {
                int unit;
                if(_service.SelectedIndex==0)
                    unit = App.MainProperties.Settings.GameSettings.TimeDivisor;
                else
                    unit = App.MainProperties.Settings.VideoSettings.TimeDivisor;
                if(_prepaidType.SelectedIndex==0)
                    switch(SettingsConvertionTools.ParseTimeDivisorTimeToIndex(unit))
                    {
                        case 0:
                            return "Seconds";
                        case 1:
                            return "Minutes";
                        case 2:
                            return "Hours";
                        default:
                            return "Seconds";
                    }
                else
                    return App.MainProperties.Settings.Currency;
            }
        }

        public StartOptions(ConsoleSettings settings, bool addMode=false)
        {
            this.settings = settings;
            this.addMode = addMode;
            InitializeComponent();
            DataContext = this;
            if(addMode)
                _applyBTN.Content = "Add";
        }
        
        private int TimeCalaculator(double consumption)
        {
            return (int)(consumption / consumtionPrice * perDivisor * timeDivisor);
        }

        private bool ValidateConsumption()
        {
            if(!double.TryParse(_input.Text,out prePaidConsumption) || prePaidConsumption < 0 || prePaidConsumption % consumtionPrice != 0)
            {
                _errorBox.Text = "Consumption Input Not Valid: " + prePaidConsumption;
                return false;
            }
            else
            {
                if(addMode)
                {
                    settings.Properties.TimeElapsed += TimeCalaculator(prePaidConsumption);
                    settings.Properties.PrePaidTime += TimeCalaculator(prePaidConsumption);
                }
                else
                {
                    settings.Properties.TimeElapsed = TimeCalaculator(prePaidConsumption);
                    settings.Properties.PrePaidTime = TimeCalaculator(prePaidConsumption);
                }
                return true;
            }
        }

        private bool ValidateTime()
        {
            int tempTime = 0;
            if(!int.TryParse(_input.Text,out tempTime) || tempTime < 0 || tempTime % perDivisor != 0)
            {
                _errorBox.Text = "Time Input Not Valid: " + tempTime.ToString();
                return false;
            }
            else
            {
                tempTime *= timeDivisor;
                if(addMode)
                {
                    settings.Properties.TimeElapsed += tempTime;
                    settings.Properties.PrePaidTime += tempTime;
                }
                else
                {
                    settings.Properties.TimeElapsed = tempTime;
                    settings.Properties.PrePaidTime = tempTime;
                }
                return true;
            }
        }

        private bool PrepaidValidation()
        {
                if(_prepaidType.SelectedIndex == 1 && !ValidateConsumption())
                    return false;
                else if(_prepaidType.SelectedIndex == 0 && !ValidateTime())
                    return false;
                return true;
        }

        private void _service_SelectionChanged(object sender,SelectionChangedEventArgs e)
        {
            if(_service.SelectedIndex == 0)
            {
                consumtionPrice = App.MainProperties.Settings.GameSettings.Price;
                perDivisor = App.MainProperties.Settings.GameSettings.PerDivisor;
                timeDivisor = App.MainProperties.Settings.GameSettings.TimeDivisor;
            }
            else
            {
                consumtionPrice = App.MainProperties.Settings.VideoSettings.Price;
                perDivisor = App.MainProperties.Settings.VideoSettings.PerDivisor;
                timeDivisor = App.MainProperties.Settings.VideoSettings.TimeDivisor;
            }
        }

        private void _startType_SelectionChanged(object sender,SelectionChangedEventArgs e)
        {
            OnPropertyChanged("StartType");
            OnPropertyChanged("PrepaidEnabled");
        }

        private void _prepaidType_SelectionChanged(object sender,SelectionChangedEventArgs e)
        {
                OnPropertyChanged("InputUnit");
                if(_input.Text != "")
                {
                    if(_prepaidType.SelectedIndex == 0)
                    {
                        _input.Text = (TimeCalaculator(Convert.ToDouble(_input.Text)) / timeDivisor).ToString();
                        ValidateTime();
                    }
                    else
                    {
                        _input.Text = (Convert.ToDouble(_input.Text) * consumtionPrice / perDivisor).ToString("00.00");
                        ValidateConsumption();
                    }
                    OnPropertyChanged("InputValue");
                }
        }

        private void _applyBTN_Click(object sender,RoutedEventArgs e)
        {
            if(!PrepaidEnabled||PrepaidValidation())
                DialogResult = true;
        }
    }
}
