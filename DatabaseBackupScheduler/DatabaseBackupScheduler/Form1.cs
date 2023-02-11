using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseBackupScheduler
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private SqlCommand cmd;
        private SqlDataReader reader;
        String sql = "";
        String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtServerName.Text = System.Net.Dns.GetHostName().ToUpper() + @"\SQLEXPRESS";
            cbDbName.SelectedIndex = 0;
            txtLocation.Text = @"D:\DatabaseBackupScheduler\DatabaseBackupOutput";
            cbDbName.Enabled = false;
            btnBrowse.Enabled = false;
            btnBackup.Enabled = false;
            txtLocation.Enabled = false;
        }

        private void btnConnectServer_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                connectionString = "Data Source = " + txtServerName.Text.Trim() + "; Trusted_Connection = True;";
                connection = new SqlConnection(connectionString);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    sql = "SELECT * FROM sys.databases d WHERE d.database_id > 4";
                    cmd = new SqlCommand(sql, connection);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cbDbName.Items.Add(reader[0].ToString());
                    }
                    txtServerName.Enabled = false;
                    btnConnectServer.Enabled = false;
                    cbDbName.Enabled = true;
                    btnBrowse.Enabled = true;
                    btnBackup.Enabled = true;
                    txtLocation.Enabled = false;
                    dateTimePickerBackup.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Cursor = Cursors.Default;
        }
        
        private void cbDbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDbName.SelectedIndex != 0)
            {
                txtLocation.Enabled = true;
                btnBrowse.Enabled = true;
            }
            else
            {
                txtLocation.Clear();
                txtLocation.Enabled = false;
                btnBrowse.Enabled = false;
                btnBrowse.Enabled = true;
            }
        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {
            if (txtLocation.Text.Trim() != string.Empty)
            {
                btnBackup.Enabled = true;
            }
            else
            {
                btnBackup.Enabled = false;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            String dbName = cbDbName.Text;
            String location = txtLocation.Text.Trim();

            if (string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Please select the location for the backup file.");
                Cursor = Cursors.Default;
                return;
            }

            String backupFilePath = location + "\\" + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + ".bak";

            try
            {
                BackupDatabase(dbName, backupFilePath);
                MessageBox.Show("Database Backup Successfully Completed! \nLocation: " + backupFilePath, "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;
            isFileExist(backupFilePath);
        }

        private void BackupDatabase(String dbName, String fileName)
        {
            log(fileName);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                sql = "BACKUP DATABASE " + dbName + " TO DISK = '" + fileName + "'";
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            connection.Dispose();

        }

        private void log(String message)
        {
            Console.WriteLine(message);
        }

        private void isFileExist(String backupFilePath)
        {
            if (File.Exists(backupFilePath))
            {
                MessageBox.Show(backupFilePath + " file exists!");
            }
            else
            {
                MessageBox.Show(backupFilePath + " file does not exist.");
            }
        }
    }
}
