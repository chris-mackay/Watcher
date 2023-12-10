using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watcher.Properties;

namespace Watcher
{
    public partial class frmAddWatcher : Form
    {
        public frmAddWatcher()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog ofd = new CommonOpenFileDialog();
            ofd.DefaultDirectory = "C:\\";
            ofd.Title = "Navigate to the directory to add it to the watcher";
            ofd.IsFolderPicker = true;

            if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtDirectory.Text = ofd.FileName;
            }
        }

        private void frmAddWatcher_Load(object sender, EventArgs e)
        {
            List<string> extensions;

            if (Settings.Default.Extensions != null && Settings.Default.Extensions != string.Empty)
            {
                extensions = Helpers.ConvertCSVToList(Settings.Default.Extensions);
                cbExtensions.DataSource = null;
                cbExtensions.DataSource = extensions;
            }
            else
            {
                extensions = new List<string>();
                cbExtensions.DataSource = null;
                cbExtensions.DataSource = extensions;
            }
        }

        private void ckbNoFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNoFilter.Checked)
            {
                cbExtensions.SelectedIndex = -1;
                cbExtensions.Enabled = false;
            }
            else
            {
                cbExtensions.Enabled = true;
                cbExtensions.SelectedIndex = 0;
            }
        }
    }
}
