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
using System.Threading;
using System.Windows.Threading;

namespace PlayBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow:Window
    {
        private int lastMenuBarSize=171;
        private int LastMenuBarSize { get { return lastMenuBarSize; } set { lastMenuBarSize = value; } }
        private AppSettingsEditPage settingsPage;
        private DispatcherTimer _autoSaveTimer;

        public MainWindow()
        {
            InitializeComponent();
            RestoreConsoles();
            InitializeDependencyControls();
        }

        private void InitializeDependencyControls()
        {
            _autoSaveTimer = new DispatcherTimer();
            _autoSaveTimer.Interval = new TimeSpan(0,0,1);
            _autoSaveTimer.Tick += _autoSaveTimer_Tick;
            _autoSaveTimer.Start();
        }

        private void _autoSaveTimer_Tick(object sender,EventArgs e)
        {
            App.Manager.SaveSetup(App.MainProperties.Setup);
        }

        private void RestoreConsoles()
        {
            foreach(ConsoleSettings css in App.MainProperties.Setup.ConsolesSetup)
            {
                Console cs = new Console(css);
                _consolesContainer.Children.Add(cs);
            }
        }

        private void _addConsoleBTN_Click(object sender,RoutedEventArgs e)
        {
            Console cs = new Console(new ConsoleSettings());
            cs.Settings.NumberID = App.MainProperties.Setup.AvailableID;
            App.MainProperties.Setup.ConsolesSetup.Add(cs.Settings);
            App.Manager.SaveSetup(App.MainProperties.Setup);
            _consolesContainer.Children.Add(cs);

        }

        private void _editConsoleBTN_Checked(object sender,RoutedEventArgs e)
        {
            foreach(Console cs in _consolesContainer.Children)
                cs.LayoutStatus = 1;
        }

        private void _deleteConsoleBTN_Checked(object sender,RoutedEventArgs e)
        {
            foreach(Console cs in _consolesContainer.Children)
                cs.LayoutStatus = 2;
        }

        private void _deleteEditConsoleBTN_Unchecked(object sender,RoutedEventArgs e)
        {
            foreach(Console cs in _consolesContainer.Children)
            {
                cs._name.IsReadOnly = true;
                cs._name.Foreground = Brushes.White;
                cs.LayoutStatus = 0;
            }
            App.Manager.SaveSetup(App.MainProperties.Setup);
        }

        public static void DeleteConsole(Console selected)
        {
            App.MainProperties.Setup.ConsolesSetup.Remove(selected.Settings);
            WrapPanel parent = selected.Parent as WrapPanel;
            parent.Children.Remove(selected);
            App.MainProperties.Setup.UsedIDs.Remove(selected.Settings.NumberID);
            App.Manager.SaveSetup(App.MainProperties.Setup);

        }

        private void _optionsMenuBTN_Checked(object sender,RoutedEventArgs e)
        {
            _contentDisplayButtonsGrid.IsEnabled = true;
            settingsPage = new AppSettingsEditPage(App.MainProperties.Settings.Copy());
            _menuContentDisplay.Navigate(settingsPage);
        }

        private void _applyMenuDisplayBTN_Click(object sender,RoutedEventArgs e)
        {
            App.MainProperties.Settings = settingsPage.Settings;
            App.Manager.SaveSettings(App.MainProperties.Settings);
            _consolesContainer.Children.Clear();
            RestoreConsoles();
        }

        private void _cancelMenuDisplayBTN_Click(object sender,RoutedEventArgs e)
        {
            _optionsMenuBTN.IsChecked = false;
            _contentDisplayButtonsGrid.IsEnabled = false;
        }

        private void _addConsoleBTN_Click_1(object sender,RoutedEventArgs e)
        {

        }
    }
}
