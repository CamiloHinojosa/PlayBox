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

namespace PlayBox
{
    /// <summary>
    /// Interaction logic for AppSettingsEditPage.xaml
    /// </summary>
    public partial class AppSettingsEditPage:Page
    {
        private ProgramSettings settings;

        public ProgramSettings Settings { get { return settings; } }

        public int GameTimeDivisor
        {
            get
            {
                return SettingsConvertionTools.ParseTimeDivisorTimeToIndex(settings.GameSettings.TimeDivisor);
            }
            set
            {
                settings.GameSettings.TimeDivisor = SettingsConvertionTools.DeParseTimeDivisorIndexToTime(value);
            }
        }

        public int VideoTimeDivisor
        {
            get
            {
                return SettingsConvertionTools.ParseTimeDivisorTimeToIndex(settings.VideoSettings.TimeDivisor);
            }
            set
            {
                settings.VideoSettings.TimeDivisor = SettingsConvertionTools.DeParseTimeDivisorIndexToTime(value);
            }
        }

        public int Currency
        {
            get
            {
                return SettingsConvertionTools.ParseCurrency(settings.Currency);
            }
            set
            {
                settings.Currency = SettingsConvertionTools.DeParseCurrency(value);
            }
        }

        public AppSettingsEditPage(ProgramSettings settings)
        {
            InitializeComponent();
            this.settings = settings;
            DataContext = this;
        }
    }
}
