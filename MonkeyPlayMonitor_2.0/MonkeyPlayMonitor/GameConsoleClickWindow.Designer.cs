namespace PlayBoxMonitor
{
    partial class GameConsoleClickWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameConsoleClickWindow));
            this._timeCHKBX = new System.Windows.Forms.CheckBox();
            this._consumptionCHKBX = new System.Windows.Forms.CheckBox();
            this._userMessageAlertRTXTBX = new System.Windows.Forms.RichTextBox();
            this._currencyLBL = new System.Windows.Forms.Label();
            this._timeInputTxtBox = new System.Windows.Forms.TextBox();
            this._consumptionInputTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._clientDocIdLBL = new System.Windows.Forms.Label();
            this._clientDocIdTXTBX = new System.Windows.Forms.TextBox();
            this._StartTypeLBL = new System.Windows.Forms.Label();
            this._clientDateOfBirthPanel = new System.Windows.Forms.DateTimePicker();
            this._clientDateOfBirthLBL = new System.Windows.Forms.Label();
            this._clientPhoneNumberLBL = new System.Windows.Forms.Label();
            this._clientPhoneNumberTXTBX = new System.Windows.Forms.TextBox();
            this._clientNameLBL = new System.Windows.Forms.Label();
            this._clientNameInputTXTBX = new System.Windows.Forms.TextBox();
            this._normalCHKBX = new System.Windows.Forms.CheckBox();
            this._timeModeLBL = new System.Windows.Forms.Label();
            this._cancel = new System.Windows.Forms.Button();
            this._start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _timeCHKBX
            // 
            this._timeCHKBX.AutoSize = true;
            this._timeCHKBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this._timeCHKBX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._timeCHKBX.ForeColor = System.Drawing.Color.White;
            this._timeCHKBX.Location = new System.Drawing.Point(455, 111);
            this._timeCHKBX.Name = "_timeCHKBX";
            this._timeCHKBX.Size = new System.Drawing.Size(98, 28);
            this._timeCHKBX.TabIndex = 5;
            this._timeCHKBX.Tag = "time";
            this._timeCHKBX.Text = "By Time";
            this._timeCHKBX.UseVisualStyleBackColor = false;
            this._timeCHKBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._normalCHKBX_KeyPress);
            this._timeCHKBX.MouseClick += new System.Windows.Forms.MouseEventHandler(this._timeCHKBX_MouseClick);
            // 
            // _consumptionCHKBX
            // 
            this._consumptionCHKBX.AutoSize = true;
            this._consumptionCHKBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this._consumptionCHKBX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._consumptionCHKBX.ForeColor = System.Drawing.Color.White;
            this._consumptionCHKBX.Location = new System.Drawing.Point(455, 160);
            this._consumptionCHKBX.Name = "_consumptionCHKBX";
            this._consumptionCHKBX.Size = new System.Drawing.Size(169, 28);
            this._consumptionCHKBX.TabIndex = 7;
            this._consumptionCHKBX.Tag = "consumption";
            this._consumptionCHKBX.Text = "By Consumption";
            this._consumptionCHKBX.UseVisualStyleBackColor = false;
            this._consumptionCHKBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._normalCHKBX_KeyPress);
            this._consumptionCHKBX.MouseClick += new System.Windows.Forms.MouseEventHandler(this._consumptionCHKBX_MouseClick);
            // 
            // _userMessageAlertRTXTBX
            // 
            this._userMessageAlertRTXTBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._userMessageAlertRTXTBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this._userMessageAlertRTXTBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._userMessageAlertRTXTBX.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._userMessageAlertRTXTBX.ForeColor = System.Drawing.Color.Red;
            this._userMessageAlertRTXTBX.Location = new System.Drawing.Point(3, 213);
            this._userMessageAlertRTXTBX.Name = "_userMessageAlertRTXTBX";
            this._userMessageAlertRTXTBX.ReadOnly = true;
            this._userMessageAlertRTXTBX.Size = new System.Drawing.Size(655, 93);
            this._userMessageAlertRTXTBX.TabIndex = 100;
            this._userMessageAlertRTXTBX.TabStop = false;
            this._userMessageAlertRTXTBX.Text = "";
            // 
            // _currencyLBL
            // 
            this._currencyLBL.AutoSize = true;
            this._currencyLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this._currencyLBL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._currencyLBL.ForeColor = System.Drawing.Color.White;
            this._currencyLBL.Location = new System.Drawing.Point(823, 164);
            this._currencyLBL.Name = "_currencyLBL";
            this._currencyLBL.Size = new System.Drawing.Size(0, 24);
            this._currencyLBL.TabIndex = 6;
            // 
            // _timeInputTxtBox
            // 
            this._timeInputTxtBox.BackColor = System.Drawing.Color.White;
            this._timeInputTxtBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._timeInputTxtBox.Location = new System.Drawing.Point(630, 112);
            this._timeInputTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._timeInputTxtBox.Name = "_timeInputTxtBox";
            this._timeInputTxtBox.Size = new System.Drawing.Size(187, 27);
            this._timeInputTxtBox.TabIndex = 6;
            // 
            // _consumptionInputTxtBox
            // 
            this._consumptionInputTxtBox.BackColor = System.Drawing.Color.White;
            this._consumptionInputTxtBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._consumptionInputTxtBox.Location = new System.Drawing.Point(630, 161);
            this._consumptionInputTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._consumptionInputTxtBox.Name = "_consumptionInputTxtBox";
            this._consumptionInputTxtBox.Size = new System.Drawing.Size(187, 27);
            this._consumptionInputTxtBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.groupBox1.Controls.Add(this._clientDocIdLBL);
            this.groupBox1.Controls.Add(this._clientDocIdTXTBX);
            this.groupBox1.Controls.Add(this._StartTypeLBL);
            this.groupBox1.Controls.Add(this._clientDateOfBirthPanel);
            this.groupBox1.Controls.Add(this._currencyLBL);
            this.groupBox1.Controls.Add(this._clientDateOfBirthLBL);
            this.groupBox1.Controls.Add(this._timeInputTxtBox);
            this.groupBox1.Controls.Add(this._clientPhoneNumberLBL);
            this.groupBox1.Controls.Add(this._consumptionInputTxtBox);
            this.groupBox1.Controls.Add(this._clientPhoneNumberTXTBX);
            this.groupBox1.Controls.Add(this._timeCHKBX);
            this.groupBox1.Controls.Add(this._consumptionCHKBX);
            this.groupBox1.Controls.Add(this._clientNameLBL);
            this.groupBox1.Controls.Add(this._clientNameInputTXTBX);
            this.groupBox1.Controls.Add(this._normalCHKBX);
            this.groupBox1.Controls.Add(this._timeModeLBL);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 206);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PrePaid Options";
            // 
            // _clientDocIdLBL
            // 
            this._clientDocIdLBL.AutoSize = true;
            this._clientDocIdLBL.Location = new System.Drawing.Point(12, 160);
            this._clientDocIdLBL.Name = "_clientDocIdLBL";
            this._clientDocIdLBL.Size = new System.Drawing.Size(98, 21);
            this._clientDocIdLBL.TabIndex = 23;
            this._clientDocIdLBL.Text = "Client Doc ID";
            // 
            // _clientDocIdTXTBX
            // 
            this._clientDocIdTXTBX.BackColor = System.Drawing.Color.White;
            this._clientDocIdTXTBX.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clientDocIdTXTBX.Location = new System.Drawing.Point(177, 154);
            this._clientDocIdTXTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._clientDocIdTXTBX.Name = "_clientDocIdTXTBX";
            this._clientDocIdTXTBX.Size = new System.Drawing.Size(200, 27);
            this._clientDocIdTXTBX.TabIndex = 3;
            // 
            // _StartTypeLBL
            // 
            this._StartTypeLBL.AutoSize = true;
            this._StartTypeLBL.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._StartTypeLBL.Location = new System.Drawing.Point(451, 24);
            this._StartTypeLBL.Name = "_StartTypeLBL";
            this._StartTypeLBL.Size = new System.Drawing.Size(105, 24);
            this._StartTypeLBL.TabIndex = 21;
            this._StartTypeLBL.Text = "Start Type: ";
            // 
            // _clientDateOfBirthPanel
            // 
            this._clientDateOfBirthPanel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._clientDateOfBirthPanel.Location = new System.Drawing.Point(177, 105);
            this._clientDateOfBirthPanel.Name = "_clientDateOfBirthPanel";
            this._clientDateOfBirthPanel.Size = new System.Drawing.Size(200, 28);
            this._clientDateOfBirthPanel.TabIndex = 2;
            this._clientDateOfBirthPanel.Value = new System.DateTime(2016, 3, 21, 13, 24, 28, 0);
            // 
            // _clientDateOfBirthLBL
            // 
            this._clientDateOfBirthLBL.AutoSize = true;
            this._clientDateOfBirthLBL.Location = new System.Drawing.Point(12, 111);
            this._clientDateOfBirthLBL.Name = "_clientDateOfBirthLBL";
            this._clientDateOfBirthLBL.Size = new System.Drawing.Size(100, 21);
            this._clientDateOfBirthLBL.TabIndex = 19;
            this._clientDateOfBirthLBL.Text = "Date Of Birth";
            // 
            // _clientPhoneNumberLBL
            // 
            this._clientPhoneNumberLBL.AutoSize = true;
            this._clientPhoneNumberLBL.Location = new System.Drawing.Point(12, 72);
            this._clientPhoneNumberLBL.Name = "_clientPhoneNumberLBL";
            this._clientPhoneNumberLBL.Size = new System.Drawing.Size(159, 21);
            this._clientPhoneNumberLBL.TabIndex = 17;
            this._clientPhoneNumberLBL.Text = "Client Phone Number";
            // 
            // _clientPhoneNumberTXTBX
            // 
            this._clientPhoneNumberTXTBX.BackColor = System.Drawing.Color.White;
            this._clientPhoneNumberTXTBX.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clientPhoneNumberTXTBX.Location = new System.Drawing.Point(177, 66);
            this._clientPhoneNumberTXTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._clientPhoneNumberTXTBX.Name = "_clientPhoneNumberTXTBX";
            this._clientPhoneNumberTXTBX.Size = new System.Drawing.Size(200, 27);
            this._clientPhoneNumberTXTBX.TabIndex = 1;
            // 
            // _clientNameLBL
            // 
            this._clientNameLBL.AutoSize = true;
            this._clientNameLBL.Location = new System.Drawing.Point(12, 33);
            this._clientNameLBL.Name = "_clientNameLBL";
            this._clientNameLBL.Size = new System.Drawing.Size(95, 21);
            this._clientNameLBL.TabIndex = 15;
            this._clientNameLBL.Text = "Client Name";
            // 
            // _clientNameInputTXTBX
            // 
            this._clientNameInputTXTBX.BackColor = System.Drawing.Color.White;
            this._clientNameInputTXTBX.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clientNameInputTXTBX.Location = new System.Drawing.Point(177, 27);
            this._clientNameInputTXTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._clientNameInputTXTBX.Name = "_clientNameInputTXTBX";
            this._clientNameInputTXTBX.Size = new System.Drawing.Size(200, 27);
            this._clientNameInputTXTBX.TabIndex = 0;
            // 
            // _normalCHKBX
            // 
            this._normalCHKBX.AutoSize = true;
            this._normalCHKBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this._normalCHKBX.Checked = true;
            this._normalCHKBX.CheckState = System.Windows.Forms.CheckState.Checked;
            this._normalCHKBX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._normalCHKBX.ForeColor = System.Drawing.Color.White;
            this._normalCHKBX.Location = new System.Drawing.Point(455, 65);
            this._normalCHKBX.Name = "_normalCHKBX";
            this._normalCHKBX.Size = new System.Drawing.Size(94, 28);
            this._normalCHKBX.TabIndex = 4;
            this._normalCHKBX.Tag = "normal";
            this._normalCHKBX.Text = "Normal";
            this._normalCHKBX.UseVisualStyleBackColor = false;
            this._normalCHKBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._normalCHKBX_KeyPress);
            this._normalCHKBX.MouseClick += new System.Windows.Forms.MouseEventHandler(this._normalCHKBX_MouseClick);
            // 
            // _timeModeLBL
            // 
            this._timeModeLBL.AutoSize = true;
            this._timeModeLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this._timeModeLBL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._timeModeLBL.ForeColor = System.Drawing.Color.White;
            this._timeModeLBL.Location = new System.Drawing.Point(823, 115);
            this._timeModeLBL.Name = "_timeModeLBL";
            this._timeModeLBL.Size = new System.Drawing.Size(0, 24);
            this._timeModeLBL.TabIndex = 13;
            // 
            // _cancel
            // 
            this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this._cancel.Location = new System.Drawing.Point(791, 262);
            this._cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(123, 36);
            this._cancel.TabIndex = 10;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = true;
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // _start
            // 
            this._start.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._start.ForeColor = System.Drawing.Color.DodgerBlue;
            this._start.Location = new System.Drawing.Point(664, 262);
            this._start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._start.Name = "_start";
            this._start.Size = new System.Drawing.Size(121, 36);
            this._start.TabIndex = 9;
            this._start.Text = "Start";
            this._start.UseVisualStyleBackColor = true;
            this._start.Click += new System.EventHandler(this._start_Click);
            // 
            // GameConsoleClickWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(923, 309);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._start);
            this.Controls.Add(this._userMessageAlertRTXTBX);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameConsoleClickWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCCPrePaidOptions";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GCCPrePaidOptions_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox _timeCHKBX;
        private System.Windows.Forms.CheckBox _consumptionCHKBX;
        private System.Windows.Forms.RichTextBox _userMessageAlertRTXTBX;
        private System.Windows.Forms.Label _currencyLBL;
        private System.Windows.Forms.TextBox _timeInputTxtBox;
        private System.Windows.Forms.TextBox _consumptionInputTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _cancel;
        private System.Windows.Forms.Button _start;
        private System.Windows.Forms.Label _timeModeLBL;
        private System.Windows.Forms.Label _StartTypeLBL;
        private System.Windows.Forms.DateTimePicker _clientDateOfBirthPanel;
        private System.Windows.Forms.Label _clientDateOfBirthLBL;
        private System.Windows.Forms.Label _clientPhoneNumberLBL;
        private System.Windows.Forms.TextBox _clientPhoneNumberTXTBX;
        private System.Windows.Forms.Label _clientNameLBL;
        private System.Windows.Forms.TextBox _clientNameInputTXTBX;
        private System.Windows.Forms.CheckBox _normalCHKBX;
        private System.Windows.Forms.Label _clientDocIdLBL;
        private System.Windows.Forms.TextBox _clientDocIdTXTBX;
    }
}