namespace Kanpeki_Scan
{
    partial class Form1
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnScan = new System.Windows.Forms.Button();
            this.lblScanSources = new System.Windows.Forms.Label();
            this.cmbScanSouces = new System.Windows.Forms.ComboBox();
            this.lvwPages = new System.Windows.Forms.ListView();
            this.colContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgListLarge = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOutputFileType = new System.Windows.Forms.Label();
            this.cmbOutputFileType = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTargetDirectory = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmsSetLanguage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuChangeLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportLanguageFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportEmptyLanguageFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuChangeDPI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetDPI150 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetDPI200 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetDPI250 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetDPI300 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmsSetLanguage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Location = new System.Drawing.Point(373, 38);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblScanSources
            // 
            this.lblScanSources.AutoSize = true;
            this.lblScanSources.Location = new System.Drawing.Point(12, 24);
            this.lblScanSources.Name = "lblScanSources";
            this.lblScanSources.Size = new System.Drawing.Size(74, 13);
            this.lblScanSources.TabIndex = 1;
            this.lblScanSources.Text = "Scan Sources";
            // 
            // cmbScanSouces
            // 
            this.cmbScanSouces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbScanSouces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScanSouces.FormattingEnabled = true;
            this.cmbScanSouces.Location = new System.Drawing.Point(15, 40);
            this.cmbScanSouces.Name = "cmbScanSouces";
            this.cmbScanSouces.Size = new System.Drawing.Size(352, 21);
            this.cmbScanSouces.TabIndex = 2;
            this.cmbScanSouces.SelectedIndexChanged += new System.EventHandler(this.cmbScanSouces_SelectedIndexChanged);
            // 
            // lvwPages
            // 
            this.lvwPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colContent});
            this.lvwPages.LargeImageList = this.imgListLarge;
            this.lvwPages.Location = new System.Drawing.Point(15, 67);
            this.lvwPages.Name = "lvwPages";
            this.lvwPages.Size = new System.Drawing.Size(427, 120);
            this.lvwPages.TabIndex = 3;
            this.lvwPages.UseCompatibleStateImageBehavior = false;
            this.lvwPages.SelectedIndexChanged += new System.EventHandler(this.lvwPages_SelectedIndexChanged);
            this.lvwPages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwPages_KeyDown);
            // 
            // imgListLarge
            // 
            this.imgListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListLarge.ImageSize = new System.Drawing.Size(200, 256);
            this.imgListLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(349, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOutputFileType
            // 
            this.lblOutputFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOutputFileType.AutoSize = true;
            this.lblOutputFileType.Location = new System.Drawing.Point(12, 190);
            this.lblOutputFileType.Name = "lblOutputFileType";
            this.lblOutputFileType.Size = new System.Drawing.Size(85, 13);
            this.lblOutputFileType.TabIndex = 5;
            this.lblOutputFileType.Text = "Output File Type";
            // 
            // cmbOutputFileType
            // 
            this.cmbOutputFileType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOutputFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutputFileType.FormattingEnabled = true;
            this.cmbOutputFileType.Location = new System.Drawing.Point(15, 206);
            this.cmbOutputFileType.Name = "cmbOutputFileType";
            this.cmbOutputFileType.Size = new System.Drawing.Size(427, 21);
            this.cmbOutputFileType.TabIndex = 6;
            this.cmbOutputFileType.SelectedIndexChanged += new System.EventHandler(this.cmbOutputFileType_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 267);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(15, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTargetDirectory
            // 
            this.lblTargetDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTargetDirectory.AutoSize = true;
            this.lblTargetDirectory.Location = new System.Drawing.Point(12, 230);
            this.lblTargetDirectory.Name = "lblTargetDirectory";
            this.lblTargetDirectory.Size = new System.Drawing.Size(83, 13);
            this.lblTargetDirectory.TabIndex = 7;
            this.lblTargetDirectory.Text = "Target Directory";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(349, 242);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(93, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cmsSetLanguage
            // 
            this.cmsSetLanguage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChangeLanguage});
            this.cmsSetLanguage.Name = "cmsSetLanguage";
            this.cmsSetLanguage.Size = new System.Drawing.Size(171, 26);
            // 
            // mnuChangeLanguage
            // 
            this.mnuChangeLanguage.Name = "mnuChangeLanguage";
            this.mnuChangeLanguage.Size = new System.Drawing.Size(170, 22);
            this.mnuChangeLanguage.Text = "Change Language";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTools,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImportLanguageFile,
            this.mnuExportEmptyLanguageFile,
            this.toolStripMenuItem1,
            this.mnuChangeDPI});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(48, 20);
            this.mnuTools.Text = "&Tools";
            // 
            // mnuImportLanguageFile
            // 
            this.mnuImportLanguageFile.Name = "mnuImportLanguageFile";
            this.mnuImportLanguageFile.Size = new System.Drawing.Size(227, 22);
            this.mnuImportLanguageFile.Text = "Import Language file...";
            this.mnuImportLanguageFile.Click += new System.EventHandler(this.mnuImportLanguageFile_Click);
            // 
            // mnuExportEmptyLanguageFile
            // 
            this.mnuExportEmptyLanguageFile.Name = "mnuExportEmptyLanguageFile";
            this.mnuExportEmptyLanguageFile.Size = new System.Drawing.Size(227, 22);
            this.mnuExportEmptyLanguageFile.Text = "&Export empty Language file...";
            this.mnuExportEmptyLanguageFile.Click += new System.EventHandler(this.mnuExportEmptyLanguageFile_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 6);
            // 
            // mnuChangeDPI
            // 
            this.mnuChangeDPI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetDPI150,
            this.mnuSetDPI200,
            this.mnuSetDPI250,
            this.mnuSetDPI300});
            this.mnuChangeDPI.Name = "mnuChangeDPI";
            this.mnuChangeDPI.Size = new System.Drawing.Size(227, 22);
            this.mnuChangeDPI.Text = "Change &DPI...";
            // 
            // mnuSetDPI150
            // 
            this.mnuSetDPI150.Name = "mnuSetDPI150";
            this.mnuSetDPI150.Size = new System.Drawing.Size(92, 22);
            this.mnuSetDPI150.Tag = "150";
            this.mnuSetDPI150.Text = "150";
            this.mnuSetDPI150.Click += new System.EventHandler(this.mnuSetDPI_Click);
            // 
            // mnuSetDPI200
            // 
            this.mnuSetDPI200.Name = "mnuSetDPI200";
            this.mnuSetDPI200.Size = new System.Drawing.Size(92, 22);
            this.mnuSetDPI200.Tag = "200";
            this.mnuSetDPI200.Text = "200";
            this.mnuSetDPI200.Click += new System.EventHandler(this.mnuSetDPI_Click);
            // 
            // mnuSetDPI250
            // 
            this.mnuSetDPI250.Name = "mnuSetDPI250";
            this.mnuSetDPI250.Size = new System.Drawing.Size(92, 22);
            this.mnuSetDPI250.Tag = "250";
            this.mnuSetDPI250.Text = "250";
            this.mnuSetDPI250.Click += new System.EventHandler(this.mnuSetDPI_Click);
            // 
            // mnuSetDPI300
            // 
            this.mnuSetDPI300.Name = "mnuSetDPI300";
            this.mnuSetDPI300.Size = new System.Drawing.Size(92, 22);
            this.mnuSetDPI300.Tag = "300";
            this.mnuSetDPI300.Text = "300";
            this.mnuSetDPI300.Click += new System.EventHandler(this.mnuSetDPI_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuAbout.Text = "&About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTargetDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtTargetDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Kanpeki_Scan.Properties.Settings.Default, "LastTargetDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTargetDirectory.Location = new System.Drawing.Point(12, 244);
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(331, 20);
            this.txtTargetDirectory.TabIndex = 8;
            this.txtTargetDirectory.Text = global::Kanpeki_Scan.Properties.Settings.Default.LastTargetDirectory;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Kanpeki_Scan.Properties.Settings.Default, "LastDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDescription.Location = new System.Drawing.Point(15, 283);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(427, 20);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Text = global::Kanpeki_Scan.Properties.Settings.Default.LastDescription;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 344);
            this.ContextMenuStrip = this.cmsSetLanguage;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtTargetDirectory);
            this.Controls.Add(this.lblTargetDirectory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbOutputFileType);
            this.Controls.Add(this.lblOutputFileType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lvwPages);
            this.Controls.Add(this.cmbScanSouces);
            this.Controls.Add(this.lblScanSources);
            this.Controls.Add(this.btnScan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(475, 382);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kanpeki Scan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.cmsSetLanguage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label lblScanSources;
        private System.Windows.Forms.ComboBox cmbScanSouces;
        private System.Windows.Forms.ListView lvwPages;
        private System.Windows.Forms.ColumnHeader colContent;
        private System.Windows.Forms.ImageList imgListLarge;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOutputFileType;
        private System.Windows.Forms.ComboBox cmbOutputFileType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTargetDirectory;
        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ContextMenuStrip cmsSetLanguage;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuImportLanguageFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExportEmptyLanguageFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeDPI;
        private System.Windows.Forms.ToolStripMenuItem mnuSetDPI150;
        private System.Windows.Forms.ToolStripMenuItem mnuSetDPI200;
        private System.Windows.Forms.ToolStripMenuItem mnuSetDPI250;
        private System.Windows.Forms.ToolStripMenuItem mnuSetDPI300;
    }
}

