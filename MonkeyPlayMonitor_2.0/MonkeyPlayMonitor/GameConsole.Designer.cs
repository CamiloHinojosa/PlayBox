namespace PlayBoxMonitor
{
    partial class GameConsole
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._totalConsumptionLabel = new System.Windows.Forms.Label();
            this._timeLabel = new System.Windows.Forms.Label();
            this._extraControlsLabel = new System.Windows.Forms.Label();
            this._timeDisplay = new System.Windows.Forms.TextBox();
            this._extraControlsDisplay = new System.Windows.Forms.NumericUpDown();
            this._consumptionDisplay = new System.Windows.Forms.TextBox();
            this._nameLabel = new System.Windows.Forms.Label();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._cashReset = new System.Windows.Forms.Button();
            this._startStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._extraControlsDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _totalConsumptionLabel
            // 
            this._totalConsumptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._totalConsumptionLabel.AutoSize = true;
            this._totalConsumptionLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._totalConsumptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(74)))));
            this._totalConsumptionLabel.Location = new System.Drawing.Point(70, 95);
            this._totalConsumptionLabel.Name = "_totalConsumptionLabel";
            this._totalConsumptionLabel.Size = new System.Drawing.Size(110, 20);
            this._totalConsumptionLabel.TabIndex = 8;
            this._totalConsumptionLabel.Text = "Consumption:";
            // 
            // _timeLabel
            // 
            this._timeLabel.AutoSize = true;
            this._timeLabel.BackColor = System.Drawing.Color.Transparent;
            this._timeLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(74)))));
            this._timeLabel.Location = new System.Drawing.Point(7, 71);
            this._timeLabel.Name = "_timeLabel";
            this._timeLabel.Size = new System.Drawing.Size(111, 20);
            this._timeLabel.TabIndex = 7;
            this._timeLabel.Text = "Time Elapsed:";
            // 
            // _extraControlsLabel
            // 
            this._extraControlsLabel.AutoSize = true;
            this._extraControlsLabel.BackColor = System.Drawing.Color.Transparent;
            this._extraControlsLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._extraControlsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(74)))));
            this._extraControlsLabel.Location = new System.Drawing.Point(7, 41);
            this._extraControlsLabel.Name = "_extraControlsLabel";
            this._extraControlsLabel.Size = new System.Drawing.Size(80, 20);
            this._extraControlsLabel.TabIndex = 6;
            this._extraControlsLabel.Text = "Controls:";
            // 
            // _timeDisplay
            // 
            this._timeDisplay.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._timeDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(74)))));
            this._timeDisplay.Location = new System.Drawing.Point(161, 64);
            this._timeDisplay.Name = "_timeDisplay";
            this._timeDisplay.ReadOnly = true;
            this._timeDisplay.Size = new System.Drawing.Size(80, 27);
            this._timeDisplay.TabIndex = 5;
            this._timeDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _extraControlsDisplay
            // 
            this._extraControlsDisplay.AllowDrop = true;
            this._extraControlsDisplay.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._extraControlsDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(74)))));
            this._extraControlsDisplay.Location = new System.Drawing.Point(162, 32);
            this._extraControlsDisplay.Name = "_extraControlsDisplay";
            this._extraControlsDisplay.ReadOnly = true;
            this._extraControlsDisplay.Size = new System.Drawing.Size(80, 27);
            this._extraControlsDisplay.TabIndex = 4;
            this._extraControlsDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _consumptionDisplay
            // 
            this._consumptionDisplay.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._consumptionDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(74)))));
            this._consumptionDisplay.Location = new System.Drawing.Point(20, 119);
            this._consumptionDisplay.Name = "_consumptionDisplay";
            this._consumptionDisplay.ReadOnly = true;
            this._consumptionDisplay.Size = new System.Drawing.Size(210, 28);
            this._consumptionDisplay.TabIndex = 3;
            this._consumptionDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.BackColor = System.Drawing.Color.Transparent;
            this._nameLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nameLabel.Location = new System.Drawing.Point(35, 3);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(100, 23);
            this._nameLabel.TabIndex = 0;
            this._nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _pictureBox
            // 
            this._pictureBox.BackColor = System.Drawing.Color.Transparent;
            this._pictureBox.Image = global::PlayBoxMonitor.Properties.Resources.Preloader_335;
            this._pictureBox.Location = new System.Drawing.Point(110, 28);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(35, 35);
            this._pictureBox.TabIndex = 9;
            this._pictureBox.TabStop = false;
            this._pictureBox.Click += new System.EventHandler(this._pictureBox_Click);
            // 
            // _cashReset
            // 
            this._cashReset.AutoSize = true;
            this._cashReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cashReset.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cashReset.ForeColor = System.Drawing.Color.White;
            this._cashReset.Image = global::PlayBoxMonitor.Properties.Resources.money_cash__2_;
            this._cashReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._cashReset.Location = new System.Drawing.Point(7, 198);
            this._cashReset.Name = "_cashReset";
            this._cashReset.Size = new System.Drawing.Size(234, 40);
            this._cashReset.TabIndex = 2;
            this._cashReset.Text = "CASH";
            this._cashReset.UseVisualStyleBackColor = true;
            // 
            // _startStop
            // 
            this._startStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._startStop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._startStop.ForeColor = System.Drawing.Color.White;
            this._startStop.Location = new System.Drawing.Point(7, 157);
            this._startStop.Name = "_startStop";
            this._startStop.Size = new System.Drawing.Size(234, 40);
            this._startStop.TabIndex = 1;
            this._startStop.Text = "START";
            this._startStop.UseVisualStyleBackColor = true;
            // 
            // GameConsole
            // 
            this.AllowDrop = true;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(248, 242);
            this.Text = "Game Console:";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.GameConsoleControl_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameConsoleControl_DragEnter);
            this.DragLeave += new System.EventHandler(this.GameConsoleControl_DragLeave);
            this.Enter += new System.EventHandler(this.GameConsoleControl_MouseHover);
            this.Leave += new System.EventHandler(this.GameConsoleControl_MouseLeave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameConsoleControl_MouseDown);
            this.MouseEnter += new System.EventHandler(this.GameConsoleControl_MouseHover);
            this.MouseLeave += new System.EventHandler(this.GameConsoleControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.GameConsoleControl_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this._extraControlsDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Label _totalConsumptionLabel;
        private System.Windows.Forms.Label _timeLabel;
        private System.Windows.Forms.Label _extraControlsLabel;
        private System.Windows.Forms.TextBox _timeDisplay;
        private System.Windows.Forms.NumericUpDown _extraControlsDisplay;
        private System.Windows.Forms.TextBox _consumptionDisplay;
        private System.Windows.Forms.Button _cashReset;
        private System.Windows.Forms.Button _startStop;
        private System.Windows.Forms.Label _nameLabel;
    }
}
