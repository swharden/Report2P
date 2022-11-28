using System.Diagnostics;

namespace Report2P.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblProgress1.Text = "";
            lblProgress2.Text = "";
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string folderPath = Path.GetFullPath(tbFolderPath.Text);

            string subfolder2p = Path.Combine(folderPath, "2p");
            cb2pFolder.Checked = Directory.Exists(subfolder2p);

            string subfolderabfs = Path.Combine(folderPath, "abfs");
            cbAbfsFolder.Checked = Directory.Exists(subfolderabfs);

            string experimentFile = Path.Combine(folderPath, "experiment.txt");
            cbExperimentFile.Checked = File.Exists(experimentFile);

            gbReport.Enabled = cb2pFolder.Checked && cbAbfsFolder.Checked && cbExperimentFile.Checked;

            string htmlFilePath = Path.Combine(folderPath, "2p/index.html");
            btnLaunch.Enabled = File.Exists(htmlFilePath);
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            string htmlFilePath = Path.GetFullPath(tbFolderPath.Text + "/2p/index.html");

            ProcessStartInfo psi = new(htmlFilePath) { UseShellExecute = true };
            Process p = new() { StartInfo = psi };
            p.Start();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string folderPath = Path.GetFullPath(tbFolderPath.Text);
            string subfolder2p = Path.Combine(folderPath, "2p");
            string[] twoPhotonFolderPaths = Directory.GetDirectories(subfolder2p);

            pbProgress.Value = 0;
            pbProgress.Maximum = twoPhotonFolderPaths.Length;

            for (int i = 0; i < twoPhotonFolderPaths.Length; i++)
            {
                pbProgress.Value = i + 1;
                lblProgress1.Text = $"Analyzing {i + 1} of {twoPhotonFolderPaths.Length}";
                lblProgress2.Text = Path.GetFileName(twoPhotonFolderPaths[i]);
                Application.DoEvents();
                Report2P.Analysis.AnalyzeFolder(twoPhotonFolderPaths[i], true);
            }

            lblProgress1.Text = $"Analysis complete";
            lblProgress2.Text = "Generating report...";
            Application.DoEvents();
            TimelinePage.MakeIndex(subfolder2p);

            pbProgress.Value = 0;
            lblProgress2.Text = "Report generated";
            btnScan_Click(this, EventArgs.Empty);
        }
    }
}