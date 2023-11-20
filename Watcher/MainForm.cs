﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Watcher
{
    public partial class MainForm : Form
    {
        List<WatcherModel> watcherModels;
        List<LogEntryModel> logEntryModels;
        MainForm mainForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void FormatWatcherGrid()
        {
            dgWatchers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWatchers.Columns[1].Visible = false;
        }

        private void FormatLogGrid()
        {
            dgLog.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            watcherModels = new List<WatcherModel>();
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
            FormatLogGrid();
            dgLog.ClearSelection();
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
        }

        private void btnAddWatcher_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog ofd = new CommonOpenFileDialog();
            ofd.DefaultDirectory = "C:\\";
            ofd.Title = "Navigate to the directory to add it to the watcher";
            ofd.IsFolderPicker = true;

            if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                WatcherModel watcherModel = new WatcherModel();
                bool exists = watcherModels.Any(x => x.DirectoryPath == ofd.FileName);

                if (exists == false)
                {
                    watcherModel.DirectoryPath = ofd.FileName;

                    var watcher = new FileSystemWatcher(watcherModel.DirectoryPath);
                    watcher.Created += OnCreated;
                    watcher.Deleted += OnDeleted;

                    watcher.NotifyFilter = NotifyFilters.FileName;
                    watcher.Filter = "";
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
    }

    class LogEntryModel
    {
        public string Alert { get; set; }
        public DateTime EntryTime { get; set; }
        public string FilePath { get; set; }
    }

    class WatcherModel
    {
        public string DirectoryPath { get; set; }
        public FileSystemWatcher FileWatcher { get; set; }
    }
}
