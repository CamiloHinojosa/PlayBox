namespace PlayBoxMonitor
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this._autoSaveTimer = new System.Windows.Forms.Timer(this.components);
            this._save = new System.Windows.Forms.Button();
            this._removeConsole = new System.Windows.Forms.Button();
            this._removeAllConsoles = new System.Windows.Forms.Button();
            this._addConsole = new System.Windows.Forms.Button();
            this._editConsole = new System.Windows.Forms.Button();
            this._menuBar = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._reportsOpenToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._reportsOpenCurrentToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openReportViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteCLSExRToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteCLINxRToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteCOSExRToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteAllToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this._mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._consolesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this._topButtonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._statusFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._menuBar.SuspendLayout();
            this._mainLayoutPanel.SuspendLayout();
            this._topButtonsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _autoSaveTimer
            // 
            this._autoSaveTimer.Interval = 1000;
            this._autoSaveTimer.Tick += new System.EventHandler(this._autoSaveTimer_Tick);
            // 
            // _save
            // 
            this._save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._save.AutoSize = true;
            this._save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this._save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this._save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._save.ForeColor = System.Drawing.Color.White;
            this._save.Image = global::PlayBoxMonitor.Properties.Resources.save__2_;
            this._save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._save.Location = new System.Drawing.Point(1096, 3);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(93, 48);
            this._save.TabIndex = 3;
            this._save.Tag = "CS";
            this._save.Text = "SAVE";
            this._save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this._save.UseVisualStyleBackColor = false;
            this._save.Click += new System.EventHandler(this._save_Click);
            // 
            // _removeConsole
            // 
            this._removeConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._removeConsole.AutoSize = true;
            this._removeConsole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._removeConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this._removeConsole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._removeConsole.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this._removeConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._removeConsole.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._removeConsole.ForeColor = System.Drawing.Color.White;
            this._removeConsole.Image = global::PlayBoxMonitor.Properties.Resources.delete_quittt__6_;
            this._removeConsole.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._removeConsole.Location = new System.Drawing.Point(167, 3);
            this._removeConsole.Name = "_removeConsole";
            this._removeConsole.Size = new System.Drawing.Size(191, 48);
            this._removeConsole.TabIndex = 1;
            this._removeConsole.Tag = "CS";
            this._removeConsole.Text = "Remove Console";
            this._removeConsole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._removeConsole.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this._removeConsole.UseVisualStyleBackColor = false;
            this._removeConsole.Click += new System.EventHandler(this._removeConsole_Click);
            // 
            // _removeAllConsoles
            // 
            this._removeAllConsoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._removeAllConsoles.AutoSize = true;
            this._removeAllConsoles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._removeAllConsoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this._removeAllConsoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._removeAllConsoles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this._removeAllConsoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._removeAllConsoles.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._removeAllConsoles.ForeColor = System.Drawing.Color.White;
            this._removeAllConsoles.Image = global::PlayBoxMonitor.Properties.Resources.delete_minus8__3_;
            this._removeAllConsoles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._removeAllConsoles.Location = new System.Drawing.Point(1195, 3);
            this._removeAllConsoles.Name = "_removeAllConsoles";
            this._removeAllConsoles.Size = new System.Drawing.Size(226, 48);
            this._removeAllConsoles.TabIndex = 4;
            this._removeAllConsoles.Tag = "CS";
            this._removeAllConsoles.Text = "Remove All Consoles";
            this._removeAllConsoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._removeAllConsoles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this._removeAllConsoles.UseVisualStyleBackColor = false;
            this._removeAllConsoles.Click += new System.EventHandler(this._removeAllConsoles_Click);
            // 
            // _addConsole
            // 
            this._addConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._addConsole.AutoSize = true;
            this._addConsole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._addConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this._addConsole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._addConsole.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this._addConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addConsole.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addConsole.ForeColor = System.Drawing.Color.White;
            this._addConsole.Image = global::PlayBoxMonitor.Properties.Resources.add_plus__5_1;
            this._addConsole.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._addConsole.Location = new System.Drawing.Point(3, 3);
            this._addConsole.Name = "_addConsole";
            this._addConsole.Size = new System.Drawing.Size(158, 48);
            this._addConsole.TabIndex = 0;
            this._addConsole.Tag = "CS";
            this._addConsole.Text = "Add Console";
            this._addConsole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._addConsole.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this._addConsole.UseVisualStyleBackColor = false;
            this._addConsole.Click += new System.EventHandler(this._addConsole_Click);
            // 
            // _editConsole
            // 
            this._editConsole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._editConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this._editConsole.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this._editConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._editConsole.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._editConsole.ForeColor = System.Drawing.Color.White;
            this._editConsole.Image = global::PlayBoxMonitor.Properties.Resources.edit__3_;
            this._editConsole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._editConsole.Location = new System.Drawing.Point(3, 57);
            this._editConsole.Name = "_editConsole";
            this._editConsole.Size = new System.Drawing.Size(91, 56);
            this._editConsole.TabIndex = 2;
            this._editConsole.Tag = "CS";
            this._editConsole.Text = "Edit Console";
            this._editConsole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._editConsole.UseVisualStyleBackColor = false;
            this._editConsole.Click += new System.EventHandler(this._editConsole_Click);
            // 
            // _menuBar
            // 
            this._menuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._menuBar.AutoSize = false;
            this._menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this._menuBar.BackgroundImage = global::PlayBoxMonitor.Properties.Resources.MBlogo01XO;
            this._menuBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._menuBar.Dock = System.Windows.Forms.DockStyle.None;
            this._menuBar.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this._helpToolStripMenuItem});
            this._menuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this._menuBar.Location = new System.Drawing.Point(0, 0);
            this._menuBar.Name = "_menuBar";
            this._menuBar.ShowItemToolTips = true;
            this._menuBar.Size = new System.Drawing.Size(1582, 72);
            this._menuBar.TabIndex = 8;
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.AutoSize = false;
            this.toolsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(117, 68);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.Image = global::PlayBoxMonitor.Properties.Resources.tools;
            this.optionsToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(187, 40);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // _settingsToolStripMenuItem
            // 
            this._settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this._settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this._settingsToolStripMenuItem.Image = global::PlayBoxMonitor.Properties.Resources.other;
            this._settingsToolStripMenuItem.Name = "_settingsToolStripMenuItem";
            this._settingsToolStripMenuItem.Size = new System.Drawing.Size(186, 40);
            this._settingsToolStripMenuItem.Text = "Settings";
            this._settingsToolStripMenuItem.Click += new System.EventHandler(this._settingsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._reportsOpenToolStrip,
            this._reportsOpenCurrentToolStrip,
            this.openReportViewerToolStripMenuItem,
            this._deleteToolStrip});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportsToolStripMenuItem.Image = global::PlayBoxMonitor.Properties.Resources.test_chemistry_tube_lab_experiment_science_128;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(187, 40);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // _reportsOpenToolStrip
            // 
            this._reportsOpenToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this._reportsOpenToolStrip.ForeColor = System.Drawing.Color.White;
            this._reportsOpenToolStrip.Image = global::PlayBoxMonitor.Properties.Resources.report_3_xxl;
            this._reportsOpenToolStrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._reportsOpenToolStrip.Name = "_reportsOpenToolStrip";
            this._reportsOpenToolStrip.Size = new System.Drawing.Size(456, 40);
            this._reportsOpenToolStrip.Tag = "open";
            this._reportsOpenToolStrip.Text = "Open Report";
            this._reportsOpenToolStrip.Click += new System.EventHandler(this._reportsOpenToolStrip_Click);
            // 
            // _reportsOpenCurrentToolStrip
            // 
            this._reportsOpenCurrentToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this._reportsOpenCurrentToolStrip.ForeColor = System.Drawing.Color.White;
            this._reportsOpenCurrentToolStrip.Image = global::PlayBoxMonitor.Properties.Resources.a2;
            this._reportsOpenCurrentToolStrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._reportsOpenCurrentToolStrip.Name = "_reportsOpenCurrentToolStrip";
            this._reportsOpenCurrentToolStrip.Size = new System.Drawing.Size(456, 40);
            this._reportsOpenCurrentToolStrip.Tag = "opencurrent";
            this._reportsOpenCurrentToolStrip.Text = "Open Client Information Report";
            this._reportsOpenCurrentToolStrip.Click += new System.EventHandler(this._reportsOpenToolStrip_Click);
            // 
            // openReportViewerToolStripMenuItem
            // 
            this.openReportViewerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.openReportViewerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openReportViewerToolStripMenuItem.Image = global::PlayBoxMonitor.Properties.Resources.MBlog01Icon;
            this.openReportViewerToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openReportViewerToolStripMenuItem.Name = "openReportViewerToolStripMenuItem";
            this.openReportViewerToolStripMenuItem.Size = new System.Drawing.Size(456, 40);
            this.openReportViewerToolStripMenuItem.Tag = "openreportviewer";
            this.openReportViewerToolStripMenuItem.Text = "Open Report Viewer";
            this.openReportViewerToolStripMenuItem.Click += new System.EventHandler(this._reportsOpenToolStrip_Click);
            // 
            // _deleteToolStrip
            // 
            this._deleteToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this._deleteToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._deleteCLSExRToolStrip,
            this._deleteCLINxRToolStrip,
            this._deleteCOSExRToolStrip,
            this._deleteAllToolStrip});
            this._deleteToolStrip.ForeColor = System.Drawing.Color.White;
            this._deleteToolStrip.Image = global::PlayBoxMonitor.Properties.Resources.delete_minus8__3_1;
            this._deleteToolStrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._deleteToolStrip.Name = "_deleteToolStrip";
            this._deleteToolStrip.Size = new System.Drawing.Size(456, 40);
            this._deleteToolStrip.Text = "Delete";
            // 
            // _deleteCLSExRToolStrip
            // 
            this._deleteCLSExRToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this._deleteCLSExRToolStrip.ForeColor = System.Drawing.Color.White;
            this._deleteCLSExRToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("_deleteCLSExRToolStrip.Image")));
            this._deleteCLSExRToolStrip.Name = "_deleteCLSExRToolStrip";
            this._deleteCLSExRToolStrip.Size = new System.Drawing.Size(467, 40);
            this._deleteCLSExRToolStrip.Text = "Delete Client Session Reports";
            // 
            // _deleteCLINxRToolStrip
            // 
            this._deleteCLINxRToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this._deleteCLINxRToolStrip.ForeColor = System.Drawing.Color.White;
            this._deleteCLINxRToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("_deleteCLINxRToolStrip.Image")));
            this._deleteCLINxRToolStrip.Name = "_deleteCLINxRToolStrip";
            this._deleteCLINxRToolStrip.Size = new System.Drawing.Size(467, 40);
            this._deleteCLINxRToolStrip.Text = "Delete Client Information Report";
            this._deleteCLINxRToolStrip.Click += new System.EventHandler(this._deleteCLINxRToolStrip_Click);
            // 
            // _deleteCOSExRToolStrip
            // 
            this._deleteCOSExRToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this._deleteCOSExRToolStrip.ForeColor = System.Drawing.Color.White;
            this._deleteCOSExRToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("_deleteCOSExRToolStrip.Image")));
            this._deleteCOSExRToolStrip.Name = "_deleteCOSExRToolStrip";
            this._deleteCOSExRToolStrip.Size = new System.Drawing.Size(467, 40);
            this._deleteCOSExRToolStrip.Text = "Delete Console Session Reports";
            this._deleteCOSExRToolStrip.Click += new System.EventHandler(this._deleteCOSExRToolStrip_Click);
            // 
            // _deleteAllToolStrip
            // 
            this._deleteAllToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this._deleteAllToolStrip.ForeColor = System.Drawing.Color.White;
            this._deleteAllToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("_deleteAllToolStrip.Image")));
            this._deleteAllToolStrip.Name = "_deleteAllToolStrip";
            this._deleteAllToolStrip.Size = new System.Drawing.Size(467, 40);
            this._deleteAllToolStrip.Text = "Delete All Reports";
            this._deleteAllToolStrip.Click += new System.EventHandler(this._deleteAllToolStrip_Click);
            // 
            // _helpToolStripMenuItem
            // 
            this._helpToolStripMenuItem.AutoSize = false;
            this._helpToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this._helpToolStripMenuItem.Name = "_helpToolStripMenuItem";
            this._helpToolStripMenuItem.Size = new System.Drawing.Size(117, 68);
            this._helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // optionsToolStripMenuItem2
            // 
            this.optionsToolStripMenuItem2.Name = "optionsToolStripMenuItem2";
            this.optionsToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 6);
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // _mainLayoutPanel
            // 
            this._mainLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._mainLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._mainLayoutPanel.ColumnCount = 3;
            this._mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.11712F));
            this._mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.8404F));
            this._mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.042484F));
            this._mainLayoutPanel.Controls.Add(this._consolesContainer, 1, 1);
            this._mainLayoutPanel.Controls.Add(this._topButtonsLayoutPanel, 1, 0);
            this._mainLayoutPanel.Controls.Add(this._statusFlowPanel, 1, 2);
            this._mainLayoutPanel.Controls.Add(this._editConsole, 0, 1);
            this._mainLayoutPanel.Location = new System.Drawing.Point(0, 72);
            this._mainLayoutPanel.Name = "_mainLayoutPanel";
            this._mainLayoutPanel.RowCount = 3;
            this._mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.964277F));
            this._mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.0512F));
            this._mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.984524F));
            this._mainLayoutPanel.Size = new System.Drawing.Size(1586, 782);
            this._mainLayoutPanel.TabIndex = 13;
            // 
            // _consolesContainer
            // 
            this._consolesContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._consolesContainer.AutoScroll = true;
            this._consolesContainer.AutoSize = true;
            this._consolesContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._consolesContainer.BackColor = System.Drawing.Color.White;
            this._consolesContainer.BackgroundImage = global::PlayBoxMonitor.Properties.Resources.PBlog01;
            this._consolesContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._consolesContainer.Location = new System.Drawing.Point(97, 54);
            this._consolesContainer.Margin = new System.Windows.Forms.Padding(0);
            this._consolesContainer.Name = "_consolesContainer";
            this._consolesContainer.Padding = new System.Windows.Forms.Padding(140, 40, 40, 40);
            this._consolesContainer.Size = new System.Drawing.Size(1424, 672);
            this._consolesContainer.TabIndex = 5;
            this._consolesContainer.Paint += new System.Windows.Forms.PaintEventHandler(this._consolesContainer_Paint);
            // 
            // _topButtonsLayoutPanel
            // 
            this._topButtonsLayoutPanel.AutoSize = true;
            this._topButtonsLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._topButtonsLayoutPanel.ColumnCount = 5;
            this._topButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._topButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._topButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._topButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._topButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._topButtonsLayoutPanel.Controls.Add(this._removeConsole, 1, 0);
            this._topButtonsLayoutPanel.Controls.Add(this._addConsole, 0, 0);
            this._topButtonsLayoutPanel.Controls.Add(this._removeAllConsoles, 4, 0);
            this._topButtonsLayoutPanel.Controls.Add(this._save, 3, 0);
            this._topButtonsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._topButtonsLayoutPanel.Location = new System.Drawing.Point(97, 0);
            this._topButtonsLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._topButtonsLayoutPanel.Name = "_topButtonsLayoutPanel";
            this._topButtonsLayoutPanel.RowCount = 1;
            this._topButtonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._topButtonsLayoutPanel.Size = new System.Drawing.Size(1424, 54);
            this._topButtonsLayoutPanel.TabIndex = 11;
            // 
            // _statusFlowPanel
            // 
            this._statusFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._statusFlowPanel.AutoSize = true;
            this._statusFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._statusFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this._statusFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this._statusFlowPanel.Location = new System.Drawing.Point(97, 726);
            this._statusFlowPanel.Margin = new System.Windows.Forms.Padding(0);
            this._statusFlowPanel.Name = "_statusFlowPanel";
            this._statusFlowPanel.Size = new System.Drawing.Size(1424, 56);
            this._statusFlowPanel.TabIndex = 17;
            // 
            // MainWindow
            // 
            this.AccessibleDescription = "MonkeyBytes - PlayBox Console Manager";
            this.AccessibleName = "PlayBox";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this._mainLayoutPanel);
            this.Controls.Add(this._menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._menuBar;
            this.MaximumSize = new System.Drawing.Size(3840, 2160);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonkeyBytes - Play Monitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this._menuBar.ResumeLayout(false);
            this._menuBar.PerformLayout();
            this._mainLayoutPanel.ResumeLayout(false);
            this._mainLayoutPanel.PerformLayout();
            this._topButtonsLayoutPanel.ResumeLayout(false);
            this._topButtonsLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _addConsole;
        private System.Windows.Forms.MenuStrip _menuBar;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _helpToolStripMenuItem;
        private System.Windows.Forms.Button _removeAllConsoles;
        private System.Windows.Forms.Button _removeConsole;
        private System.Windows.Forms.Button _editConsole;
        private System.Windows.Forms.Button _save;
        private System.Windows.Forms.Timer _autoSaveTimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _reportsOpenToolStrip;
        private System.Windows.Forms.ToolStripMenuItem _reportsOpenCurrentToolStrip;
        private System.Windows.Forms.ToolStripMenuItem openReportViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _deleteToolStrip;
        private System.Windows.Forms.ToolStripMenuItem _deleteCLSExRToolStrip;
        private System.Windows.Forms.ToolStripMenuItem _deleteCLINxRToolStrip;
        private System.Windows.Forms.ToolStripMenuItem _deleteCOSExRToolStrip;
        private System.Windows.Forms.TableLayoutPanel _mainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _topButtonsLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem _deleteAllToolStrip;
        private System.Windows.Forms.FlowLayoutPanel _statusFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel _consolesContainer;
    }
}

