using System.Windows.Forms;

namespace PlayBoxMonitor
{
    public partial class IntroLoadingWindow:Form
    {
        public IntroLoadingWindow()
        {
            InitializeComponent();
            introCloseTimer.Interval=9000;
        }

        public void InitializeIntroDisplay()
        {
            ShowDialog();
        }

        public void Continue()
        {
            introCloseTimer.Stop();
            introCloseTimer.Start();
        }

        private void introCloseTimer_Tick(object sender,System.EventArgs e)
        {
            introCloseTimer.Stop();
            Close();
        }

        private void IntroLoadingWindow_Load(object sender,System.EventArgs e)
        {
            introCloseTimer.Start();
        }
    }
}