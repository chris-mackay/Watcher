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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Watcher
{
    public partial class MainForm : Form
    {
        List<DirectoryModel> directoryModels;
        MainForm mainForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            directoryModels = new List<DirectoryModel>();
            mainForm = this;
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            notifyIcon.Icon = Properties.Resources.Watcher;
            notifyIcon.Text = "Watcher";
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "File added";
            notifyIcon.BalloonTipText = e.FullPath;
            notifyIcon.ShowBalloonTip(1000);

            logListbox.Items.Add($"File added : {DateTime.Now} : {e.FullPath}");
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            notifyIcon.Icon = Properties.Resources.Watcher;
            notifyIcon.Text = "Watcher";
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "File deleted";
            notifyIcon.BalloonTipText = e.FullPath;
            notifyIcon.ShowBalloonTip(1000);

            logListbox.Items.Add($"File deleted : {DateTime.Now} : {e.FullPath}");
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
            CommonOpenFileDialog ofd = new CommonOpenFileDialog();
            ofd.DefaultDirectory = "C:\\";
            ofd.Title = "Navigate to the directory to add it to the watcher";
            ofd.IsFolderPicker = true;

            if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DirectoryModel model = new DirectoryModel();
                model.IsActivated = false;
                model.IsChecked = false;
                model.Path = ofd.FileName;

                directoryModels.Add(model);

                dg.DataSource = null;
                dg.DataSource = directoryModels;
            }
        }

        private void btnRemoveDirectory_Click(object sender, EventArgs e)
        {

        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            List<DirectoryModel> models = (List<DirectoryModel>)mainForm.dg.DataSource;

            foreach (DirectoryModel model in models)
            {
                if (model.IsChecked && model.IsActivated == false)
                {
                    var watcher = new FileSystemWatcher(model.Path);
                    watcher.Created += OnCreated;
                    watcher.Deleted += OnDeleted;

                    watcher.NotifyFilter = NotifyFilters.FileName;
                    watcher.Filter = "";
                    watcher.IncludeSubdirectories = true;
                    watcher.EnableRaisingEvents = true;

                    watcher.SynchronizingObject = this;

                    model.IsActivated = true;
                } 
            }
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

    class DirectoryModel
    {
        public bool IsChecked { get; set; }
        public bool IsActivated { get; set; }
        public string Path { get; set; }
    }
}
