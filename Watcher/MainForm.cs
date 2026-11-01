using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Watcher
{
    public partial class MainForm : Form
    {
        BindingList<WatcherModel> watcherModels;
        BindingList<LogEntryModel> logEntryModels;
        MainForm mainForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            watcherModels = new BindingList<WatcherModel>();
            logEntryModels = new BindingList<LogEntryModel>();
            mainForm = this;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            bool showNotifications = cbxShowNofitifcations.Checked;
            FileSystemWatcher watcher = (FileSystemWatcher)sender;

            DateTime entryTime = DateTime.Now;
            string formattedEntryTime = entryTime.ToString("MM/dd/yyyy HH:mm:ss");

            LogEntryModel logEntry = new LogEntryModel();
            logEntry.EntryId = Guid.NewGuid();

            // TODO: Look up in the list of watcherModels and match the FileSystemWatcher with the sender watcher, so we can get the WatcherId
            foreach (WatcherModel watcherModel in watcherModels)
            {
                if (watcherModel.FileWatcher == watcher)
                {
                    logEntry.WatcherId = watcherModel.WatcherId;
                }
            }

            logEntry.Alert = e.ChangeType.ToString();
            logEntry.EntryTime = formattedEntryTime;
            logEntry.FilePath = e.FullPath;
            logEntry.FileLastWriteTime = File.GetLastWriteTime(e.FullPath);

            bool exists = logEntryModels.Any(x => x.Alert == logEntry.Alert
                                                  && x.FileLastWriteTime == logEntry.FileLastWriteTime
                                                  && x.FilePath == logEntry.FilePath);
            if (!exists)
            {
                logEntryModels.Add(logEntry);

                if (showNotifications)
                {
                    notifyIcon.Text = "Watcher";
                    notifyIcon.Visible = true;
                    notifyIcon.BalloonTipTitle = logEntry.Alert;
                    notifyIcon.BalloonTipText = e.FullPath;
                    notifyIcon.ShowBalloonTip(1000);
                }
            }

            dgLog.DataSource = null;
            dgLog.DataSource = logEntryModels;
            FormatLogGrid();
            dgLog.ClearSelection();
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

            dgWatchers.DataSource = null;
            dgWatchers.DataSource = watcherModels;
            FormatWatcherGrid();

            dgLog.DataSource = null;
            dgLog.DataSource = logEntryModels;
            FormatLogGrid();
        }

        private void btnAddWatcher_Click(object sender, EventArgs e)
        {
            frmAddWatcher addWatcher = new frmAddWatcher();

            if (addWatcher.ShowDialog() == DialogResult.OK)
            {
                bool exists = watcherModels.Any(x => x.DirectoryPath == addWatcher.txtDirectory.Text 
                                                  && x.Extension == addWatcher.cbExtensions.Text);

                if (!exists)
                {
                    bool noFilter = addWatcher.ckbNoFilter.Checked;

                    WatcherModel watcherModel = new WatcherModel();
                    watcherModel.WatcherId = Guid.NewGuid();
                    watcherModel.DirectoryPath = addWatcher.txtDirectory.Text;
                    watcherModel.Extension = addWatcher.cbExtensions.Text;

                    var watcher = new FileSystemWatcher(watcherModel.DirectoryPath);
                    watcher.Created += OnChanged;
                    watcher.Deleted += OnChanged;
                    watcher.Changed += OnChanged;
                    watcher.Renamed += OnChanged;

                    watcher.NotifyFilter = NotifyFilters.Attributes
                                         | NotifyFilters.CreationTime
                                         | NotifyFilters.DirectoryName
                                         | NotifyFilters.FileName
                                         | NotifyFilters.LastAccess
                                         | NotifyFilters.LastWrite
                                         | NotifyFilters.Security
                                         | NotifyFilters.Size;

                    watcher.Filter = $"*{watcherModel.Extension}";
                    watcher.IncludeSubdirectories = true;
                    watcher.EnableRaisingEvents = true;

                    watcher.SynchronizingObject = this;

                    watcherModel.FileWatcher = watcher;
                    watcherModels.Add(watcherModel);

                    dgWatchers.DataSource = null;
                    dgWatchers.DataSource = watcherModels;
                    FormatWatcherGrid();
                    dgWatchers.ClearSelection();
                }
            }
        }

        private void btnRemoveWatcher_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgWatchers.SelectedRows)
            {
                WatcherModel model = row.DataBoundItem as WatcherModel;
                
                TaskDialog taskDialog = new TaskDialog();
                taskDialog.Caption = "Watcher";
                taskDialog.InstructionText = "Remove watcher?";
                taskDialog.Text = model.DirectoryPath;
                taskDialog.StandardButtons = TaskDialogStandardButtons.Yes | TaskDialogStandardButtons.No;

                if (taskDialog.Show() == TaskDialogResult.Yes)
                {
                    watcherModels.Remove(model);
                    model.FileWatcher.Dispose();

                    dgWatchers.DataSource = null;
                    dgWatchers.DataSource = watcherModels;
                    FormatWatcherGrid();
                    dgWatchers.ClearSelection();
                }
            }
        }

        private void btnExportLog_Click(object sender, EventArgs e)
        {
            if (logEntryModels.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "csv files (*.csv)|*.csv";
                sfd.Title = "Specify file to save the log";
                sfd.FileName = "WatcherLog";
                sfd.DefaultExt = ".csv";
                sfd.InitialDirectory = "C:\\";
                sfd.AddExtension = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportLog(sfd.FileName);

                    TaskDialog td = new TaskDialog();
                    td.Caption = "Watcher";
                    td.InstructionText = "Log saved";
                    td.Text = sfd.FileName;
                    td.Show();
                } 
            }
        }

        private void ExportLog(string file)
        {
            StreamWriter sw = new StreamWriter(file);

            foreach (LogEntryModel model in logEntryModels)
            {
                string entry = $"{model.Alert},{model.EntryTime},{model.FilePath}";
                sw.WriteLine(entry);
            }

            sw.Dispose();
            sw = null;
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            if (logEntryModels.Count > 0)
            {
                TaskDialog td = new TaskDialog();
                td.Caption = "Watcher";
                td.InstructionText = "Export before clear?";
                td.StandardButtons = TaskDialogStandardButtons.Yes | TaskDialogStandardButtons.No | TaskDialogStandardButtons.Cancel;

                TaskDialogResult result = td.Show();

                if (result == TaskDialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "csv files (*.csv)|*.csv";
                    sfd.Title = "Specify file to save the log";
                    sfd.FileName = "WatcherLog";
                    sfd.DefaultExt = ".csv";
                    sfd.InitialDirectory = "C:\\";
                    sfd.AddExtension = true;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ExportLog(sfd.FileName);

                        logEntryModels.Clear();
                        dgLog.DataSource = null;

                        TaskDialog taskDialog = new TaskDialog();
                        taskDialog.Caption = "Watcher";
                        taskDialog.InstructionText = "Log saved and cleared";
                        taskDialog.Text = sfd.FileName;
                        taskDialog.Show();
                    }
                }
                else if (result == TaskDialogResult.No)
                {
                    logEntryModels.Clear();
                    dgLog.DataSource = null;
                } 
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCopyFilePath_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgLog.SelectedRows)
            {
                LogEntryModel model = row.DataBoundItem as LogEntryModel;

                Clipboard.Clear();
                Clipboard.SetText(model.FilePath);

                TaskDialog td = new TaskDialog();
                td.Caption = "Watcher";
                td.InstructionText = "Filepath copied";
                td.Text = model.FilePath;
                td.Show();
            }
        }

        private void btnCopyFolderPath_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgWatchers.SelectedRows)
            {
                WatcherModel model = row.DataBoundItem as WatcherModel;

                Clipboard.Clear();
                Clipboard.SetText(model.DirectoryPath);

                TaskDialog td = new TaskDialog();
                td.Caption = "Watcher";
                td.InstructionText = "Directory path copied";
                td.Text = model.DirectoryPath;
                td.Show();
            }
        }

        private void btnGoToWatcherFolder_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgWatchers.SelectedRows)
            {
                WatcherModel model = row.DataBoundItem as WatcherModel;

                try
                {
                    Process.Start(model.DirectoryPath);
                }
                catch (Exception ex)
                {
                    TaskDialog td = new TaskDialog();
                    td.Caption = "Watcher";
                    td.InstructionText = "Error opening folder";
                    td.Text = ex.Message;
                    td.Show();
                }
            }
        }

        private void btnGoToLogFolder_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgLog.SelectedRows)
            {
                LogEntryModel model = row.DataBoundItem as LogEntryModel;

                try
                {
                    Process.Start(Path.GetDirectoryName(model.FilePath));
                }
                catch (Exception ex)
                {
                    TaskDialog td = new TaskDialog();
                    td.Caption = "Watcher";
                    td.InstructionText = "Error opening folder";
                    td.Text = ex.Message;
                    td.Show();
                }
            }
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            frmFilters filters = new frmFilters();
            filters.ShowDialog();
        }

        private void FormatLogGrid()
        {
            dgLog.ColumnHeadersVisible = true;

            dgLog.Columns[0].HeaderText = "Entry Id";
            dgLog.Columns[1].HeaderText = "Watcher Id";
            dgLog.Columns[2].HeaderText = "Change Type";
            dgLog.Columns[3].HeaderText = "Entry Time";
            dgLog.Columns[4].HeaderText = "Filepath";

            dgLog.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgLog.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgLog.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgLog.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgLog.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgLog.Columns[5].Visible = false;
        }

        private void FormatWatcherGrid()
        {
            dgWatchers.ColumnHeadersVisible = true;

            dgWatchers.Columns[0].HeaderText = "Watcher Id";
            dgWatchers.Columns[1].HeaderText = "Ext";
            dgWatchers.Columns[2].HeaderText = "Directory";
            dgWatchers.Columns[3].HeaderText = "Filewatcher";

            dgWatchers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgWatchers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgWatchers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWatchers.Columns[3].Visible = false;
        }
    }

    class LogEntryModel
    {
        public Guid EntryId { get; set; }
        public Guid WatcherId { get; set; }
        public string Alert { get; set; }
        public string EntryTime { get; set; }
        public string FilePath { get; set; }
        public DateTime FileLastWriteTime { get; set; }
    }

    class WatcherModel
    {
        public Guid WatcherId { get; set; }
        public string Extension { get; set; }
        public string DirectoryPath { get; set; }
        public FileSystemWatcher FileWatcher { get; set; }
    }
}
