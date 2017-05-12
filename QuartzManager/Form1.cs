using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuartzManager
{
    public partial class Form1 : Form
    {
        bool changesMade = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            changesMade = false;
            // TODO: This line of code loads data into the 'quartzDataSet.Jobs' table. You can move, or remove it, as needed.
            this.jobsTableAdapter.Fill(this.quartzDataSet.Jobs);
            jobsBindingSource.DataSource = this.quartzDataSet.Jobs;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBoxJobID.Focus();
            try
            {
                var query = quartzDataSet.Jobs.Max(x => x.JobId);
                QuartzDataSet.JobsRow row = (QuartzDataSet.JobsRow)quartzDataSet.Jobs.NewRow();
                row.SetField<Int32>("JobID", query + 1);
                row.SetField<String>("JobGroup", "Default");
                quartzDataSet.Jobs.AddJobsRow(row);
                jobsBindingSource.MoveLast();
                changesMade = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                jobsBindingSource.ResetBindings(false);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBoxJobID.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            jobsBindingSource.ResetBindings(false);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                jobsBindingSource.EndEdit();
                jobsTableAdapter.Update(quartzDataSet.Jobs);
                
                changesMade = false;        
                panel1.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                jobsBindingSource.ResetBindings(false);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows != null)
            {
                if(MessageBox.Show("Are you sure you want to delete?", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    jobsBindingSource.RemoveCurrent();
                    changesMade = true;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(changesMade == true)
            {
                if(MessageBox.Show("Save Changes Before Exiting", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    jobsBindingSource.EndEdit();
                    jobsTableAdapter.Update(quartzDataSet.Jobs);
                }
            }
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            dataGridView1.Rows[e.Row.Index -1].Cells[2].Value = "Default";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changesMade = true;
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Choose Process/File";
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxProcess.Text = openFileDialog1.FileName;
            }
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Choose Working Folder";
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxWorkingDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
