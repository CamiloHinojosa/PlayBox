using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayBoxMonitor
{
    public partial class GameConsolePPClickWindow:Form
    {
        private GameConsoleSetup settings;
        private double prePaidConsumption = 0;

        private double consumtionPrice = MainWindow.SettingsConfiguration.Price;
        private int perDivisor = MainWindow.SettingsConfiguration.PerDivisor, timeDivisor = MainWindow.SettingsConfiguration.TimeDivisor;
        private string currency = MainWindow.SettingsConfiguration.Currency;

        private bool timeValid = true, consumptionValid = true;

        public GameConsolePPClickWindow(GameConsoleSetup settings)
        {
            this.settings=settings;
            InitializeComponent();
        }

        private int TimeCalaculator(double consumption)
        {
            return (int)((consumption*timeDivisor*perDivisor)/consumtionPrice);
        }

        private void ValidateConsumption()
        {
            if(!double.TryParse(_consumptionInputTxtBox.Text,out prePaidConsumption)||prePaidConsumption<0||prePaidConsumption%consumtionPrice!=0)
                consumptionValid=false;
            else
            {
                settings.Properties.PrePaidTime=TimeCalaculator(prePaidConsumption);
                settings.Properties.PrePaid=true;
                consumptionValid=true;
            }
        }

        private void ValidateTime(ref int tempTime)
        {
            if(!int.TryParse(_timeInputTxtBox.Text,out tempTime)||tempTime<0||tempTime%perDivisor!=0)
                timeValid=false;
            else
            {
                tempTime*=timeDivisor;
                settings.Properties.PrePaidTime=tempTime;
                settings.Properties.PrePaid=true;
                timeValid=true;
            }
        }

        private void _add_Click(object sender,EventArgs e)
        {
            int tempTime = 0;
            if(_consumptionInputTxtBox.Text!=""&&_consumptionCHKBX.Checked)
            {
                ValidateConsumption();
            }
            else if(_timeInputTxtBox.Text!=""&&_timeCHKBX.Checked)
            {
                ValidateTime(ref tempTime);
            }
            if(!consumptionValid)
                _userMessageAlertRTXTBX.Text="Consumption Input Not Valid: "+prePaidConsumption;
            else if(!timeValid)
                _userMessageAlertRTXTBX.Text="Time Input Not Valid: "+tempTime.ToString();
            else
                DialogResult=DialogResult.OK;
        }


        private void _cancel_Click(object sender,EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void _timeCHKBX_MouseClick(object sender,MouseEventArgs e)
        {
            if(_consumptionCHKBX.Checked)
                _consumptionCHKBX.Checked=false;
            _timeCHKBX.Checked=true;
            _timeCHKBX.CheckState=CheckState.Checked;
        }


        private void _consumptionCHKBX_MouseClick(object sender,MouseEventArgs e)
        {
            if(_timeCHKBX.Checked)
                _timeCHKBX.Checked=false;
            _consumptionCHKBX.Checked=true;
            _consumptionCHKBX.CheckState=CheckState.Checked;
        }
        
        private void _CHKBX_KeyPress(object sender,KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                CheckBox selection = sender as CheckBox;
                switch(selection.Tag.ToString())
                {
                    case "time":
                        _timeCHKBX_MouseClick(null,null);
                        break;

                    case "consumption":
                        _consumptionCHKBX_MouseClick(null,null);
                        break;
                    default:
                        _cancel_Click(null,null);
                        break;
                }
            }
        }
    }
}
