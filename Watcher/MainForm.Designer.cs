using System.Windows.Forms;

namespace Watcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnAddWatcher = new System.Windows.Forms.Button();
            this.btnRemoveWatcher = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnExportLog = new System.Windows.Forms.Button();
            this.dgWatchers = new System.Windows.Forms.DataGridView();
            this.dgLog = new System.Windows.Forms.DataGridView();
            this.cbxShowNofitifcations = new System.Windows.Forms.CheckBox();
            this.btnCopyFilePath = new System.Windows.Forms.Button();
            this.btnCopyFolderpath = new System.Windows.Forms.Button();
            this.btnGoToWatcherFolder = new System.Windows.Forms.Button();
            this.btnGoToLogFolder = new System.Windows.Forms.Button();
            this.btnFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgWatchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLog)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Watcher";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // btnAddWatcher
            // 
            this.btnAddWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWatcher.Location = new System.Drawing.Point(544, 12);
            this.btnAddWatcher.Name = "btnAddWatcher";
            this.btnAddWatcher.Size = new System.Drawing.Size(120, 23);
            this.btnAddWatcher.TabIndex = 1;
            this.btnAddWatcher.Text = "Add Watcher";
            this.btnAddWatcher.UseVisualStyleBackColor = true;
            this.btnAddWatcher.Click += new System.EventHandler(this.btnAddWatcher_Click);
            // 
            // btnRemoveWatcher
            // 
            this.btnRemoveWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveWatcher.Location = new System.Drawing.Point(544, 41);
            this.btnRemoveWatcher.Name = "btnRemoveWatcher";
            this.btnRemoveWatcher.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveWatcher.TabIndex = 2;
            this.btnRemoveWatcher.Text = "Remove Watcher";
            this.btnRemoveWatcher.UseVisualStyleBackColor = true;
            this.btnRemoveWatcher.Click += new System.EventHandler(this.btnRemoveWatcher_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Location = new System.Drawing.Point(544, 496);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(120, 23);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.Text = "Minimize to Tray";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLog.Location = new System.Drawing.Point(544, 467);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(120, 23);
            this.btnClearLog.TabIndex = 11;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnExportLog
            // 
            this.btnExportLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportLog.Location = new System.Drawing.Point(544, 438);
            this.btnExportLog.Name = "btnExportLog";
            this.btnExportLog.Size = new System.Drawing.Size(120, 23);
            this.btnExportLog.TabIndex = 10;
            this.btnExportLog.Text = "Export Log";
            this.btnExportLog.UseVisualStyleBackColor = true;
            this.btnExportLog.Click += new System.EventHandler(this.btnExportLog_Click);
            // 
            // dgWatchers
            // 
            this.dgWatchers.AllowUserToAddRows = false;
            this.dgWatchers.AllowUserToDeleteRows = false;
            this.dgWatchers.AllowUserToResizeColumns = false;
            this.dgWatchers.AllowUserToResizeRows = false;
            this.dgWatchers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgWatchers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgWatchers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgWatchers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgWatchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWatchers.ColumnHeadersVisible = false;
            this.dgWatchers.Location = new System.Drawing.Point(12, 12);
            this.dgWatchers.MultiSelect = false;
            this.dgWatchers.Name = "dgWatchers";
            this.dgWatchers.ReadOnly = true;
            this.dgWatchers.RowHeadersVisible = false;
            this.dgWatchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWatchers.Size = new System.Drawing.Size(526, 219);
            this.dgWatchers.TabIndex = 0;
            this.dgWatchers.TabStop = false;
            // 
            // dgLog
            // 
            this.dgLog.AllowUserToAddRows = false;
            this.dgLog.AllowUserToDeleteRows = false;
            this.dgLog.AllowUserToResizeColumns = false;
            this.dgLog.AllowUserToResizeRows = false;
            this.dgLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgLog.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLog.ColumnHeadersVisible = false;
            this.dgLog.Location = new System.Drawing.Point(12, 237);
            this.dgLog.MultiSelect = false;
            this.dgLog.Name = "dgLog";
            this.dgLog.ReadOnly = true;
            this.dgLog.RowHeadersVisible = false;
            this.dgLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLog.Size = new System.Drawing.Size(526, 282);
            this.dgLog.TabIndex = 7;
            this.dgLog.TabStop = false;
            // 
            // cbxShowNofitifcations
            // 
            this.cbxShowNofitifcations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxShowNofitifcations.AutoSize = true;
            this.cbxShowNofitifcations.Location = new System.Drawing.Point(544, 214);
            this.cbxShowNofitifcations.Name = "cbxShowNofitifcations";
            this.cbxShowNofitifcations.Size = new System.Drawing.Size(114, 17);
            this.cbxShowNofitifcations.TabIndex = 6;
            this.cbxShowNofitifcations.Text = "Show Nofifications";
            this.cbxShowNofitifcations.UseVisualStyleBackColor = true;
            // 
            // btnCopyFilePath
            // 
            this.btnCopyFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyFilePath.Location = new System.Drawing.Point(544, 409);
            this.btnCopyFilePath.Name = "btnCopyFilePath";
            this.btnCopyFilePath.Size = new System.Drawing.Size(120, 23);
            this.btnCopyFilePath.TabIndex = 9;
            this.btnCopyFilePath.Text = "Copy File Path";
            this.btnCopyFilePath.UseVisualStyleBackColor = true;
            this.btnCopyFilePath.Click += new System.EventHandler(this.btnCopyFilePath_Click);
            // 
            // btnCopyFolderpath
            // 
            this.btnCopyFolderpath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyFolderpath.Location = new System.Drawing.Point(544, 70);
            this.btnCopyFolderpath.Name = "btnCopyFolderpath";
            this.btnCopyFolderpath.Size = new System.Drawing.Size(120, 23);
            this.btnCopyFolderpath.TabIndex = 3;
            this.btnCopyFolderpath.Text = "Copy Folder Path";
            this.btnCopyFolderpath.UseVisualStyleBackColor = true;
            this.btnCopyFolderpath.Click += new System.EventHandler(this.btnCopyFolderPath_Click);
            // 
            // btnGoToWatcherFolder
            // 
            this.btnGoToWatcherFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoToWatcherFolder.Location = new System.Drawing.Point(544, 99);
            this.btnGoToWatcherFolder.Name = "btnGoToWatcherFolder";
            this.btnGoToWatcherFolder.Size = new System.Drawing.Size(120, 23);
            this.btnGoToWatcherFolder.TabIndex = 4;
            this.btnGoToWatcherFolder.Text = "Go to Folder";
            this.btnGoToWatcherFolder.UseVisualStyleBackColor = true;
            this.btnGoToWatcherFolder.Click += new System.EventHandler(this.btnGoToWatcherFolder_Click);
            // 
            // btnGoToLogFolder
            // 
            this.btnGoToLogFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoToLogFolder.Location = new System.Drawing.Point(544, 380);
            this.btnGoToLogFolder.Name = "btnGoToLogFolder";
            this.btnGoToLogFolder.Size = new System.Drawing.Size(120, 23);
            this.btnGoToLogFolder.TabIndex = 8;
            this.btnGoToLogFolder.Text = "Go to Folder";
            this.btnGoToLogFolder.UseVisualStyleBackColor = true;
            this.btnGoToLogFolder.Click += new System.EventHandler(this.btnGoToLogFolder_Click);
            // 
            // btnFilters
            // 
            this.btnFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilters.Location = new System.Drawing.Point(544, 128);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(120, 23);
            this.btnFilters.TabIndex = 5;
            this.btnFilters.Text = "Filters";
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 531);
            this.Controls.Add(this.btnFilters);
            this.Controls.Add(this.btnGoToLogFolder);
            this.Controls.Add(this.btnGoToWatcherFolder);
            this.Controls.Add(this.btnCopyFolderpath);
            this.Controls.Add(this.btnCopyFilePath);
            this.Controls.Add(this.cbxShowNofitifcations);
            this.Controls.Add(this.dgLog);
            this.Controls.Add(this.dgWatchers);
            this.Controls.Add(this.btnExportLog);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnRemoveWatcher);
            this.Controls.Add(this.btnAddWatcher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(578, 491);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgWatchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnAddWatcher;
        private System.Windows.Forms.Button btnRemoveWatcher;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnExportLog;
        private System.Windows.Forms.DataGridView dgWatchers;
        private System.Windows.Forms.DataGridView dgLog;
        private System.Windows.Forms.CheckBox cbxShowNofitifcations;
        private System.Windows.Forms.Button btnCopyFilePath;
        private System.Windows.Forms.Button btnCopyFolderpath;
        private System.Windows.Forms.Button btnGoToWatcherFolder;
        private Button btnGoToLogFolder;
        private Button btnFilters;
    }
}

