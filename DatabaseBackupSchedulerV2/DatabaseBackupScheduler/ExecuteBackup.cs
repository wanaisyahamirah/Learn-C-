using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace DatabaseBackupScheduler
{
    class ExecuteBackup
    {
        private SqlConnection connection;
        private SqlCommand cmd;
        String sql = "";
        String connectionString = "";

        public void Backup()
        {
            ExecuteBackup exe = new ExecuteBackup();
            SqlConnection sqlCon = new SqlConnection();
        }

        public void ConnectServer(String serverName, String username, String pwd)
        {
            try
            {
                connectionString = "Server = " + serverName + "; User Id = " + username + "; Password = " + pwd + ";";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    GetDatabasesServerInstanceQuery();

                    cmd = new SqlCommand(sql, connection);                    
                }

            }
            catch (Exception ex)
            {
                WriteLog(ex);
            }
        }

        public SqlConnection ConnenctionObject(String serverName, String username, String pwd)
        {
            try
            {                
                if(username.Trim().Equals(""))
                {
                    connectionString = "Data Source = " + serverName + "; Trusted_Connection = True;";
                }
                else
                {
                    connectionString = "Server = " + serverName + "; User Id = " + username + "; Password = " + pwd + ";";
                }             

                return new SqlConnection(connectionString);

            }
            catch (Exception ex)
            {
                WriteLog(ex);
                return null;
            }
        }

        public int ExecuteNonQuery(String sql, String serverName, String username, String pwd)
        {
           
            SqlConnection sqlcn = ConnenctionObject(serverName ,username,pwd);
            return ExecuteNonQuery(sql, sqlcn);
        }

        public int ExecuteNonQuery(String sql, SqlConnection sqlcn)
        {
            try
            {               
                SqlCommand cmd = new SqlCommand(sql, sqlcn);
                return  cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                WriteLog(ex);
                throw;
            }
        }

        public SqlDataReader ExecuteReader(String sql, String serverName, String username, String pwd)
        {

            SqlConnection sqlcn = ConnenctionObject(serverName, username, pwd);
            return ExecuteReader(sql, sqlcn);
        }

        public SqlDataReader ExecuteReader(String sql, SqlConnection sqlcn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, sqlcn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                WriteLog(ex);
                throw;
            }
        }        

        public List<String> ListDatabasename(String serverName, String username, String pwd)
        {
            
            SqlDataReader reader = this.ExecuteReader(GetDatabasesServerInstanceQuery(), serverName, username,pwd);

            try
            {
                List<String> list = new List<string>();

                while (reader.Read())
                {
                    list.Add(reader[0].ToString());
                }

                return list;
            }
            finally
            {
                reader.Close();
               
            }
        }

        public String  GetDatabasesServerInstanceQuery()
        {
            return  "SELECT * FROM sys.databases d WHERE d.database_id > 4";
        }

        public void WriteLog(Exception ex)
        {
            using (StreamWriter writer = new StreamWriter("error.log", true))
            {
                writer.WriteLine("Date: " + DateTime.Now.ToString());
                writer.WriteLine("Message: " + ex.Message);
                writer.WriteLine("Stack Trace: " + ex.StackTrace);
                writer.WriteLine();
            }
        }

        private void BackupDatabase(String dbName, String directory)
        {

            String backupOutputPath = directory + "\\" + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + ".bak";

            try
            {
                ExecuteBackupQuery(dbName, backupOutputPath);
            }
            catch (Exception ex)
            {

            }
        }

        private void ExecuteBackupQuery(String dbName, String backupOutputPath)
        {
            log(backupOutputPath);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                sql = "BACKUP DATABASE " + dbName + " TO DISK = '" + backupOutputPath + "' with init";
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            connection.Dispose();

        }

        private void log(String message)
        {
            Console.WriteLine(message);
        }

    }
}
