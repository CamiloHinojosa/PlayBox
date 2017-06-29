namespace PlayBoxMonitor
{
    partial class ConfirmationWindow
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
            this._submit = new System.Windows.Forms.Button();
            this._cancel = new System.Windows.Forms.Button();
            this._textToDisplayTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _submit
            // 
            this._submit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._submit.ForeColor = System.Drawing.Color.DodgerBlue;
            this._submit.Location = new System.Drawing.Point(339, 109);
            this._submit.Name = "_submit";
            this._submit.Size = new System.Drawing.Size(121, 36);
            this._submit.TabIndex = 0;
            this._submit.UseVisualStyleBackColor = true;
            this._submit.Click += new System.EventHandler(this._submit_Click);
            // 
            // _cancel
            // 
            this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this._cancel.Location = new System.Drawing.Point(466, 109);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(121, 36);
            this._cancel.TabIndex = 1;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = true;
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // _textToDisplayTxtBox
            // 
            this._textToDisplayTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this._textToDisplayTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._textToDisplayTxtBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textToDisplayTxtBox.ForeColor = System.Drawing.Color.White;
            this._textToDisplayTxtBox.Location = new System.Drawing.Point(13, 12);
            this._textToDisplayTxtBox.Multiline = true;
            this._textToDisplayTxtBox.Name = "_textToDisplayTxtBox";
            this._textToDisplayTxtBox.ReadOnly = true;
            this._textToDisplayTxtBox.Size = new System.Drawing.Size(574, 91);
            this._textToDisplayTxtBox.TabIndex = 3;
            this._textToDisplayTxtBox.TabStop = false;
            this._textToDisplayTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfirmationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(599, 157);
            this.Controls.Add(this._textToDisplayTxtBox);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmationWindow";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConfirmationWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _submit;
        private System.Windows.Forms.Button _cancel;
        private System.Windows.Forms.TextBox _textToDisplayTxtBox;
    }
}