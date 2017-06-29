using System;
using System.Windows.Forms;

namespace PlayBoxMonitor
{
    public partial class CreateConsoleWindow:Form
    {
        private CreateConsoleParameters parameters;
        private bool edit = false;

        public decimal NumberOfConsolesToCreate
        {
            get { return parameters.Count; }
        }

        public CreateConsoleWindow(CreateConsoleParameters parameters,bool edit = false)
        {
            this.parameters=parameters;
            this.edit=edit;
            InitializeComponent();
            if(edit)
            {
                Text="Edit Game Console";
                _create.Text="Modify";
                _numberOfConsolesUpDown.Visible=false;
                _numberOfConsolesLabel.Visible=false;
            }
            _numberOfConsolesUpDown.Maximum=parameters.Count;
            _consoleNameTxtBox.Text=parameters.Setup.Name;
            _htmlColorTxTBox.Text=parameters.Setup.ColorID;
        }

        private void _colorRGBTxtBox_TextChanged(object sender,EventArgs e)
        {
            try
            {
                int value = 0;
                RichTextBox selection = sender as RichTextBox;
                switch(selection.Tag.ToString())
                {
                    case "red":
                        if(int.TryParse(_redRGBTxtBox.Text,out value)&&value>=0&&value<=255)
                        {
                            _redRGB.Value=value;
                            _errorLabel.Text="";
                        }
                        else
                        {
                            _errorLabel.Text="RGB value is not valid.\nPlease input a valid RGB value between (0) and (255).\nLast input value: "+_redRGBTxtBox.Text;
                            _redRGBTxtBox.Text=_redRGB.Value.ToString();
                            _redRGBTxtBox.Focus();
                        }
                        break;

                    case "green":
                        if(int.TryParse(_greenRGBTxtBox.Text,out value)&&value>=0&&value<=255)
                        {
                            _greenRGB.Value=value;
                            _errorLabel.Text="";
                        }
                        else
                        {
                            _errorLabel.Text="RGB value is not valid.\nPlease input a valid RGB value between 0 and 255.\nLast input value: "+_greenRGBTxtBox.Text;
                            _greenRGBTxtBox.Text=_greenRGB.Value.ToString();
                            _greenRGBTxtBox.Focus();
                        }
                        break;

                    case "blue":
                        if(int.TryParse(_blueRGBTxtBox.Text,out value)&&value>=0&&value<=255)
                        {
                            _blueRGB.Value=value;
                            _errorLabel.Text="";
                        }
                        else
                        {
                            _errorLabel.Text="RGB value is not valid.\nPlease input a valid RGB value between 0 and 255.\nLast input value: "+_blueRGBTxtBox.Text;
                            _blueRGBTxtBox.Text=_blueRGB.Value.ToString();
                            _blueRGBTxtBox.Focus();
                        }
                        break;
                }
            } catch(Exception ex)
            {
                _errorLabel.Text=ex.Message;
            }
        }

        private void _colorRGB_ValueChanged(object sender,EventArgs e)
        {
            TrackBar selection = sender as TrackBar;
            switch(selection.Tag.ToString())
            {
                case "red":
                    _redRGBTxtBox.Text=selection.Value.ToString();
                    break;

                case "green":
                    _greenRGBTxtBox.Text=selection.Value.ToString();
                    break;

                case "blue":
                    _blueRGBTxtBox.Text=selection.Value.ToString();
                    break;
            }
        }

        private void _create_Click(object sender,EventArgs e)
        {
            DialogResult=DialogResult.OK;
        }

        private void _cancel_Click(object sender,EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void CreateConsoleWindow_FormClosing(object sender,FormClosingEventArgs e)
        {
            if(DialogResult==DialogResult.OK||DialogResult==DialogResult.Cancel)
                e.Cancel=false;
            else
                e.Cancel=true;
            if(DialogResult==DialogResult.OK)
            {
                if(!edit)
                    parameters.Count=(int)_numberOfConsolesUpDown.Value;
                parameters.Setup.Name=_consoleNameTxtBox.Text;
                if(_htmlColorCHKBox.Checked)
                    parameters.Setup.ColorID=_htmlColorTxTBox.Text;
                else if(_rgbColorCHKBox.Checked)
                    parameters.Setup.ColorID="#"+_redRGB.Value.ToString("X2")+_greenRGB.Value.ToString("X2")+_blueRGB.Value.ToString("X2");
            }
        }

        private void _rgbColorCHKBox_CheckedChanged(object sender,EventArgs e)
        {
            if(_htmlColorCHKBox.Checked)
                _htmlColorCHKBox.Checked=false;
            _rgbColorCHKBox.Checked=true;
            _rgbColorCHKBox.CheckState=CheckState.Checked;
        }

        private void _htmlColorCHKBox_CheckedChanged(object sender,EventArgs e)
        {
            if(_rgbColorCHKBox.Checked)
                _rgbColorCHKBox.Checked=false;
            _htmlColorCHKBox.Checked=true;
            _htmlColorCHKBox.CheckState=CheckState.Checked;
        }

        private void CreateConsoleWindow_Load(object sender,EventArgs e)
        {
            _consoleNameTxtBox.Text="Game Console";
            _htmlColorTxTBox.Text="#606065";
            _redRGB.Value=96;
            _greenRGB.Value=96;
            _blueRGB.Value=101;
            _numberOfConsolesUpDown.Value=1;
        }

        private void _rgbColorCHKBox_KeyPress(object sender,KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
                _rgbColorCHKBox_CheckedChanged(null,null);
        }

        private void _htmlColorCHKBox_KeyPress(object sender,KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
                _htmlColorCHKBox_CheckedChanged(null,null);
        }

        private bool VerifyHex(string _hex)
        {
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"/^#[a-fA-F0-9]{6}$/");
            return r.Match(_hex).Success;
        }

        private void _htmlColorTxTBox_Leave(object sender,EventArgs e)
        {
            RichTextBox selection = sender as RichTextBox;
            bool flag = false;
            try
            {
                if(!System.Drawing.ColorTranslator.FromHtml(selection.Text).IsEmpty&&selection.Text.Length==7&&selection.Text.StartsWith("#"))
                    flag=true;
            } catch(Exception ex)
            {
                _errorLabel.Text=ex.Message+":\n";
            }
            if(!flag)
            {
                _errorLabel.Text="\nHTML Color Code not valid.\nPlease input a new code.\nLast input Code: "+selection.Text;
                _htmlColorTxTBox.Text=parameters.Setup.ColorID;
                _htmlColorTxTBox.Focus();
            }
            else
                _errorLabel.Text="";
        }
    }
}