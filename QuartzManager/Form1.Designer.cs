namespace QuartzManager
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingDirectoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argumentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cronScheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartzDataSet = new QuartzManager.QuartzDataSet();
            this.jobsTableAdapter = new QuartzManager.QuartzDataSetTableAdapters.JobsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPath = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.textBoxTimeOut = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCronSchedule = new System.Windows.Forms.TextBox();
            this.textBoxArguments = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWorkingDirectory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProcess = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxJobGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxJobName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJobID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobIdDataGridViewTextBoxColumn,
            this.jobNameDataGridViewTextBoxColumn,
            this.jobGroupDataGridViewTextBoxColumn,
            this.processDataGridViewTextBoxColumn,
            this.workingDirectoryDataGridViewTextBoxColumn,
            this.argumentsDataGridViewTextBoxColumn,
            this.cronScheduleDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jobsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(848, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // jobIdDataGridViewTextBoxColumn
            // 
            this.jobIdDataGridViewTextBoxColumn.DataPropertyName = "JobId";
            this.jobIdDataGridViewTextBoxColumn.HeaderText = "JobId";
            this.jobIdDataGridViewTextBoxColumn.Name = "jobIdDataGridViewTextBoxColumn";
            this.jobIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobNameDataGridViewTextBoxColumn
            // 
            this.jobNameDataGridViewTextBoxColumn.DataPropertyName = "JobName";
            this.jobNameDataGridViewTextBoxColumn.HeaderText = "JobName";
            this.jobNameDataGridViewTextBoxColumn.Name = "jobNameDataGridViewTextBoxColumn";
            this.jobNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobGroupDataGridViewTextBoxColumn
            // 
            this.jobGroupDataGridViewTextBoxColumn.DataPropertyName = "JobGroup";
            this.jobGroupDataGridViewTextBoxColumn.HeaderText = "JobGroup";
            this.jobGroupDataGridViewTextBoxColumn.Name = "jobGroupDataGridViewTextBoxColumn";
            this.jobGroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // processDataGridViewTextBoxColumn
            // 
            this.processDataGridViewTextBoxColumn.DataPropertyName = "Process";
            this.processDataGridViewTextBoxColumn.HeaderText = "Process";
            this.processDataGridViewTextBoxColumn.Name = "processDataGridViewTextBoxColumn";
            this.processDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workingDirectoryDataGridViewTextBoxColumn
            // 
            this.workingDirectoryDataGridViewTextBoxColumn.DataPropertyName = "WorkingDirectory";
            this.workingDirectoryDataGridViewTextBoxColumn.HeaderText = "WorkingDirectory";
            this.workingDirectoryDataGridViewTextBoxColumn.Name = "workingDirectoryDataGridViewTextBoxColumn";
            this.workingDirectoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // argumentsDataGridViewTextBoxColumn
            // 
            this.argumentsDataGridViewTextBoxColumn.DataPropertyName = "Arguments";
            this.argumentsDataGridViewTextBoxColumn.HeaderText = "Arguments";
            this.argumentsDataGridViewTextBoxColumn.Name = "argumentsDataGridViewTextBoxColumn";
            this.argumentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cronScheduleDataGridViewTextBoxColumn
            // 
            this.cronScheduleDataGridViewTextBoxColumn.DataPropertyName = "CronSchedule";
            this.cronScheduleDataGridViewTextBoxColumn.HeaderText = "CronSchedule";
            this.cronScheduleDataGridViewTextBoxColumn.Name = "cronScheduleDataGridViewTextBoxColumn";
            this.cronScheduleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "TimeOut";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "TimeOut";
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            this.timeOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobsBindingSource
            // 
            this.jobsBindingSource.DataMember = "Jobs";
            this.jobsBindingSource.DataSource = this.quartzDataSet;
            // 
            // quartzDataSet
            // 
            this.quartzDataSet.DataSetName = "QuartzDataSet";
            this.quartzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobsTableAdapter
            // 
            this.jobsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPath);
            this.panel1.Controls.Add(this.buttonFile);
            this.panel1.Controls.Add(this.textBoxTimeOut);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxCronSchedule);
            this.panel1.Controls.Add(this.textBoxArguments);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxWorkingDirectory);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxProcess);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxJobGroup);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxJobName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxJobID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(25, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 107);
            this.panel1.TabIndex = 1;
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(559, 44);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(24, 20);
            this.buttonPath.TabIndex = 18;
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(559, 14);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(24, 20);
            this.buttonFile.TabIndex = 17;
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // textBoxTimeOut
            // 
            this.textBoxTimeOut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobsBindingSource, "TimeOut", true));
            this.textBoxTimeOut.Location = new System.Drawing.Point(719, 44);
            this.textBoxTimeOut.Name = "textBoxTimeOut";
            this.textBoxTimeOut.Size = new System.Drawing.Size(106, 20);
            this.textBoxTimeOut.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(601, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "TimeOut (ms)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "CronSchedule";
            // 
            // textBoxCronSchedule
            // 
            this.textBoxCronSchedule.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobsBindingSource, "CronSchedule", true));
            this.textBoxCronSchedule.Location = new System.Drawing.Point(681, 14);
            this.textBoxCronSchedule.Name = "textBoxCronSchedule";
            this.textBoxCronSchedule.Size = new System.Drawing.Size(144, 20);
            this.textBoxCronSchedule.TabIndex = 6;
            // 
            // textBoxArguments
            // 
            this.textBoxArguments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobsBindingSource, "Arguments", true));
            this.textBoxArguments.Location = new System.Drawing.Point(319, 73);
            this.textBoxArguments.Name = "textBoxArguments";
            this.textBoxArguments.Size = new System.Drawing.Size(234, 20);
            this.textBoxArguments.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Arguments";
            // 
            // textBoxWorkingDirectory
            // 
            this.textBoxWorkingDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobsBindingSource, "WorkingDirectory", true));
            this.textBoxWorkingDirectory.Location = new System.Drawing.Point(319, 44);
            this.textBoxWorkingDirectory.Name = "textBoxWorkingDirectory";
            this.textBoxWorkingDirectory.Size = new System.Drawing.Size(234, 20);
            this.textBoxWorkingDirectory.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Working Directory";
            // 
            // textBoxProcess
            // 
            this.textBoxProcess.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobsBindingSource, "Process", true));
            this.textBoxProcess.Location = new System.Drawing.Point(319, 14);
            this.textBoxProcess.Name = "textBoxProcess";
            this.textBoxProcess.Size = new System.Drawing.Size(234, 20);
            this.textBoxProcess.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Process Path";
            // 
            // textBoxJobGroup
            // 
            this.textBoxJobGroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobsBindingSource, "JobGroup", true));
            this.textBoxJobGroup.Location = new System.Drawing.Point(71, 73);
            this.textBoxJobGroup.Name = "textBoxJobGroup";
            this.textBoxJobGroup.ReadOnly = true;
            this.textBoxJobGroup.Size = new System.Drawing.Size(126, 20);
            this.textBoxJobGroup.TabIndex = 2;
            this.textBoxJobGroup.Text = "Default";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "JobGroup";
            // 
            // textBoxJobName
            // 
            this.textBoxJobName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobsBindingSource, "JobName", true));
            this.textBoxJobName.Location = new System.Drawing.Point(71, 44);
            this.textBoxJobName.Name = "textBoxJobName";
            this.textBoxJobName.Size = new System.Drawing.Size(126, 20);
            this.textBoxJobName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "JobName";
            // 
            // textBoxJobID
            // 
            this.textBoxJobID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobsBindingSource, "JobId", true));
            this.textBoxJobID.Location = new System.Drawing.Point(109, 14);
            this.textBoxJobID.Name = "textBoxJobID";
            this.textBoxJobID.Size = new System.Drawing.Size(88, 20);
            this.textBoxJobID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "JobID";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(457, 170);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(661, 170);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(763, 170);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(559, 170);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.ProgramFilesX86;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 408);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "QuartzManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QuartzDataSet quartzDataSet;
        private System.Windows.Forms.BindingSource jobsBindingSource;
        private QuartzDataSetTableAdapters.JobsTableAdapter jobsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingDirectoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argumentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cronScheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxJobID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxJobName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTimeOut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCronSchedule;
        private System.Windows.Forms.TextBox textBoxArguments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxWorkingDirectory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxJobGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

