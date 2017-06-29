using System;
using System.Windows.Forms;

namespace PlayBoxMonitor
{
    public partial class EditSettingsWindows:Form
    {
        public Settings editedSettings, previousSettings;

        private bool lapsConsumption = false;

        public EditSettingsWindows(Settings settings)
        {
            previousSettings=settings;
            editedSettings=previousSettings.Copy();
            InitializeComponent();
        }

        private void EditSettings_Load(object sender,EventArgs e)
        {
            _currencyUpDown.SelectedIndex=SettingsConvertionTools.ParseCurrency(editedSettings.Currency);
            _extraCPriceTxtBox.Text=editedSettings.ExtraControlPrice.ToString();
            _priceTxtBox.Text=editedSettings.Price.ToString();
            _timeIntervalTxtBox.Text=(editedSettings.TimeInterval/1000).ToString();
            _perDivisorNUpDown.Value=decimal.Parse(editedSettings.PerDivisor.ToString());
            _timeDivisorUpDown.SelectedIndex=SettingsConvertionTools.ParseTimeDivisor(editedSettings.TimeDivisor);
            _minConsumptionTxtBox.Text=editedSettings.MinimumConsumption.ToString("00.00");
            _minTimeTxtBox.Text=(editedSettings.MinimumTime/editedSettings.TimeDivisor).ToString();
            _minimumConsumptionCurrencyLBL.Text=editedSettings.Currency;
            _minTimeTimeLBL.Text=_timeDivisorUpDown.SelectedItem.ToString();
            _lapsConsumptionCHKBX.Checked=editedSettings.LapsConsumption;
        }

        private void RenderValues()
        {
            editedSettings.Currency=_currencyUpDown.SelectedItem.ToString();
            editedSettings.ExtraControlPrice=double.Parse(_extraCPriceTxtBox.Text);
            editedSettings.Price=double.Parse(_priceTxtBox.Text);
            editedSettings.TimeInterval=int.Parse(_timeIntervalTxtBox.Text)*1000;
            editedSettings.PerDivisor=int.Parse(_perDivisorNUpDown.Value.ToString());
            editedSettings.TimeDivisor=SettingsConvertionTools.DeParseTimeDivisor(_timeDivisorUpDown.SelectedIndex);
            editedSettings.MinimumConsumption=double.Parse(_minConsumptionTxtBox.Text);
            editedSettings.MinimumTime=(int.Parse(_minTimeTxtBox.Text)*editedSettings.TimeDivisor);
            if(lapsConsumption)
                editedSettings.LapsConsumption=true;
            else
                editedSettings.LapsConsumption=false;
        }

        private void EditSettings_FormClosing(object sender,FormClosingEventArgs e)
        {
            if(DialogResult==DialogResult.OK)
                RenderValues();
        }

        private void _save_Click(object sender,EventArgs e)
        {
            DialogResult=DialogResult.OK;
        }

        private void _cancel_Click(object sender,EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void _timeDivisorUpDown_TextChanged(object sender,EventArgs e)
        {
            _minTimeTimeLBL.Text=_timeDivisorUpDown.SelectedItem.ToString();
        }

        private void _currencyUpDown_TextChanged(object sender,EventArgs e)
        {
            _minimumConsumptionCurrencyLBL.Text=_currencyUpDown.Text;
        }

        private void _lapsConsumptionCHKBX_MouseClick(object sender,MouseEventArgs e)
        {
            if(_lapsConsumptionCHKBX.Checked)
                lapsConsumption=true;
            else
                lapsConsumption=false;
        }

        private void _lapsConsumptionCHKBX_KeyPress(object sender,KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
                _lapsConsumptionCHKBX_MouseClick(null,null);
        }

        private void _resetBtn_Click(object sender,EventArgs e)
        {
            editedSettings=new Settings();
            EditSettings_Load(null,null);
        }
    }
}