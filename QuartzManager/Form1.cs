using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
     
        Dictionary<Int32, Int32> changedJobs = new Dictionary<int, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createLinkLabel();
            dataGridView1.ClearSelection();
            changesMade = false;
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
            changesMade = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int test = 0;
            try
            {
                jobsBindingSource.EndEdit();
                DataSet changedRecords1 = quartzDataSet.GetChanges();
                jobsTableAdapter.Update(quartzDataSet.Jobs);
                foreach (DataRow row in changedRecords1.Tables[0].Rows)
                { 
                    if(!changedJobs.TryGetValue((int)row["JobID"], out test))
                    {
                        changedJobs.Add((int)row["JobID"], 1);
                    }
                }
                
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
                if(MessageBox.Show("Are you sure you want to delete the job permanently and save all changes?", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                { 
                    int test = 0;
                    if (!changedJobs.TryGetValue(quartzDataSet.Jobs.Rows[jobsBindingSource.Position].Field<Int32>("JobID"), out test))
                    {
                        changedJobs.Add(quartzDataSet.Jobs.Rows[jobsBindingSource.Position].Field<Int32>("JobID"), 1);
                    }
                    else
                    {
                        changedJobs[quartzDataSet.Jobs.Rows[jobsBindingSource.Position].Field<Int32>("JobID")] = 1;
                    }
                    DataSet changedRecords1 = quartzDataSet.GetChanges();
                    if(changedRecords1 != null)
                    {
                        foreach (DataRow row in changedRecords1.Tables[0].Rows)
                        {
                            if (!changedJobs.TryGetValue((int)row["JobID"], out test))
                            {
                                changedJobs.Add((int)row["JobID"], 0);
                            }
                        }
                    }
                    jobsBindingSource.RemoveCurrent();
                    jobsTableAdapter.Update(quartzDataSet.Jobs);
                    changesMade = false;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(changesMade == true)
            {
                if(MessageBox.Show("Save Changes Before Exiting", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int test = 0;
                    DataSet changedRecords = quartzDataSet.GetChanges();
                    jobsBindingSource.EndEdit(); 
                    foreach (DataRow row in changedRecords.Tables[0].Rows)
                    {
                        if (!changedJobs.TryGetValue((int)row["JobID"], out test))
                        {
                            changedJobs.Add((int)row["JobID"], 0);
                        }
                    }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void createLinkLabel()
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.cronmaker.com/";
            linkLabel1.Links.Add(link);
        }
    }
}
