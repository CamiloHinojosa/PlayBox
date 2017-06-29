namespace PlayBoxMonitor
{
    partial class CreateConsoleWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateConsoleWindow));
            this._consoleNameLabel = new System.Windows.Forms.Label();
            this._consoleNameTxtBox = new System.Windows.Forms.RichTextBox();
            this._htmlColorTxTBox = new System.Windows.Forms.RichTextBox();
            this._htmlColorCHKBox = new System.Windows.Forms.CheckBox();
            this._create = new System.Windows.Forms.Button();
            this._cancel = new System.Windows.Forms.Button();
            this._containerGBox = new System.Windows.Forms.GroupBox();
            this._redColorLabel = new System.Windows.Forms.Label();
            this._greenColorLabel = new System.Windows.Forms.Label();
            this._blueRGBTxtBox = new System.Windows.Forms.RichTextBox();
            this._blueColorLabel = new System.Windows.Forms.Label();
            this._greenRGBTxtBox = new System.Windows.Forms.RichTextBox();
            this._redRGB = new System.Windows.Forms.TrackBar();
            this._redRGBTxtBox = new System.Windows.Forms.RichTextBox();
            this._greenRGB = new System.Windows.Forms.TrackBar();
            this._rgbColorCHKBox = new System.Windows.Forms.CheckBox();
            this._blueRGB = new System.Windows.Forms.TrackBar();
            this._numberOfConsolesLabel = new System.Windows.Forms.Label();
            this._numberOfConsolesUpDown = new System.Windows.Forms.NumericUpDown();
            this._errorLabel = new System.Windows.Forms.Label();
            this._containerGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._redRGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._greenRGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._blueRGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numberOfConsolesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _consoleNameLabel
            // 
            this._consoleNameLabel.AutoSize = true;
            this._consoleNameLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._consoleNameLabel.ForeColor = System.Drawing.Color.White;
            this._consoleNameLabel.Location = new System.Drawing.Point(13, 23);
            this._consoleNameLabel.Name = "_consoleNameLabel";
            this._consoleNameLabel.Size = new System.Drawing.Size(115, 21);
            this._consoleNameLabel.TabIndex = 15;
            this._consoleNameLabel.Text = "Console Name:";
            // 
            // _consoleNameTxtBox
            // 
            this._consoleNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._consoleNameTxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._consoleNameTxtBox.Location = new System.Drawing.Point(141, 12);
            this._consoleNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._consoleNameTxtBox.Multiline = false;
            this._consoleNameTxtBox.Name = "_consoleNameTxtBox";
            this._consoleNameTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._consoleNameTxtBox.Size = new System.Drawing.Size(175, 32);
            this._consoleNameTxtBox.TabIndex = 0;
            this._consoleNameTxtBox.Text = "";
            // 
            // _htmlColorTxTBox
            // 
            this._htmlColorTxTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._htmlColorTxTBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._htmlColorTxTBox.Location = new System.Drawing.Point(215, 20);
            this._htmlColorTxTBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._htmlColorTxTBox.Multiline = false;
            this._htmlColorTxTBox.Name = "_htmlColorTxTBox";
            this._htmlColorTxTBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._htmlColorTxTBox.Size = new System.Drawing.Size(175, 32);
            this._htmlColorTxTBox.TabIndex = 2;
            this._htmlColorTxTBox.Text = "";
            this._htmlColorTxTBox.Leave += new System.EventHandler(this._htmlColorTxTBox_Leave);
            // 
            // _htmlColorCHKBox
            // 
            this._htmlColorCHKBox.AutoSize = true;
            this._htmlColorCHKBox.Checked = true;
            this._htmlColorCHKBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._htmlColorCHKBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._htmlColorCHKBox.ForeColor = System.Drawing.Color.White;
            this._htmlColorCHKBox.Location = new System.Drawing.Point(5, 27);
            this._htmlColorCHKBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._htmlColorCHKBox.Name = "_htmlColorCHKBox";
            this._htmlColorCHKBox.Size = new System.Drawing.Size(136, 25);
            this._htmlColorCHKBox.TabIndex = 1;
            this._htmlColorCHKBox.Text = "HTML Color (#)";
            this._htmlColorCHKBox.UseVisualStyleBackColor = true;
            this._htmlColorCHKBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._htmlColorCHKBox_KeyPress);
            this._htmlColorCHKBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this._htmlColorCHKBox_CheckedChanged);
            // 
            // _create
            // 
            this._create.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._create.ForeColor = System.Drawing.Color.DodgerBlue;
            this._create.Location = new System.Drawing.Point(253, 295);
            this._create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._create.Name = "_create";
            this._create.Size = new System.Drawing.Size(121, 36);
            this._create.TabIndex = 11;
            this._create.Text = "Create";
            this._create.UseVisualStyleBackColor = true;
            this._create.Click += new System.EventHandler(this._create_Click);
            // 
            // _cancel
            // 
            this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this._cancel.Location = new System.Drawing.Point(381, 295);
            this._cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(121, 36);
            this._cancel.TabIndex = 12;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = true;
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // _containerGBox
            // 
            this._containerGBox.Controls.Add(this._redColorLabel);
            this._containerGBox.Controls.Add(this._greenColorLabel);
            this._containerGBox.Controls.Add(this._blueRGBTxtBox);
            this._containerGBox.Controls.Add(this._blueColorLabel);
            this._containerGBox.Controls.Add(this._greenRGBTxtBox);
            this._containerGBox.Controls.Add(this._redRGB);
            this._containerGBox.Controls.Add(this._redRGBTxtBox);
            this._containerGBox.Controls.Add(this._greenRGB);
            this._containerGBox.Controls.Add(this._rgbColorCHKBox);
            this._containerGBox.Controls.Add(this._blueRGB);
            this._containerGBox.Controls.Add(this._htmlColorCHKBox);
            this._containerGBox.Controls.Add(this._htmlColorTxTBox);
            this._containerGBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._containerGBox.ForeColor = System.Drawing.Color.White;
            this._containerGBox.Location = new System.Drawing.Point(17, 50);
            this._containerGBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._containerGBox.Name = "_containerGBox";
            this._containerGBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._containerGBox.Size = new System.Drawing.Size(485, 190);
            this._containerGBox.TabIndex = 22;
            this._containerGBox.TabStop = false;
            this._containerGBox.Text = "Color Identifier";
            // 
            // _redColorLabel
            // 
            this._redColorLabel.AutoSize = true;
            this._redColorLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._redColorLabel.ForeColor = System.Drawing.Color.White;
            this._redColorLabel.Location = new System.Drawing.Point(153, 66);
            this._redColorLabel.Name = "_redColorLabel";
            this._redColorLabel.Size = new System.Drawing.Size(36, 21);
            this._redColorLabel.TabIndex = 14;
            this._redColorLabel.Text = "Red";
            // 
            // _greenColorLabel
            // 
            this._greenColorLabel.AutoSize = true;
            this._greenColorLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._greenColorLabel.ForeColor = System.Drawing.Color.White;
            this._greenColorLabel.Location = new System.Drawing.Point(153, 103);
            this._greenColorLabel.Name = "_greenColorLabel";
            this._greenColorLabel.Size = new System.Drawing.Size(52, 21);
            this._greenColorLabel.TabIndex = 13;
            this._greenColorLabel.Text = "Green";
            // 
            // _blueRGBTxtBox
            // 
            this._blueRGBTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._blueRGBTxtBox.DetectUrls = false;
            this._blueRGBTxtBox.Location = new System.Drawing.Point(401, 137);
            this._blueRGBTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._blueRGBTxtBox.Multiline = false;
            this._blueRGBTxtBox.Name = "_blueRGBTxtBox";
            this._blueRGBTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._blueRGBTxtBox.Size = new System.Drawing.Size(49, 25);
            this._blueRGBTxtBox.TabIndex = 9;
            this._blueRGBTxtBox.Tag = "blue";
            this._blueRGBTxtBox.Text = "";
            this._blueRGBTxtBox.WordWrap = false;
            this._blueRGBTxtBox.Leave += new System.EventHandler(this._colorRGBTxtBox_TextChanged);
            // 
            // _blueColorLabel
            // 
            this._blueColorLabel.AutoSize = true;
            this._blueColorLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._blueColorLabel.ForeColor = System.Drawing.Color.White;
            this._blueColorLabel.Location = new System.Drawing.Point(153, 140);
            this._blueColorLabel.Name = "_blueColorLabel";
            this._blueColorLabel.Size = new System.Drawing.Size(40, 21);
            this._blueColorLabel.TabIndex = 12;
            this._blueColorLabel.Text = "Blue";
            // 
            // _greenRGBTxtBox
            // 
            this._greenRGBTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._greenRGBTxtBox.DetectUrls = false;
            this._greenRGBTxtBox.Location = new System.Drawing.Point(401, 103);
            this._greenRGBTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._greenRGBTxtBox.Multiline = false;
            this._greenRGBTxtBox.Name = "_greenRGBTxtBox";
            this._greenRGBTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._greenRGBTxtBox.Size = new System.Drawing.Size(49, 22);
            this._greenRGBTxtBox.TabIndex = 7;
            this._greenRGBTxtBox.Tag = "green";
            this._greenRGBTxtBox.Text = "";
            this._greenRGBTxtBox.WordWrap = false;
            this._greenRGBTxtBox.Leave += new System.EventHandler(this._colorRGBTxtBox_TextChanged);
            // 
            // _redRGB
            // 
            this._redRGB.AutoSize = false;
            this._redRGB.Location = new System.Drawing.Point(223, 65);
            this._redRGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._redRGB.Maximum = 255;
            this._redRGB.Name = "_redRGB";
            this._redRGB.Size = new System.Drawing.Size(172, 33);
            this._redRGB.TabIndex = 4;
            this._redRGB.Tag = "red";
            this._redRGB.TickFrequency = 25;
            this._redRGB.ValueChanged += new System.EventHandler(this._colorRGB_ValueChanged);
            // 
            // _redRGBTxtBox
            // 
            this._redRGBTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._redRGBTxtBox.DetectUrls = false;
            this._redRGBTxtBox.Location = new System.Drawing.Point(401, 65);
            this._redRGBTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._redRGBTxtBox.Multiline = false;
            this._redRGBTxtBox.Name = "_redRGBTxtBox";
            this._redRGBTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._redRGBTxtBox.Size = new System.Drawing.Size(49, 22);
            this._redRGBTxtBox.TabIndex = 5;
            this._redRGBTxtBox.Tag = "red";
            this._redRGBTxtBox.Text = "";
            this._redRGBTxtBox.WordWrap = false;
            this._redRGBTxtBox.Leave += new System.EventHandler(this._colorRGBTxtBox_TextChanged);
            // 
            // _greenRGB
            // 
            this._greenRGB.AutoSize = false;
            this._greenRGB.Location = new System.Drawing.Point(223, 103);
            this._greenRGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._greenRGB.Maximum = 255;
            this._greenRGB.Name = "_greenRGB";
            this._greenRGB.Size = new System.Drawing.Size(172, 33);
            this._greenRGB.TabIndex = 6;
            this._greenRGB.Tag = "green";
            this._greenRGB.TickFrequency = 25;
            this._greenRGB.ValueChanged += new System.EventHandler(this._colorRGB_ValueChanged);
            // 
            // _rgbColorCHKBox
            // 
            this._rgbColorCHKBox.AutoSize = true;
            this._rgbColorCHKBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rgbColorCHKBox.ForeColor = System.Drawing.Color.White;
            this._rgbColorCHKBox.Location = new System.Drawing.Point(5, 66);
            this._rgbColorCHKBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._rgbColorCHKBox.Name = "_rgbColorCHKBox";
            this._rgbColorCHKBox.Size = new System.Drawing.Size(102, 25);
            this._rgbColorCHKBox.TabIndex = 3;
            this._rgbColorCHKBox.Text = "RGB Color";
            this._rgbColorCHKBox.UseVisualStyleBackColor = true;
            this._rgbColorCHKBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._rgbColorCHKBox_KeyPress);
            this._rgbColorCHKBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this._rgbColorCHKBox_CheckedChanged);
            // 
            // _blueRGB
            // 
            this._blueRGB.AutoSize = false;
            this._blueRGB.Location = new System.Drawing.Point(223, 140);
            this._blueRGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._blueRGB.Maximum = 255;
            this._blueRGB.Name = "_blueRGB";
            this._blueRGB.Size = new System.Drawing.Size(172, 33);
            this._blueRGB.TabIndex = 8;
            this._blueRGB.Tag = "blue";
            this._blueRGB.TickFrequency = 25;
            this._blueRGB.ValueChanged += new System.EventHandler(this._colorRGB_ValueChanged);
            // 
            // _numberOfConsolesLabel
            // 
            this._numberOfConsolesLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._numberOfConsolesLabel.ForeColor = System.Drawing.Color.White;
            this._numberOfConsolesLabel.Location = new System.Drawing.Point(9, 303);
            this._numberOfConsolesLabel.Name = "_numberOfConsolesLabel";
            this._numberOfConsolesLabel.Size = new System.Drawing.Size(157, 21);
            this._numberOfConsolesLabel.TabIndex = 23;
            this._numberOfConsolesLabel.Text = "Number of Consoles:";
            // 
            // _numberOfConsolesUpDown
            // 
            this._numberOfConsolesUpDown.Location = new System.Drawing.Point(173, 302);
            this._numberOfConsolesUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numberOfConsolesUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._numberOfConsolesUpDown.Name = "_numberOfConsolesUpDown";
            this._numberOfConsolesUpDown.Size = new System.Drawing.Size(64, 22);
            this._numberOfConsolesUpDown.TabIndex = 10;
            this._numberOfConsolesUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _errorLabel
            // 
            this._errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._errorLabel.ForeColor = System.Drawing.Color.Red;
            this._errorLabel.Location = new System.Drawing.Point(17, 246);
            this._errorLabel.Name = "_errorLabel";
            this._errorLabel.Size = new System.Drawing.Size(485, 43);
            this._errorLabel.TabIndex = 25;
            // 
            // CreateConsoleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.CancelButton = this._cancel;
            this.ClientSize = new System.Drawing.Size(516, 335);
            this.Controls.Add(this._errorLabel);
            this.Controls.Add(this._numberOfConsolesUpDown);
            this.Controls.Add(this._numberOfConsolesLabel);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._create);
            this.Controls.Add(this._consoleNameTxtBox);
            this.Controls.Add(this._consoleNameLabel);
            this.Controls.Add(this._containerGBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(534, 382);
            this.Name = "CreateConsoleWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Create Game Console";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateConsoleWindow_FormClosing);
            this.Load += new System.EventHandler(this.CreateConsoleWindow_Load);
            this._containerGBox.ResumeLayout(false);
            this._containerGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._redRGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._greenRGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._blueRGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numberOfConsolesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _consoleNameLabel;
        private System.Windows.Forms.RichTextBox _consoleNameTxtBox;
        private System.Windows.Forms.RichTextBox _htmlColorTxTBox;
        private System.Windows.Forms.CheckBox _htmlColorCHKBox;
        private System.Windows.Forms.Button _create;
        private System.Windows.Forms.Button _cancel;
        private System.Windows.Forms.GroupBox _containerGBox;
        private System.Windows.Forms.Label _redColorLabel;
        private System.Windows.Forms.Label _greenColorLabel;
        private System.Windows.Forms.RichTextBox _blueRGBTxtBox;
        private System.Windows.Forms.Label _blueColorLabel;
        private System.Windows.Forms.RichTextBox _greenRGBTxtBox;
        private System.Windows.Forms.RichTextBox _redRGBTxtBox;
        private System.Windows.Forms.TrackBar _greenRGB;
        private System.Windows.Forms.CheckBox _rgbColorCHKBox;
        private System.Windows.Forms.TrackBar _blueRGB;
        private System.Windows.Forms.Label _numberOfConsolesLabel;
        private System.Windows.Forms.NumericUpDown _numberOfConsolesUpDown;
        private System.Windows.Forms.TrackBar _redRGB;
        private System.Windows.Forms.Label _errorLabel;
    }
}