namespace PlayBoxMonitor
{
    partial class GameConsolePPClickWindow
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
            this._cancel = new System.Windows.Forms.Button();
            this._add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._currencyLBL = new System.Windows.Forms.Label();
            this._timeInputTxtBox = new System.Windows.Forms.TextBox();
            this._consumptionInputTxtBox = new System.Windows.Forms.TextBox();
            this._timeCHKBX = new System.Windows.Forms.CheckBox();
            this._consumptionCHKBX = new System.Windows.Forms.CheckBox();
            this._timeModeLBL = new System.Windows.Forms.Label();
            this._userMessageAlertRTXTBX = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cancel
            // 
            this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this._cancel.Location = new System.Drawing.Point(268, 186);
            this._cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(123, 36);
            this._cancel.TabIndex = 102;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = true;
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // _add
            // 
            this._add.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._add.ForeColor = System.Drawing.Color.DodgerBlue;
            this._add.Location = new System.Drawing.Point(268, 146);
            this._add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._add.Name = "_add";
            this._add.Size = new System.Drawing.Size(121, 36);
            this._add.TabIndex = 101;
            this._add.Text = "Add";
            this._add.UseVisualStyleBackColor = true;
            this._add.Click += new System.EventHandler(this._add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.groupBox1.Controls.Add(this._currencyLBL);
            this.groupBox1.Controls.Add(this._timeInputTxtBox);
            this.groupBox1.Controls.Add(this._consumptionInputTxtBox);
            this.groupBox1.Controls.Add(this._timeCHKBX);
            this.groupBox1.Controls.Add(this._consumptionCHKBX);
            this.groupBox1.Controls.Add(this._timeModeLBL);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-1, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 125);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PrePaid Options";
            // 
            // _currencyLBL
            // 
            this._currencyLBL.AutoSize = true;
            this._currencyLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this._currencyLBL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._currencyLBL.ForeColor = System.Drawing.Color.White;
            this._currencyLBL.Location = new System.Drawing.Point(397, 80);
            this._currencyLBL.Name = "_currencyLBL";
            this._currencyLBL.Size = new System.Drawing.Size(0, 24);
            this._currencyLBL.TabIndex = 6;
            // 
            // _timeInputTxtBox
            // 
            this._timeInputTxtBox.BackColor = System.Drawing.Color.White;
            this._timeInputTxtBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._timeInputTxtBox.Location = new System.Drawing.Point(204, 27);
            this._timeInputTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._timeInputTxtBox.Name = "_timeInputTxtBox";
            this._timeInputTxtBox.Size = new System.Drawing.Size(187, 27);
            this._timeInputTxtBox.TabIndex = 6;
            // 
            // _consumptionInputTxtBox
            // 
            this._consumptionInputTxtBox.BackColor = System.Drawing.Color.White;
            this._consumptionInputTxtBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._consumptionInputTxtBox.Location = new System.Drawing.Point(204, 76);
            this._consumptionInputTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._consumptionInputTxtBox.Name = "_consumptionInputTxtBox";
            this._consumptionInputTxtBox.Size = new System.Drawing.Size(187, 27);
            this._consumptionInputTxtBox.TabIndex = 8;
            // 
            // _timeCHKBX
            // 
            this._timeCHKBX.AutoSize = true;
            this._timeCHKBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this._timeCHKBX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._timeCHKBX.ForeColor = System.Drawing.Color.White;
            this._timeCHKBX.Location = new System.Drawing.Point(6, 27);
            this._timeCHKBX.Name = "_timeCHKBX";
            this._timeCHKBX.Size = new System.Drawing.Size(112, 28);
            this._timeCHKBX.TabIndex = 5;
            this._timeCHKBX.Tag = "time";
            this._timeCHKBX.Text = "Add Time";
            this._timeCHKBX.UseVisualStyleBackColor = false;
            this._timeCHKBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._CHKBX_KeyPress);
            this._timeCHKBX.MouseClick += new System.Windows.Forms.MouseEventHandler(this._timeCHKBX_MouseClick);
            // 
            // _consumptionCHKBX
            // 
            this._consumptionCHKBX.AutoSize = true;
            this._consumptionCHKBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this._consumptionCHKBX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._consumptionCHKBX.ForeColor = System.Drawing.Color.White;
            this._consumptionCHKBX.Location = new System.Drawing.Point(6, 76);
            this._consumptionCHKBX.Name = "_consumptionCHKBX";
            this._consumptionCHKBX.Size = new System.Drawing.Size(183, 28);
            this._consumptionCHKBX.TabIndex = 7;
            this._consumptionCHKBX.Tag = "consumption";
            this._consumptionCHKBX.Text = "Add Consumption";
            this._consumptionCHKBX.UseVisualStyleBackColor = false;
            this._consumptionCHKBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._CHKBX_KeyPress);
            this._consumptionCHKBX.MouseClick += new System.Windows.Forms.MouseEventHandler(this._consumptionCHKBX_MouseClick);
            // 
            // _timeModeLBL
            // 
            this._timeModeLBL.AutoSize = true;
            this._timeModeLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this._timeModeLBL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._timeModeLBL.ForeColor = System.Drawing.Color.White;
            this._timeModeLBL.Location = new System.Drawing.Point(397, 31);
            this._timeModeLBL.Name = "_timeModeLBL";
            this._timeModeLBL.Size = new System.Drawing.Size(0, 24);
            this._timeModeLBL.TabIndex = 13;
            // 
            // _userMessageAlertRTXTBX
            // 
            this._userMessageAlertRTXTBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._userMessageAlertRTXTBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this._userMessageAlertRTXTBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._userMessageAlertRTXTBX.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._userMessageAlertRTXTBX.ForeColor = System.Drawing.Color.Red;
            this._userMessageAlertRTXTBX.Location = new System.Drawing.Point(-1, 141);
            this._userMessageAlertRTXTBX.Name = "_userMessageAlertRTXTBX";
            this._userMessageAlertRTXTBX.ReadOnly = true;
            this._userMessageAlertRTXTBX.Size = new System.Drawing.Size(263, 81);
            this._userMessageAlertRTXTBX.TabIndex = 104;
            this._userMessageAlertRTXTBX.TabStop = false;
            this._userMessageAlertRTXTBX.Text = "";
            // 
            // GameConsolePPClickWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(396, 223);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._userMessageAlertRTXTBX);
            this.Name = "GameConsolePPClickWindow";
            this.Text = "GameConsolePPClickWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _cancel;
        private System.Windows.Forms.Button _add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label _currencyLBL;
        private System.Windows.Forms.TextBox _timeInputTxtBox;
        private System.Windows.Forms.TextBox _consumptionInputTxtBox;
        private System.Windows.Forms.CheckBox _timeCHKBX;
        private System.Windows.Forms.CheckBox _consumptionCHKBX;
        private System.Windows.Forms.Label _timeModeLBL;
        private System.Windows.Forms.RichTextBox _userMessageAlertRTXTBX;
    }
}