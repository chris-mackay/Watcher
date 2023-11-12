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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnAddDirectory = new System.Windows.Forms.Button();
            this.btnRemoveDirectory = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnExportLog = new System.Windows.Forms.Button();
            this.dgDirectories = new System.Windows.Forms.DataGridView();
            this.dgLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDirectories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLog)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = global::Watcher.Properties.Resources.Watcher;
            this.notifyIcon.Text = "Watcher";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // btnAddDirectory
            // 
            this.btnAddDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDirectory.Location = new System.Drawing.Point(430, 12);
            this.btnAddDirectory.Name = "btnAddDirectory";
            this.btnAddDirectory.Size = new System.Drawing.Size(120, 23);
            this.btnAddDirectory.TabIndex = 2;
            this.btnAddDirectory.Text = "Add Directory";
            this.btnAddDirectory.UseVisualStyleBackColor = true;
            this.btnAddDirectory.Click += new System.EventHandler(this.btnAddDirectory_Click);
            // 
            // btnRemoveDirectory
            // 
            this.btnRemoveDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDirectory.Location = new System.Drawing.Point(430, 41);
            this.btnRemoveDirectory.Name = "btnRemoveDirectory";
            this.btnRemoveDirectory.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveDirectory.TabIndex = 3;
            this.btnRemoveDirectory.Text = "Remove Directory";
            this.btnRemoveDirectory.UseVisualStyleBackColor = true;
            this.btnRemoveDirectory.Click += new System.EventHandler(this.btnRemoveDirectory_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivate.Location = new System.Drawing.Point(430, 110);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(120, 23);
            this.btnActivate.TabIndex = 4;
            this.btnActivate.Text = "Activate Directories";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Location = new System.Drawing.Point(430, 417);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(120, 23);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "Minimize to Tray";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLog.Location = new System.Drawing.Point(430, 388);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(120, 23);
            this.btnClearLog.TabIndex = 6;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnExportLog
            // 
            this.btnExportLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportLog.Location = new System.Drawing.Point(430, 359);
            this.btnExportLog.Name = "btnExportLog";
            this.btnExportLog.Size = new System.Drawing.Size(120, 23);
            this.btnExportLog.TabIndex = 7;
            this.btnExportLog.Text = "Export Log";
            this.btnExportLog.UseVisualStyleBackColor = true;
            this.btnExportLog.Click += new System.EventHandler(this.btnExportLog_Click);
            // 
            // dgDirectories
            // 
            this.dgDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDirectories.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgDirectories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDirectories.Location = new System.Drawing.Point(12, 12);
            this.dgDirectories.Name = "dgDirectories";
            this.dgDirectories.RowHeadersVisible = false;
            this.dgDirectories.Size = new System.Drawing.Size(412, 121);
            this.dgDirectories.TabIndex = 8;
            // 
            // dgLog
            // 
            this.dgLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLog.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLog.Location = new System.Drawing.Point(12, 149);
            this.dgLog.Name = "dgLog";
            this.dgLog.RowHeadersVisible = false;
            this.dgLog.Size = new System.Drawing.Size(412, 291);
            this.dgLog.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 452);
            this.Controls.Add(this.dgLog);
            this.Controls.Add(this.dgDirectories);
            this.Controls.Add(this.btnExportLog);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnRemoveDirectory);
            this.Controls.Add(this.btnAddDirectory);
            this.Icon = global::Watcher.Properties.Resources.Watcher;
            this.MinimumSize = new System.Drawing.Size(578, 491);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgDirectories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnAddDirectory;
        private System.Windows.Forms.Button btnRemoveDirectory;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnExportLog;
        private System.Windows.Forms.DataGridView dgDirectories;
        private System.Windows.Forms.DataGridView dgLog;
    }
}

