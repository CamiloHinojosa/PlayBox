namespace PlayBoxInteractiveReportViewer
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
            this._mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._reportLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._treeViewLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._treeBTNPanel = new System.Windows.Forms.TableLayoutPanel();
            this._explorer = new System.Windows.Forms.TreeView();
            this._iconList = new System.Windows.Forms.ImageList(this.components);
            this._resetBTN = new System.Windows.Forms.Button();
            this._exportToExcelBTN = new System.Windows.Forms.Button();
            this._mainLayoutPanel.SuspendLayout();
            this._treeViewLayoutPanel.SuspendLayout();
            this._treeBTNPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainLayoutPanel
            // 
            this._mainLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._mainLayoutPanel.ColumnCount = 2;
            this._mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.45015F));
            this._mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.54985F));
            this._mainLayoutPanel.Controls.Add(this._reportLayoutPanel, 1, 0);
            this._mainLayoutPanel.Controls.Add(this._treeViewLayoutPanel, 0, 0);
            this._mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._mainLayoutPanel.Name = "_mainLayoutPanel";
            this._mainLayoutPanel.RowCount = 1;
            this._mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._mainLayoutPanel.Size = new System.Drawing.Size(1668, 774);
            this._mainLayoutPanel.TabIndex = 0;
            // 
            // _reportLayoutPanel
            // 
            this._reportLayoutPanel.AutoScroll = true;
            this._reportLayoutPanel.AutoSize = true;
            this._reportLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._reportLayoutPanel.ColumnCount = 1;
            this._reportLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._reportLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._reportLayoutPanel.Location = new System.Drawing.Point(357, 0);
            this._reportLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._reportLayoutPanel.Name = "_reportLayoutPanel";
            this._reportLayoutPanel.RowCount = 1;
            this._reportLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._reportLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 774F));
            this._reportLayoutPanel.Size = new System.Drawing.Size(1311, 774);
            this._reportLayoutPanel.TabIndex = 1;
            // 
            // _treeViewLayoutPanel
            // 
            this._treeViewLayoutPanel.ColumnCount = 1;
            this._treeViewLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._treeViewLayoutPanel.Controls.Add(this._treeBTNPanel, 0, 1);
            this._treeViewLayoutPanel.Controls.Add(this._explorer, 0, 0);
            this._treeViewLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeViewLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._treeViewLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._treeViewLayoutPanel.Name = "_treeViewLayoutPanel";
            this._treeViewLayoutPanel.RowCount = 2;
            this._treeViewLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this._treeViewLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._treeViewLayoutPanel.Size = new System.Drawing.Size(357, 774);
            this._treeViewLayoutPanel.TabIndex = 2;
            // 
            // _treeBTNPanel
            // 
            this._treeBTNPanel.AutoSize = true;
            this._treeBTNPanel.ColumnCount = 2;
            this._treeBTNPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.9944F));
            this._treeBTNPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0056F));
            this._treeBTNPanel.Controls.Add(this._resetBTN, 1, 0);
            this._treeBTNPanel.Controls.Add(this._exportToExcelBTN, 0, 0);
            this._treeBTNPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeBTNPanel.Location = new System.Drawing.Point(0, 735);
            this._treeBTNPanel.Margin = new System.Windows.Forms.Padding(0);
            this._treeBTNPanel.Name = "_treeBTNPanel";
            this._treeBTNPanel.RowCount = 1;
            this._treeBTNPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._treeBTNPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this._treeBTNPanel.Size = new System.Drawing.Size(357, 39);
            this._treeBTNPanel.TabIndex = 3;
            // 
            // _explorer
            // 
            this._explorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._explorer.BackColor = System.Drawing.Color.White;
            this._explorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._explorer.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._explorer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this._explorer.ImageIndex = 0;
            this._explorer.ImageList = this._iconList;
            this._explorer.Indent = 15;
            this._explorer.ItemHeight = 40;
            this._explorer.Location = new System.Drawing.Point(0, 0);
            this._explorer.Margin = new System.Windows.Forms.Padding(0);
            this._explorer.Name = "_explorer";
            this._explorer.SelectedImageIndex = 8;
            this._explorer.ShowLines = false;
            this._explorer.ShowPlusMinus = false;
            this._explorer.ShowRootLines = false;
            this._explorer.Size = new System.Drawing.Size(357, 735);
            this._explorer.TabIndex = 0;
            this._explorer.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._explorer_NodeMouseClick);
            this._explorer.KeyDown += new System.Windows.Forms.KeyEventHandler(this._explorer_KeyDown);
            // 
            // _iconList
            // 
            this._iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_iconList.ImageStream")));
            this._iconList.TransparentColor = System.Drawing.Color.Transparent;
            this._iconList.Images.SetKeyName(0, "game (2).png");
            this._iconList.Images.SetKeyName(1, "chart_bar_analystic_report-128.png");
            this._iconList.Images.SetKeyName(2, "a2.png");
            this._iconList.Images.SetKeyName(3, "1460201434_Folder_-_Open_256x256-32.png");
            this._iconList.Images.SetKeyName(4, "costomer-icon.ico");
            this._iconList.Images.SetKeyName(5, "sales_report_98405.jpg");
            this._iconList.Images.SetKeyName(6, "test_chemistry_tube_lab_experiment_science-128.png");
            this._iconList.Images.SetKeyName(7, "log_.log_file_file_format_document_extension_format-128.png");
            this._iconList.Images.SetKeyName(8, "Untitled-22-512.png");
            // 
            // _resetBTN
            // 
            this._resetBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._resetBTN.BackColor = System.Drawing.Color.Transparent;
            this._resetBTN.BackgroundImage = global::PlayBoxInteractiveReportViewer.Properties.Resources.Refresh_1288;
            this._resetBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._resetBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._resetBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this._resetBTN.FlatAppearance.BorderSize = 0;
            this._resetBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this._resetBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this._resetBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._resetBTN.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._resetBTN.ForeColor = System.Drawing.Color.White;
            this._resetBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._resetBTN.Location = new System.Drawing.Point(307, 0);
            this._resetBTN.Margin = new System.Windows.Forms.Padding(0);
            this._resetBTN.Name = "_resetBTN";
            this._resetBTN.Size = new System.Drawing.Size(50, 39);
            this._resetBTN.TabIndex = 2;
            this._resetBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._resetBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._resetBTN.UseVisualStyleBackColor = false;
            this._resetBTN.Click += new System.EventHandler(this._resetBTN_Click);
            // 
            // _exportToExcelBTN
            // 
            this._exportToExcelBTN.BackgroundImage = global::PlayBoxInteractiveReportViewer.Properties.Resources.microsoft_excel_icon2;
            this._exportToExcelBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._exportToExcelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._exportToExcelBTN.Location = new System.Drawing.Point(3, 3);
            this._exportToExcelBTN.Name = "_exportToExcelBTN";
            this._exportToExcelBTN.Size = new System.Drawing.Size(40, 33);
            this._exportToExcelBTN.TabIndex = 3;
            this._exportToExcelBTN.UseVisualStyleBackColor = true;
            this._exportToExcelBTN.Click += new System.EventHandler(this._exportToExcelBTN_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1668, 774);
            this.Controls.Add(this._mainLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            this.Text = "InteractiveViewer";
            this._mainLayoutPanel.ResumeLayout(false);
            this._mainLayoutPanel.PerformLayout();
            this._treeViewLayoutPanel.ResumeLayout(false);
            this._treeViewLayoutPanel.PerformLayout();
            this._treeBTNPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _reportLayoutPanel;
        private System.Windows.Forms.ImageList _iconList;
        private System.Windows.Forms.TableLayoutPanel _treeViewLayoutPanel;
        private System.Windows.Forms.TreeView _explorer;
        private System.Windows.Forms.TableLayoutPanel _treeBTNPanel;
        private System.Windows.Forms.Button _resetBTN;
        private System.Windows.Forms.Button _exportToExcelBTN;
    }
}