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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblProgress1 = new System.Windows.Forms.Label();
            this.lblProgress2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbReport.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFolderPath.Location = new System.Drawing.Point(14, 30);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(713, 31);
            this.tbFolderPath.TabIndex = 0;
            this.tbFolderPath.Text = "X:/Data/zProjects/OT-Tom NMDA signaling/2P uncaging/2022-11-18";
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Location = new System.Drawing.Point(733, 25);
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
            this.cb2pFolder.Location = new System.Drawing.Point(12, 35);
            this.cb2pFolder.Name = "cb2pFolder";
            this.cb2pFolder.Size = new System.Drawing.Size(228, 29);
            this.cb2pFolder.TabIndex = 3;
            this.cb2pFolder.Text = "Contains \"2p\" subfolder";
            this.cb2pFolder.UseVisualStyleBackColor = true;
            // 
            // cbAbfsFolder
            // 
            this.cbAbfsFolder.AutoSize = true;
            this.cbAbfsFolder.Enabled = false;
            this.cbAbfsFolder.Location = new System.Drawing.Point(12, 70);
            this.cbAbfsFolder.Name = "cbAbfsFolder";
            this.cbAbfsFolder.Size = new System.Drawing.Size(241, 29);
            this.cbAbfsFolder.TabIndex = 4;
            this.cbAbfsFolder.Text = "Contains \"abfs\" subfolder";
            this.cbAbfsFolder.UseVisualStyleBackColor = true;
            // 
            // cbExperimentFile
            // 
            this.cbExperimentFile.AutoSize = true;
            this.cbExperimentFile.Enabled = false;
            this.cbExperimentFile.Location = new System.Drawing.Point(12, 105);
            this.cbExperimentFile.Name = "cbExperimentFile";
            this.cbExperimentFile.Size = new System.Drawing.Size(238, 29);
            this.cbExperimentFile.TabIndex = 5;
            this.cbExperimentFile.Text = "Contains \"experiment.txt\"";
            this.cbExperimentFile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb2pFolder);
            this.groupBox1.Controls.Add(this.cbExperimentFile);
            this.groupBox1.Controls.Add(this.cbAbfsFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder Contents";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbFolderPath);
            this.groupBox2.Controls.Add(this.btnScan);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(856, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folder";
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.btnLaunch);
            this.gbReport.Controls.Add(this.btnGenerate);
            this.gbReport.Enabled = false;
            this.gbReport.Location = new System.Drawing.Point(305, 96);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(140, 144);
            this.gbReport.TabIndex = 8;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Report";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(15, 87);
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
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblProgress2);
            this.groupBox3.Controls.Add(this.lblProgress1);
            this.groupBox3.Controls.Add(this.pbProgress);
            this.groupBox3.Location = new System.Drawing.Point(467, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 144);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Progress";
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(13, 36);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(377, 34);
            this.pbProgress.TabIndex = 0;
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
            // lblProgress2
            // 
            this.lblProgress2.AutoSize = true;
            this.lblProgress2.Location = new System.Drawing.Point(13, 105);
            this.lblProgress2.Name = "lblProgress2";
            this.lblProgress2.Size = new System.Drawing.Size(59, 25);
            this.lblProgress2.TabIndex = 2;
            this.lblProgress2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 252);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report2P";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbReport.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private GroupBox groupBox3;
        private ProgressBar pbProgress;
        private Label lblProgress2;
        private Label lblProgress1;
    }
}