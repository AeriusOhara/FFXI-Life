using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace FFXICrafterDesu
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            if(FFXILife.Properties.Settings.Default.processName != String.Empty)
            {
                setProcessLabelText();

                this.Location = new Point(this.Owner.Location.X + 10, this.Owner.Location.Y + 30);
            }

            Process[] processlist = Process.GetProcesses();

            int i = 0;

            foreach (Process process in processlist)
            {
                if(process.ProcessName != string.Empty)
                {
                    if (processViewGrid.RowCount != 0)
                    {
                        processViewGrid.Rows.Add();
                    }

                    processViewGrid.Rows[i].Cells[0].Value = process.ProcessName.ToString();

                    i++;
                }
            }

            this.processViewGrid.Sort(this.processViewGrid.Columns["processName"], ListSortDirection.Ascending);
        }

        private void saveProcess_Click(object sender, EventArgs e)
        {
            FFXILife.Properties.Settings.Default.processName = processViewGrid.Rows[processViewGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            FFXILife.Properties.Settings.Default.Save();

            setProcessLabelText();
        }

        private void setProcessLabelText()
        {
            processLabel.Text = "Selected FFXI Process: ";
            if (FFXILife.Properties.Settings.Default.processName.Length > 10)
            {
                processLabel.Text += FFXILife.Properties.Settings.Default.processName.Substring(0, 10);
                processLabel.Text += " (trimmed)";
            }
            else
            {
                processLabel.Text += FFXILife.Properties.Settings.Default.processName;
            }
        }
    }
}
