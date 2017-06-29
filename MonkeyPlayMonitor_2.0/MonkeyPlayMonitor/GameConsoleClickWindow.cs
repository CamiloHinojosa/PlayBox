using System;
using System.Windows.Forms;

namespace PlayBoxMonitor
{
    public partial class GameConsoleClickWindow:Form
    {
        private GameConsoleSetup settings;
        private double prePaidConsumption = 0;

        private double consumtionPrice = MainWindow.SettingsConfiguration.Price;
        private int perDivisor = MainWindow.SettingsConfiguration.PerDivisor, timeDivisor = MainWindow.SettingsConfiguration.TimeDivisor;
        private string currency = MainWindow.SettingsConfiguration.Currency;
        
        public GameConsoleClickWindow(GameConsoleSetup settings)
        {
            InitializeComponent();
            this.settings=settings;
            LoadValues();
        }

        private void LoadValues()
        {
            _timeInputTxtBox.Text=(settings.Properties.PrePaidTime/timeDivisor).ToString();
            _consumptionInputTxtBox.Text=(settings.Properties.TotalConsumption+settings.Properties.TempConsumption).ToString();
            _clientNameInputTXTBX.Text=settings.ClientData.Name;
            _clientPhoneNumberTXTBX.Text=settings.ClientData.PhoneNumber;
            _clientDocIdTXTBX.Text=settings.ClientData.DocId;
            _clientDateOfBirthPanel.Text=DateTime.Now.ToShortDateString();
            _currencyLBL.Text=currency;
            _timeModeLBL.Text=SettingsConvertionTools.ParseTimeDivisorToString(timeDivisor);
        }

        private int TimeCalaculator(double consumption)
        {
            return (int)((consumption*timeDivisor*perDivisor)/consumtionPrice);
        }

        private bool ValidateConsumption()
        {
            if((!double.TryParse(_consumptionInputTxtBox.Text,out prePaidConsumption)||prePaidConsumption<0||prePaidConsumption%consumtionPrice!=0)&&_consumptionInputTxtBox.Text!="")
                return false;
            else
            {
                settings.Properties.PrePaidTime=TimeCalaculator(prePaidConsumption);
                settings.Properties.PrePaid=true;
                return true;
            }
        }

        private bool ValidateTime(ref int tempTime)
        {
            if((!int.TryParse(_timeInputTxtBox.Text,out tempTime)||tempTime<0||tempTime%perDivisor!=0)&&_timeInputTxtBox.Text!="")
                return false;
            else
            {
                tempTime*=timeDivisor;
                settings.Properties.PrePaidTime=tempTime;
                settings.Properties.PrePaid=true;
                return true;
            }
        }

        private void _start_Click(object sender,EventArgs e)
        {
            int tempTime = 0;
            if(_consumptionCHKBX.Checked&&!ValidateConsumption())
                _userMessageAlertRTXTBX.Text="Consumption Input Not Valid: "+prePaidConsumption;
            else if(_timeCHKBX.Checked&&!ValidateTime(ref tempTime))
                _userMessageAlertRTXTBX.Text="Time Input Not Valid: "+tempTime.ToString();
            else
            {
                settings.ClientData.Name=_clientNameInputTXTBX.Text;//VALIDATE NAME
                settings.ClientData.DocId=_clientDocIdTXTBX.Text;//VALIDATE ID
                settings.ClientData.PhoneNumber=_clientPhoneNumberTXTBX.Text;//VALIDATE PHONE NUMBER
                settings.ClientData.DateOfBirth=_clientDateOfBirthPanel.Text;
                if(_normalCHKBX.Checked)
                    settings.Properties.PrePaid=false;
                DialogResult=DialogResult.OK;
            }
        }

        private void _cancel_Click(object sender,EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void _timeCHKBX_MouseClick(object sender,MouseEventArgs e)
        {
            if(_consumptionCHKBX.Checked)
                _consumptionCHKBX.Checked=false;
            if(_normalCHKBX.Checked)
                _normalCHKBX.Checked=false;
            _timeCHKBX.Checked=true;
            _timeCHKBX.CheckState=CheckState.Checked;
        }

        private void _normalCHKBX_MouseClick(object sender,MouseEventArgs e)
        {
            if(_timeCHKBX.Checked)
                _timeCHKBX.Checked=false;
            if(_consumptionCHKBX.Checked)
                _consumptionCHKBX.Checked=false;
            _normalCHKBX.Checked=true;
            _normalCHKBX.CheckState=CheckState.Checked;
        }

        private void _normalCHKBX_KeyPress(object sender,KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                CheckBox selection = sender as CheckBox;
                switch(selection.Tag.ToString())
                {
                    case "normal":
                        _normalCHKBX_MouseClick(null,null);
                        break;

                    case "time":
                        _timeCHKBX_MouseClick(null,null);
                        break;

                    case "consumption":
                        _consumptionCHKBX_MouseClick(null,null);
                        break;
                }
            }
        }

        private void _consumptionCHKBX_MouseClick(object sender,MouseEventArgs e)
        {
            if(_timeCHKBX.Checked)
                _timeCHKBX.Checked=false;
            if(_normalCHKBX.Checked)
                _normalCHKBX.Checked=false;
            _consumptionCHKBX.Checked=true;
            _consumptionCHKBX.CheckState=CheckState.Checked;
        }

        private void GCCPrePaidOptions_FormClosing(object sender,FormClosingEventArgs e)
        {
        }
    }
}