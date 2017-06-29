namespace PlayBoxMonitor
{
    partial class EditSettingsWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components=null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing&&(components!=null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSettingsWindows));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._timeDivisorUpDown = new System.Windows.Forms.DomainUpDown();
            this._save = new System.Windows.Forms.Button();
            this._cancel = new System.Windows.Forms.Button();
            this._priceTxtBox = new System.Windows.Forms.TextBox();
            this._extraCPriceTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._timeIntervalTxtBox = new System.Windows.Forms.TextBox();
            this._perDivisorNUpDown = new System.Windows.Forms.NumericUpDown();
            this._AutoRefreshIndicatorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._currencyUpDown = new System.Windows.Forms.DomainUpDown();
            this._controlsContainerGPBX = new System.Windows.Forms.GroupBox();
            this._lapsConsumptionCHKBX = new System.Windows.Forms.CheckBox();
            this._minTimeTimeLBL = new System.Windows.Forms.Label();
            this._minimumConsumptionCurrencyLBL = new System.Windows.Forms.Label();
            this._minConsumptionTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._minTimeTxtBox = new System.Windows.Forms.TextBox();
            this._resetBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._perDivisorNUpDown)).BeginInit();
            this._controlsContainerGPBX.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Extra Control Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Auto Refresh Time:";
            // 
            // _timeDivisorUpDown
            // 
            this._timeDivisorUpDown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._timeDivisorUpDown.Items.Add("Month(s)");
            this._timeDivisorUpDown.Items.Add("Day(s)");
            this._timeDivisorUpDown.Items.Add("Hour(s)");
            this._timeDivisorUpDown.Items.Add("Minute(s)");
            this._timeDivisorUpDown.Items.Add("Second(s)");
            this._timeDivisorUpDown.Location = new System.Drawing.Point(565, 26);
            this._timeDivisorUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._timeDivisorUpDown.Name = "_timeDivisorUpDown";
            this._timeDivisorUpDown.ReadOnly = true;
            this._timeDivisorUpDown.Size = new System.Drawing.Size(123, 32);
            this._timeDivisorUpDown.TabIndex = 2;
            this._timeDivisorUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._timeDivisorUpDown.TextChanged += new System.EventHandler(this._timeDivisorUpDown_TextChanged);
            // 
            // _save
            // 
            this._save.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._save.ForeColor = System.Drawing.Color.DodgerBlue;
            this._save.Location = new System.Drawing.Point(485, 477);
            this._save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(121, 36);
            this._save.TabIndex = 9;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = true;
            this._save.Click += new System.EventHandler(this._save_Click);
            // 
            // _cancel
            // 
            this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this._cancel.Location = new System.Drawing.Point(619, 477);
            this._cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(123, 36);
            this._cancel.TabIndex = 10;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = true;
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // _priceTxtBox
            // 
            this._priceTxtBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._priceTxtBox.Location = new System.Drawing.Point(347, 26);
            this._priceTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._priceTxtBox.Name = "_priceTxtBox";
            this._priceTxtBox.Size = new System.Drawing.Size(79, 27);
            this._priceTxtBox.TabIndex = 0;
            // 
            // _extraCPriceTxtBox
            // 
            this._extraCPriceTxtBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._extraCPriceTxtBox.Location = new System.Drawing.Point(347, 78);
            this._extraCPriceTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._extraCPriceTxtBox.Name = "_extraCPriceTxtBox";
            this._extraCPriceTxtBox.Size = new System.Drawing.Size(115, 27);
            this._extraCPriceTxtBox.TabIndex = 3;
            this._extraCPriceTxtBox.Text = "0";
            this._extraCPriceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 35);
            this.label5.TabIndex = 14;
            this.label5.Text = "/";
            // 
            // _timeIntervalTxtBox
            // 
            this._timeIntervalTxtBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._timeIntervalTxtBox.Location = new System.Drawing.Point(347, 276);
            this._timeIntervalTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._timeIntervalTxtBox.Name = "_timeIntervalTxtBox";
            this._timeIntervalTxtBox.Size = new System.Drawing.Size(121, 27);
            this._timeIntervalTxtBox.TabIndex = 7;
            this._timeIntervalTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _perDivisorNUpDown
            // 
            this._perDivisorNUpDown.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._perDivisorNUpDown.Location = new System.Drawing.Point(462, 26);
            this._perDivisorNUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._perDivisorNUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this._perDivisorNUpDown.Name = "_perDivisorNUpDown";
            this._perDivisorNUpDown.Size = new System.Drawing.Size(73, 27);
            this._perDivisorNUpDown.TabIndex = 1;
            this._perDivisorNUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _AutoRefreshIndicatorLabel
            // 
            this._AutoRefreshIndicatorLabel.AutoSize = true;
            this._AutoRefreshIndicatorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._AutoRefreshIndicatorLabel.Location = new System.Drawing.Point(560, 276);
            this._AutoRefreshIndicatorLabel.Name = "_AutoRefreshIndicatorLabel";
            this._AutoRefreshIndicatorLabel.Size = new System.Drawing.Size(90, 24);
            this._AutoRefreshIndicatorLabel.TabIndex = 17;
            this._AutoRefreshIndicatorLabel.Text = "Second(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currency:";
            // 
            // _currencyUpDown
            // 
            this._currencyUpDown.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._currencyUpDown.Items.Add("£");
            this._currencyUpDown.Items.Add("¥");
            this._currencyUpDown.Items.Add("€");
            this._currencyUpDown.Items.Add("Bs.");
            this._currencyUpDown.Items.Add("$");
            this._currencyUpDown.Items.Add("¢");
            this._currencyUpDown.Items.Add("c");
            this._currencyUpDown.Location = new System.Drawing.Point(347, 130);
            this._currencyUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._currencyUpDown.Name = "_currencyUpDown";
            this._currencyUpDown.ReadOnly = true;
            this._currencyUpDown.Size = new System.Drawing.Size(133, 27);
            this._currencyUpDown.TabIndex = 4;
            this._currencyUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._currencyUpDown.TextChanged += new System.EventHandler(this._currencyUpDown_TextChanged);
            // 
            // _controlsContainerGPBX
            // 
            this._controlsContainerGPBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this._controlsContainerGPBX.Controls.Add(this._lapsConsumptionCHKBX);
            this._controlsContainerGPBX.Controls.Add(this._minTimeTimeLBL);
            this._controlsContainerGPBX.Controls.Add(this._minimumConsumptionCurrencyLBL);
            this._controlsContainerGPBX.Controls.Add(this._minConsumptionTxtBox);
            this._controlsContainerGPBX.Controls.Add(this.label7);
            this._controlsContainerGPBX.Controls.Add(this.label8);
            this._controlsContainerGPBX.Controls.Add(this.label4);
            this._controlsContainerGPBX.Controls.Add(this._timeIntervalTxtBox);
            this._controlsContainerGPBX.Controls.Add(this._minTimeTxtBox);
            this._controlsContainerGPBX.Controls.Add(this._AutoRefreshIndicatorLabel);
            this._controlsContainerGPBX.Controls.Add(this.label1);
            this._controlsContainerGPBX.Controls.Add(this._perDivisorNUpDown);
            this._controlsContainerGPBX.Controls.Add(this.label3);
            this._controlsContainerGPBX.Controls.Add(this.label2);
            this._controlsContainerGPBX.Controls.Add(this.label5);
            this._controlsContainerGPBX.Controls.Add(this._timeDivisorUpDown);
            this._controlsContainerGPBX.Controls.Add(this._extraCPriceTxtBox);
            this._controlsContainerGPBX.Controls.Add(this._currencyUpDown);
            this._controlsContainerGPBX.Controls.Add(this._priceTxtBox);
            this._controlsContainerGPBX.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._controlsContainerGPBX.ForeColor = System.Drawing.Color.White;
            this._controlsContainerGPBX.Location = new System.Drawing.Point(1, 2);
            this._controlsContainerGPBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._controlsContainerGPBX.Name = "_controlsContainerGPBX";
            this._controlsContainerGPBX.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._controlsContainerGPBX.Size = new System.Drawing.Size(752, 375);
            this._controlsContainerGPBX.TabIndex = 18;
            this._controlsContainerGPBX.TabStop = false;
            this._controlsContainerGPBX.Text = "Global Settings";
            // 
            // _lapsConsumptionCHKBX
            // 
            this._lapsConsumptionCHKBX.AutoSize = true;
            this._lapsConsumptionCHKBX.Font = new System.Drawing.Font("Calibri", 12F);
            this._lapsConsumptionCHKBX.Location = new System.Drawing.Point(61, 331);
            this._lapsConsumptionCHKBX.Name = "_lapsConsumptionCHKBX";
            this._lapsConsumptionCHKBX.Size = new System.Drawing.Size(240, 28);
            this._lapsConsumptionCHKBX.TabIndex = 8;
            this._lapsConsumptionCHKBX.Text = "Laps Consumption Mode";
            this._lapsConsumptionCHKBX.UseVisualStyleBackColor = true;
            this._lapsConsumptionCHKBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._lapsConsumptionCHKBX_KeyPress);
            this._lapsConsumptionCHKBX.MouseClick += new System.Windows.Forms.MouseEventHandler(this._lapsConsumptionCHKBX_MouseClick);
            // 
            // _minTimeTimeLBL
            // 
            this._minTimeTimeLBL.AutoSize = true;
            this._minTimeTimeLBL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._minTimeTimeLBL.Location = new System.Drawing.Point(560, 227);
            this._minTimeTimeLBL.Name = "_minTimeTimeLBL";
            this._minTimeTimeLBL.Size = new System.Drawing.Size(0, 24);
            this._minTimeTimeLBL.TabIndex = 26;
            // 
            // _minimumConsumptionCurrencyLBL
            // 
            this._minimumConsumptionCurrencyLBL.AutoSize = true;
            this._minimumConsumptionCurrencyLBL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._minimumConsumptionCurrencyLBL.Location = new System.Drawing.Point(560, 181);
            this._minimumConsumptionCurrencyLBL.Name = "_minimumConsumptionCurrencyLBL";
            this._minimumConsumptionCurrencyLBL.Size = new System.Drawing.Size(0, 24);
            this._minimumConsumptionCurrencyLBL.TabIndex = 25;
            // 
            // _minConsumptionTxtBox
            // 
            this._minConsumptionTxtBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._minConsumptionTxtBox.Location = new System.Drawing.Point(347, 178);
            this._minConsumptionTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._minConsumptionTxtBox.Name = "_minConsumptionTxtBox";
            this._minConsumptionTxtBox.Size = new System.Drawing.Size(187, 27);
            this._minConsumptionTxtBox.TabIndex = 5;
            this._minConsumptionTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Minimum Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Minimum Consumption:";
            // 
            // _minTimeTxtBox
            // 
            this._minTimeTxtBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._minTimeTxtBox.Location = new System.Drawing.Point(347, 224);
            this._minTimeTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._minTimeTxtBox.Name = "_minTimeTxtBox";
            this._minTimeTxtBox.Size = new System.Drawing.Size(187, 27);
            this._minTimeTxtBox.TabIndex = 6;
            this._minTimeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _resetBtn
            // 
            this._resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this._resetBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._resetBtn.ForeColor = System.Drawing.Color.Crimson;
            this._resetBtn.Location = new System.Drawing.Point(11, 477);
            this._resetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._resetBtn.Name = "_resetBtn";
            this._resetBtn.Size = new System.Drawing.Size(121, 36);
            this._resetBtn.TabIndex = 11;
            this._resetBtn.Text = "Reset";
            this._resetBtn.UseVisualStyleBackColor = true;
            this._resetBtn.Click += new System.EventHandler(this._resetBtn_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1, 379);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label6.Size = new System.Drawing.Size(687, 96);
            this.label6.TabIndex = 19;
            // 
            // EditSettingsWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.CancelButton = this._cancel;
            this.ClientSize = new System.Drawing.Size(754, 524);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._resetBtn);
            this.Controls.Add(this._controlsContainerGPBX);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._save);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "EditSettingsWindows";
            this.Text = "PlayBox Monitor Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditSettings_FormClosing);
            this.Load += new System.EventHandler(this.EditSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this._perDivisorNUpDown)).EndInit();
            this._controlsContainerGPBX.ResumeLayout(false);
            this._controlsContainerGPBX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown _timeDivisorUpDown;
        private System.Windows.Forms.Button _save;
        private System.Windows.Forms.Button _cancel;
        private System.Windows.Forms.TextBox _priceTxtBox;
        private System.Windows.Forms.TextBox _extraCPriceTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _timeIntervalTxtBox;
        private System.Windows.Forms.NumericUpDown _perDivisorNUpDown;
        private System.Windows.Forms.Label _AutoRefreshIndicatorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown _currencyUpDown;
        private System.Windows.Forms.GroupBox _controlsContainerGPBX;
        private System.Windows.Forms.TextBox _minConsumptionTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _minTimeTxtBox;
        private System.Windows.Forms.Label _minTimeTimeLBL;
        private System.Windows.Forms.Label _minimumConsumptionCurrencyLBL;
        private System.Windows.Forms.Button _resetBtn;
        private System.Windows.Forms.CheckBox _lapsConsumptionCHKBX;
        private System.Windows.Forms.Label label6;
    }
}