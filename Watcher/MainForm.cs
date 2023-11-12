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
        List<LogEntryModel> logEntryModels;
        MainForm mainForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            directoryModels = new List<DirectoryModel>();
            logEntryModels = new List<LogEntryModel>();
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

            LogEntryModel logEntry = new LogEntryModel();
            logEntry.Alert = "Added";
            logEntry.EntryTime = DateTime.Now;
            logEntry.FilePath = e.FullPath;

            logEntryModels.Add(logEntry);
            dgLog.DataSource = null;
            dgLog.DataSource = logEntryModels;
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            notifyIcon.Icon = Properties.Resources.Watcher;
            notifyIcon.Text = "Watcher";
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "File deleted";
            notifyIcon.BalloonTipText = e.FullPath;
            notifyIcon.ShowBalloonTip(1000);

            LogEntryModel logEntry = new LogEntryModel();
            logEntry.Alert = "Deleted";
            logEntry.EntryTime = DateTime.Now;
            logEntry.FilePath = e.FullPath;

            logEntryModels.Add(logEntry);
            dgLog.DataSource = null;
            dgLog.DataSource = logEntryModels;
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

                dgDirectories.DataSource = null;
                dgDirectories.DataSource = directoryModels;
            }
        }

        private void btnRemoveDirectory_Click(object sender, EventArgs e)
        {

        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            List<DirectoryModel> models = (List<DirectoryModel>)mainForm.dgDirectories.DataSource;

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

            TaskDialog td = new TaskDialog();
            td.Caption = "Watcher";
            td.InstructionText = "Directories added to Watcher";
            td.Show();
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

    class LogEntryModel
    {
        public string Alert { get; set; }
        public DateTime EntryTime { get; set; }
        public string FilePath { get; set; }
    }

    class DirectoryModel
    {
        public bool IsChecked { get; set; }
        public bool IsActivated { get; set; }
        public string Path { get; set; }
    }
}
