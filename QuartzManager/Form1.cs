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
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace QuartzManager
{
    public partial class Form1 : Form
    {
        bool changesMade = false;

        List<Int32> changedJobs = new List<Int32>();

        ChannelFactory<IJobUpdater> httpFactory;
        ChannelFactory<IJobUpdater> pipeFactory;
        IJobUpdater httpProxy;
        IJobUpdater pipeProxy;

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
            setupWCFConnection();
        }

        private void setupWCFConnection()
        {
            try
            {
                httpFactory =
                    new ChannelFactory<IJobUpdater>(
                    new BasicHttpBinding(),
                    new EndpointAddress(
                        "http://localhost:9000/Reverse"));

                pipeFactory =
                  new ChannelFactory<IJobUpdater>(
                    new NetNamedPipeBinding(),
                    new EndpointAddress(
                      "net.pipe://localhost/PipeReverse"));

                httpProxy =
                  httpFactory.CreateChannel();

                pipeProxy =
                  pipeFactory.CreateChannel();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error setting up service connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if(changedRecords1 != null)
                {
                    foreach (DataRow row in changedRecords1.Tables[0].Rows)
                    {
                        if (!changedJobs.Contains((int)row["JobID"]))
                        {
                            changedJobs.Add((int)row["JobID"]);
                        }
                    }
                }
                changesMade = false;        
                panel1.Enabled = false;
                updateScheduler();
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
                    if (!changedJobs.Contains(quartzDataSet.Jobs.Rows[jobsBindingSource.Position].Field<Int32>("JobID")))
                    {
                        changedJobs.Add(quartzDataSet.Jobs.Rows[jobsBindingSource.Position].Field<Int32>("JobID"));
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
                            if (!changedJobs.Contains((int)row["JobID"]))
                            {
                                changedJobs.Add((int)row["JobID"]);
                            }
                        }
                    }
                    jobsBindingSource.RemoveCurrent();
                    jobsTableAdapter.Update(quartzDataSet.Jobs);
                    changesMade = false;
                    updateScheduler();
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
                    DataSet changedRecords = null;
                    changedRecords = quartzDataSet.GetChanges();
                    jobsBindingSource.EndEdit(); 
                    foreach (DataRow row in changedRecords.Tables[0].Rows)
                    {
                        if (!changedJobs.Contains((int)row["JobID"]))
                        {
                            changedJobs.Add((int)row["JobID"]);
                        }
                    }
                    jobsTableAdapter.Update(quartzDataSet.Jobs);
                    updateScheduler();
                }
            }
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            dataGridView1.Rows[e.Row.Index -1].Cells[2].Value = "Default";
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

        private void updateScheduler()
        {
            foreach(var change in changedJobs)
            {
                MessageBox.Show("Job Changed:" + change.ToString());
            }
            try
            {
                pipeProxy.UpdateJobs(changedJobs);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException);
            }
            finally
            {
                changedJobs.Clear();
            }
        }
    }

    [ServiceContract]
    public interface IJobUpdater
    {
        [OperationContract]
        Boolean UpdateJobs(List<int> jobs);
    }
}
