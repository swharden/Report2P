namespace Report2P.GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.cb2pFolder = new System.Windows.Forms.CheckBox();
            this.cbAbfsFolder = new System.Windows.Forms.CheckBox();
            this.cbExperimentFile = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblExperimentFile = new System.Windows.Forms.Label();
            this.lblAbfsFolder = new System.Windows.Forms.Label();
            this.lbl2pFolder = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.cbReanalyze = new System.Windows.Forms.CheckBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gbProgress = new System.Windows.Forms.GroupBox();
            this.lblProgress1 = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbReport.SuspendLayout();
            this.gbProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFolderPath.Location = new System.Drawing.Point(96, 30);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(772, 31);
            this.tbFolderPath.TabIndex = 0;
            this.tbFolderPath.Text = "X:\\Data\\zProjects\\OT-Tom NMDA signaling\\Experiments\\2P uncaging\\2022-11-18";
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Location = new System.Drawing.Point(874, 25);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(112, 41);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cb2pFolder
            // 
            this.cb2pFolder.AutoSize = true;
            this.cb2pFolder.Enabled = false;
            this.cb2pFolder.Location = new System.Drawing.Point(12, 40);
            this.cb2pFolder.Name = "cb2pFolder";
            this.cb2pFolder.Size = new System.Drawing.Size(22, 21);
            this.cb2pFolder.TabIndex = 3;
            this.cb2pFolder.UseVisualStyleBackColor = true;
            // 
            // cbAbfsFolder
            // 
            this.cbAbfsFolder.AutoSize = true;
            this.cbAbfsFolder.Enabled = false;
            this.cbAbfsFolder.Location = new System.Drawing.Point(12, 80);
            this.cbAbfsFolder.Name = "cbAbfsFolder";
            this.cbAbfsFolder.Size = new System.Drawing.Size(22, 21);
            this.cbAbfsFolder.TabIndex = 4;
            this.cbAbfsFolder.UseVisualStyleBackColor = true;
            // 
            // cbExperimentFile
            // 
            this.cbExperimentFile.AutoSize = true;
            this.cbExperimentFile.Enabled = false;
            this.cbExperimentFile.Location = new System.Drawing.Point(12, 120);
            this.cbExperimentFile.Name = "cbExperimentFile";
            this.cbExperimentFile.Size = new System.Drawing.Size(22, 21);
            this.cbExperimentFile.TabIndex = 5;
            this.cbExperimentFile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblExperimentFile);
            this.groupBox1.Controls.Add(this.lblAbfsFolder);
            this.groupBox1.Controls.Add(this.lbl2pFolder);
            this.groupBox1.Controls.Add(this.cb2pFolder);
            this.groupBox1.Controls.Add(this.cbExperimentFile);
            this.groupBox1.Controls.Add(this.cbAbfsFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 174);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder Contents";
            // 
            // lblExperimentFile
            // 
            this.lblExperimentFile.AutoSize = true;
            this.lblExperimentFile.Location = new System.Drawing.Point(33, 117);
            this.lblExperimentFile.Name = "lblExperimentFile";
            this.lblExperimentFile.Size = new System.Drawing.Size(212, 25);
            this.lblExperimentFile.TabIndex = 6;
            this.lblExperimentFile.Text = "Contains \"experiment.txt\"";
            // 
            // lblAbfsFolder
            // 
            this.lblAbfsFolder.AutoSize = true;
            this.lblAbfsFolder.Location = new System.Drawing.Point(33, 77);
            this.lblAbfsFolder.Name = "lblAbfsFolder";
            this.lblAbfsFolder.Size = new System.Drawing.Size(215, 25);
            this.lblAbfsFolder.TabIndex = 6;
            this.lblAbfsFolder.Text = "Contains \"abfs\" subfolder";
            // 
            // lbl2pFolder
            // 
            this.lbl2pFolder.AutoSize = true;
            this.lbl2pFolder.Location = new System.Drawing.Point(33, 37);
            this.lbl2pFolder.Name = "lbl2pFolder";
            this.lbl2pFolder.Size = new System.Drawing.Size(202, 25);
            this.lbl2pFolder.TabIndex = 6;
            this.lbl2pFolder.Text = "Contains \"2p\" subfolder";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.tbFolderPath);
            this.groupBox2.Controls.Add(this.btnScan);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(998, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folder";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(6, 25);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(84, 41);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.cbReanalyze);
            this.gbReport.Controls.Add(this.btnLaunch);
            this.gbReport.Controls.Add(this.btnGenerate);
            this.gbReport.Enabled = false;
            this.gbReport.Location = new System.Drawing.Point(305, 96);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(140, 174);
            this.gbReport.TabIndex = 8;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Report";
            // 
            // cbReanalyze
            // 
            this.cbReanalyze.AutoSize = true;
            this.cbReanalyze.Location = new System.Drawing.Point(16, 83);
            this.cbReanalyze.Name = "cbReanalyze";
            this.cbReanalyze.Size = new System.Drawing.Size(111, 29);
            this.cbReanalyze.TabIndex = 5;
            this.cbReanalyze.Text = "reanalyze";
            this.cbReanalyze.UseVisualStyleBackColor = true;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(15, 118);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(112, 41);
            this.btnLaunch.TabIndex = 4;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(15, 36);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(112, 41);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Analyze";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // gbProgress
            // 
            this.gbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProgress.Controls.Add(this.lblProgress1);
            this.gbProgress.Controls.Add(this.pbProgress);
            this.gbProgress.Enabled = false;
            this.gbProgress.Location = new System.Drawing.Point(467, 96);
            this.gbProgress.Name = "gbProgress";
            this.gbProgress.Size = new System.Drawing.Size(543, 174);
            this.gbProgress.TabIndex = 11;
            this.gbProgress.TabStop = false;
            this.gbProgress.Text = "Progress";
            // 
            // lblProgress1
            // 
            this.lblProgress1.AutoSize = true;
            this.lblProgress1.Location = new System.Drawing.Point(13, 77);
            this.lblProgress1.Name = "lblProgress1";
            this.lblProgress1.Size = new System.Drawing.Size(59, 25);
            this.lblProgress1.TabIndex = 1;
            this.lblProgress1.Text = "label1";
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(13, 36);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(489, 34);
            this.pbProgress.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 281);
            this.Controls.Add(this.gbProgress);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report2P";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbReport.ResumeLayout(false);
            this.gbReport.PerformLayout();
            this.gbProgress.ResumeLayout(false);
            this.gbProgress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tbFolderPath;
        private Button btnScan;
        private CheckBox cb2pFolder;
        private CheckBox cbAbfsFolder;
        private CheckBox cbExperimentFile;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox gbReport;
        private Button btnLaunch;
        private Button btnGenerate;
        private GroupBox gbProgress;
        private ProgressBar pbProgress;
        private Label lblProgress1;
        private CheckBox cbReanalyze;
        private Button btnSelect;
        private Label lblExperimentFile;
        private Label lblAbfsFolder;
        private Label lbl2pFolder;
    }
}