using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watcher
{
    class DirectoryModel
    {
        public bool IsChecked { get; set; }
        public bool IsActivated { get; set; }
        public string Path { get; set; }
    }

    public partial class MainForm : Form
    {
        List<DirectoryModel> directoryModels;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            directoryModels = new List<DirectoryModel>();

            //var watcher = new FileSystemWatcher(@"C:\Users\Cmack\Desktop");
            //watcher.Created += OnCreated;

            //watcher.NotifyFilter = NotifyFilters.FileName;
            //watcher.Filter = "";
            //watcher.IncludeSubdirectories = true;
            //watcher.EnableRaisingEvents = true;

            //watcher.SynchronizingObject = this;
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            notifyIcon.Icon = Properties.Resources.Watcher;
            notifyIcon.Text = "Watcher";
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "File added";
            notifyIcon.BalloonTipText = e.FullPath;
            notifyIcon.ShowBalloonTip(1000);

            logListbox.Items.Add($"File added : {e.FullPath}");
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void btnAddDirectory_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveDirectory_Click(object sender, EventArgs e)
        {

        }

        private void btnActivate_Click(object sender, EventArgs e)
        {

        }

        private void btnExportLog_Click(object sender, EventArgs e)
        {

        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
