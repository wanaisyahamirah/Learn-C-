namespace DatabaseBackupScheduler
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxServerAuthentication = new System.Windows.Forms.GroupBox();
            this.btnConnectServer = new System.Windows.Forms.Button();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.groupBoxDatabase = new System.Windows.Forms.GroupBox();
            this.cbDbName = new System.Windows.Forms.ComboBox();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.groupBoxOutputPath = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblBackupPath = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerBackup = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBarBackup = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxServerAuthentication.SuspendLayout();
            this.groupBoxDatabase.SuspendLayout();
            this.groupBoxOutputPath.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(103, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(429, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DATABASE BACKUP SCHEDULER";
            // 
            // groupBoxServerAuthentication
            // 
            this.groupBoxServerAuthentication.Controls.Add(this.btnConnectServer);
            this.groupBoxServerAuthentication.Controls.Add(this.txtServerName);
            this.groupBoxServerAuthentication.Controls.Add(this.lblServerName);
            this.groupBoxServerAuthentication.Location = new System.Drawing.Point(12, 100);
            this.groupBoxServerAuthentication.Name = "groupBoxServerAuthentication";
            this.groupBoxServerAuthentication.Size = new System.Drawing.Size(623, 72);
            this.groupBoxServerAuthentication.TabIndex = 5;
            this.groupBoxServerAuthentication.TabStop = false;
            this.groupBoxServerAuthentication.Text = "SQL Server Authentication";
            // 
            // btnConnectServer
            // 
            this.btnConnectServer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConnectServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnectServer.Location = new System.Drawing.Point(445, 32);
            this.btnConnectServer.Name = "btnConnectServer";
            this.btnConnectServer.Size = new System.Drawing.Size(156, 23);
            this.btnConnectServer.TabIndex = 2;
            this.btnConnectServer.Text = "Connect";
            this.btnConnectServer.UseVisualStyleBackColor = false;
            this.btnConnectServer.Click += new System.EventHandler(this.btnConnectServer_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(113, 34);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(310, 20);
            this.txtServerName.TabIndex = 1;
            this.txtServerName.TextChanged += new System.EventHandler(this.txtServerName_TextChanged);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServerName.Location = new System.Drawing.Point(7, 37);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(99, 14);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "SQL Server Name:";
            // 
            // groupBoxDatabase
            // 
            this.groupBoxDatabase.Controls.Add(this.cbDbName);
            this.groupBoxDatabase.Controls.Add(this.lblDatabaseName);
            this.groupBoxDatabase.Location = new System.Drawing.Point(12, 188);
            this.groupBoxDatabase.Name = "groupBoxDatabase";
            this.groupBoxDatabase.Size = new System.Drawing.Size(623, 72);
            this.groupBoxDatabase.TabIndex = 6;
            this.groupBoxDatabase.TabStop = false;
            this.groupBoxDatabase.Text = "Database Authentication";
            // 
            // cbDbName
            // 
            this.cbDbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDbName.FormattingEnabled = true;
            this.cbDbName.Items.AddRange(new object[] {
            "Please select a database to backup"});
            this.cbDbName.Location = new System.Drawing.Point(113, 34);
            this.cbDbName.Name = "cbDbName";
            this.cbDbName.Size = new System.Drawing.Size(488, 21);
            this.cbDbName.TabIndex = 4;
            this.cbDbName.SelectedIndexChanged += new System.EventHandler(this.cbDbName_SelectedIndexChanged);
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDatabaseName.Location = new System.Drawing.Point(7, 37);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(92, 14);
            this.lblDatabaseName.TabIndex = 0;
            this.lblDatabaseName.Text = "Database Name:";
            // 
            // groupBoxOutputPath
            // 
            this.groupBoxOutputPath.Controls.Add(this.btnBackup);
            this.groupBoxOutputPath.Controls.Add(this.btnBrowse);
            this.groupBoxOutputPath.Controls.Add(this.txtLocation);
            this.groupBoxOutputPath.Controls.Add(this.lblBackupPath);
            this.groupBoxOutputPath.Location = new System.Drawing.Point(12, 279);
            this.groupBoxOutputPath.Name = "groupBoxOutputPath";
            this.groupBoxOutputPath.Size = new System.Drawing.Size(623, 72);
            this.groupBoxOutputPath.TabIndex = 7;
            this.groupBoxOutputPath.TabStop = false;
            this.groupBoxOutputPath.Text = "Backup Configuration";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBackup.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackup.Location = new System.Drawing.Point(526, 31);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 6;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrowse.Location = new System.Drawing.Point(445, 31);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(113, 34);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(310, 20);
            this.txtLocation.TabIndex = 2;
            // 
            // lblBackupPath
            // 
            this.lblBackupPath.AutoSize = true;
            this.lblBackupPath.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBackupPath.Location = new System.Drawing.Point(7, 37);
            this.lblBackupPath.Name = "lblBackupPath";
            this.lblBackupPath.Size = new System.Drawing.Size(55, 14);
            this.lblBackupPath.TabIndex = 0;
            this.lblBackupPath.Text = "Location:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerBackup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup Schedule";
            // 
            // dateTimePickerBackup
            // 
            this.dateTimePickerBackup.Location = new System.Drawing.Point(113, 34);
            this.dateTimePickerBackup.Name = "dateTimePickerBackup";
            this.dateTimePickerBackup.Size = new System.Drawing.Size(488, 20);
            this.dateTimePickerBackup.TabIndex = 1;
            this.dateTimePickerBackup.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date/Time:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBarBackup);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 72);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup Status";
            // 
            // progressBarBackup
            // 
            this.progressBarBackup.Location = new System.Drawing.Point(113, 32);
            this.progressBarBackup.Name = "progressBarBackup";
            this.progressBarBackup.Size = new System.Drawing.Size(488, 23);
            this.progressBarBackup.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Progress:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 577);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxOutputPath);
            this.Controls.Add(this.groupBoxDatabase);
            this.Controls.Add(this.groupBoxServerAuthentication);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxServerAuthentication.ResumeLayout(false);
            this.groupBoxServerAuthentication.PerformLayout();
            this.groupBoxDatabase.ResumeLayout(false);
            this.groupBoxDatabase.PerformLayout();
            this.groupBoxOutputPath.ResumeLayout(false);
            this.groupBoxOutputPath.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxServerAuthentication;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.GroupBox groupBoxDatabase;
        private System.Windows.Forms.ComboBox cbDbName;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.GroupBox groupBoxOutputPath;
        private System.Windows.Forms.Label lblBackupPath;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnConnectServer;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBarBackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

