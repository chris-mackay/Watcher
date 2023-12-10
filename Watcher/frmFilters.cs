using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Watcher.Properties;

namespace Watcher
{
    public partial class frmFilters : Form
    {
        public List<string> Extensions;

        public frmFilters()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (Settings.Default.Extensions != null && Settings.Default.Extensions != string.Empty)
            {
                Extensions = Helpers.ConvertCSVToList(Settings.Default.Extensions);
                lstExtensions.DataSource = null;
                lstExtensions.DataSource = Extensions;
            }
            else
            {
                Extensions = new List<string>();
                lstExtensions.DataSource = null;
                lstExtensions.DataSource = Extensions;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmInput input = new frmInput();

            if (input.ShowDialog() == DialogResult.OK)
            {
                string ext = input.txtExtension.Text;

                if (ext != string.Empty && !Extensions.Contains(ext))
                {
                    Extensions.Add(ext);

                    lstExtensions.DataSource = null;
                    lstExtensions.DataSource = Extensions;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstExtensions.SelectedItems.Count > 0)
            {
                TaskDialog td = new TaskDialog();
                td.Caption = "Watcher";
                td.InstructionText = "Remove extension?";
                td.Text = lstExtensions.SelectedItem as string;
                td.StandardButtons = TaskDialogStandardButtons.Yes | TaskDialogStandardButtons.No;

                if (td.Show() == TaskDialogResult.Yes)
                {
                    string ext = lstExtensions.SelectedItem as string;
                    Extensions.Remove(ext);

                    lstExtensions.DataSource = null;
                    lstExtensions.DataSource = Extensions; 
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TaskDialog td = new TaskDialog();
            td.Caption = "Watcher";
            td.InstructionText = "Clear list?";
            td.StandardButtons = TaskDialogStandardButtons.Yes | TaskDialogStandardButtons.No;

            if (td.Show() == TaskDialogResult.Yes)
            {
                Extensions.Clear();
                lstExtensions.DataSource = null;
                lstExtensions.DataSource = Extensions; 
            }
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (lstExtensions.Items.Count > 0)
            {
                Settings.Default.Extensions = Helpers.ConvertListToCSV(Extensions);
                Settings.Default.Save(); 
            }
            else
            {
                Settings.Default.Extensions = "";
                Settings.Default.Save();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
