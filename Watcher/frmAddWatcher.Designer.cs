namespace Watcher
{
    partial class frmAddWatcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddWatcher));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.cbExtensions = new System.Windows.Forms.ComboBox();
            this.lblBrowseFolder = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblExtension = new System.Windows.Forms.Label();
            this.ckbNoFilter = new System.Windows.Forms.CheckBox();
            this.btnFilters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(289, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(208, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtDirectory
            // 
            this.txtDirectory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDirectory.Enabled = false;
            this.txtDirectory.Location = new System.Drawing.Point(12, 45);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(352, 20);
            this.txtDirectory.TabIndex = 2;
            // 
            // cbExtensions
            // 
            this.cbExtensions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExtensions.FormattingEnabled = true;
            this.cbExtensions.Location = new System.Drawing.Point(12, 122);
            this.cbExtensions.Name = "cbExtensions";
            this.cbExtensions.Size = new System.Drawing.Size(138, 21);
            this.cbExtensions.TabIndex = 3;
            // 
            // lblBrowseFolder
            // 
            this.lblBrowseFolder.AutoSize = true;
            this.lblBrowseFolder.Location = new System.Drawing.Point(9, 9);
            this.lblBrowseFolder.Name = "lblBrowseFolder";
            this.lblBrowseFolder.Size = new System.Drawing.Size(100, 26);
            this.lblBrowseFolder.TabIndex = 4;
            this.lblBrowseFolder.Text = "Browse and select\r\na directory to watch";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(289, 71);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(9, 97);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(119, 13);
            this.lblExtension.TabIndex = 6;
            this.lblExtension.Text = "Select a file type to filter";
            // 
            // ckbNoFilter
            // 
            this.ckbNoFilter.AutoSize = true;
            this.ckbNoFilter.Location = new System.Drawing.Point(156, 126);
            this.ckbNoFilter.Name = "ckbNoFilter";
            this.ckbNoFilter.Size = new System.Drawing.Size(62, 17);
            this.ckbNoFilter.TabIndex = 7;
            this.ckbNoFilter.Text = "No filter";
            this.ckbNoFilter.UseVisualStyleBackColor = true;
            this.ckbNoFilter.CheckedChanged += new System.EventHandler(this.ckbNoFilter_CheckedChanged);
            // 
            // btnFilters
            // 
            this.btnFilters.Location = new System.Drawing.Point(12, 180);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(75, 23);
            this.btnFilters.TabIndex = 8;
            this.btnFilters.Text = "Filters";
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // frmAddWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 215);
            this.Controls.Add(this.btnFilters);
            this.Controls.Add(this.ckbNoFilter);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblBrowseFolder);
            this.Controls.Add(this.cbExtensions);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddWatcher";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Watcher";
            this.Load += new System.EventHandler(this.frmAddWatcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBrowseFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblExtension;
        public System.Windows.Forms.TextBox txtDirectory;
        public System.Windows.Forms.ComboBox cbExtensions;
        public System.Windows.Forms.CheckBox ckbNoFilter;
        private System.Windows.Forms.Button btnFilters;
    }
}