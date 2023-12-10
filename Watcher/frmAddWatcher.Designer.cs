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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblBrowseFolder = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblExtension = new System.Windows.Forms.Label();
            this.ckbNoFilter = new System.Windows.Forms.CheckBox();
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
            this.btnAdd.Location = new System.Drawing.Point(208, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(12, 45);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(352, 20);
            this.txtDirectory.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 3;
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
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(9, 95);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(141, 26);
            this.lblExtension.TabIndex = 6;
            this.lblExtension.Text = "Select a file type to watch\r\nThis list is created in settings";
            // 
            // ckbNoFilter
            // 
            this.ckbNoFilter.AutoSize = true;
            this.ckbNoFilter.Location = new System.Drawing.Point(12, 167);
            this.ckbNoFilter.Name = "ckbNoFilter";
            this.ckbNoFilter.Size = new System.Drawing.Size(62, 17);
            this.ckbNoFilter.TabIndex = 7;
            this.ckbNoFilter.Text = "No filter";
            this.ckbNoFilter.UseVisualStyleBackColor = true;
            // 
            // frmAddWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 215);
            this.Controls.Add(this.ckbNoFilter);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblBrowseFolder);
            this.Controls.Add(this.comboBox1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblBrowseFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.CheckBox ckbNoFilter;
    }
}