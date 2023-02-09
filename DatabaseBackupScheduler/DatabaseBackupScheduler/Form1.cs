using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseBackupScheduler
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private SqlCommand cmd;
        private SqlDataReader reader;
        String sql = "";
        String connectionString = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtServerName.Text = System.Net.Dns.GetHostName().ToUpper() + @"\SQLEXPRESS";
            cbDbName.SelectedIndex = 0;
        }

        private void btnConnectServer_Click(object sender, EventArgs e)
        {
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
                    txtLocation.Enabled = true;
                    dateTimePickerBackup.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnectServer_Click(object sender, EventArgs e)
        {
            txtServerName.Enabled = true;
            btnConnectServer.Enabled = true;
            cbDbName.Items.Clear();
            cbDbName.Items.Add("Please select a database to backup");
            cbDbName.SelectedIndex = 0;
            cbDbName.Enabled = false;
            btnBrowse.Enabled = false;
            btnBackup.Enabled = false;
            txtLocation.Enabled = false;
            dateTimePickerBackup.Enabled = false;
        }

        private void cbDbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDbName.SelectedIndex != 0)
            {
                txtLocation.Enabled = true;
                btnBrowse.Enabled = true;
                txtLocation.Enabled = true;
            }
            else
            {
                txtLocation.Clear();
                txtLocation.Enabled = false;
                btnBrowse.Enabled = false;
                btnBrowse.Enabled = true;
            }
            txtLocation.Clear();
        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {
            if(txtLocation.Text.Trim() != string.Empty)
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
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    sql = "BACKUP DATABASE " + cbDbName.Text + " TO DISK = '" + txtLocation.Text.Trim() + "\\" + cbDbName.Text + "_" + DateTime.Now.ToString("yyyyMMdd") + ".bak'";
                    cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                }
                connection.Dispose();
                MessageBox.Show("Database Backup Successfully Completed!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
