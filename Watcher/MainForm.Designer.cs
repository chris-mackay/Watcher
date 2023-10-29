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
            this.directoriesListbox = new System.Windows.Forms.ListBox();
            this.logListbox = new System.Windows.Forms.ListBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // directoriesListbox
            // 
            this.directoriesListbox.FormattingEnabled = true;
            this.directoriesListbox.Location = new System.Drawing.Point(12, 12);
            this.directoriesListbox.Name = "directoriesListbox";
            this.directoriesListbox.Size = new System.Drawing.Size(538, 121);
            this.directoriesListbox.TabIndex = 0;
            // 
            // logListbox
            // 
            this.logListbox.FormattingEnabled = true;
            this.logListbox.Location = new System.Drawing.Point(12, 152);
            this.logListbox.Name = "logListbox";
            this.logListbox.Size = new System.Drawing.Size(538, 290);
            this.logListbox.TabIndex = 1;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Watcher";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 452);
            this.Controls.Add(this.logListbox);
            this.Controls.Add(this.directoriesListbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox directoriesListbox;
        private System.Windows.Forms.ListBox logListbox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

