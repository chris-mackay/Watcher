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
    public partial class frmSettings : Form
    {
        List<string> extensions;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (Settings.Default.Extensions != null && Settings.Default.Extensions != string.Empty)
            {
                extensions = ConvertCSVToList(Settings.Default.Extensions);
                lstExtensions.DataSource = null;
                lstExtensions.DataSource = extensions;
            }
            else
            {
                extensions = new List<string>();
                lstExtensions.DataSource = null;
                lstExtensions.DataSource = extensions;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmInput input = new frmInput();

            if (input.ShowDialog() == DialogResult.OK)
            {
                string ext = input.txtExtension.Text;

                if (ext != string.Empty && !extensions.Contains(ext))
                {
                    extensions.Add(ext);

                    lstExtensions.DataSource = null;
                    lstExtensions.DataSource = extensions;
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
                    extensions.Remove(ext);

                    lstExtensions.DataSource = null;
                    lstExtensions.DataSource = extensions; 
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
                extensions.Clear();
                lstExtensions.DataSource = null;
                lstExtensions.DataSource = extensions; 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstExtensions.Items.Count > 0)
            {
                Settings.Default.Extensions = ConvertListToCSV(extensions);
                Settings.Default.Save(); 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ConvertListToCSV(List<string> list)
        {
            string csv = string.Empty;

            StringBuilder sb = new StringBuilder();
            list.ForEach(x => sb.Append($"{x},"));

            csv = sb.ToString().TrimEnd(',');

            return csv;
        }

        private List<string> ConvertCSVToList(string csv)
        {
            List<string> list = new List<string>();
            string[] line = csv.Split(',');

            foreach (string s in line) { list.Add(s); }

            return list;
        }
    }
}
