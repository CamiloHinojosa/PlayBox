using System;
using System.Windows.Forms;

namespace PlayBoxMonitor
{
    public partial class ConfirmationWindow:Form
    {
        private string type = null;

        public ConfirmationWindow(string type)
        {
            InitializeComponent();
            this.type=type;
        }

        private void ConfirmationWindow_Load(object sender,EventArgs e)
        {
            switch(type)
            {
                case "#delete":
                    _textToDisplayTxtBox.Text="Are you sure you want to DELETE this console?";
                    _submit.ForeColor=System.Drawing.Color.Crimson;
                    _submit.Text="DELETE";
                    break;

                case "#deleteAll":
                    _textToDisplayTxtBox.Text="Are you sure you want to DELETE ALL consoles?";
                    _submit.ForeColor=System.Drawing.Color.Crimson;
                    _submit.Text="DELETE";
                    break;

                default:
                    MessageLogManager.LogMessage("PBM  - CW ::::> Error invalid argument.");
                    break;
            }
        }

        private void _submit_Click(object sender,EventArgs e)
        {
            this.DialogResult=DialogResult.OK;
        }

        private void _cancel_Click(object sender,EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }
    }
}