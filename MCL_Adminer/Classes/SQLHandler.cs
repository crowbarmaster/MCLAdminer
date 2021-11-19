using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MCL_Adminer
{
    internal class SQLHandler
    {
        public SQLHandler()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "xx.xx.xx.xx";
            database = "mcl_db";
            uid = "mcl_db";
            port = "8236";
            password = "password";
            string connectionString = "server=" + server + ";UID=" + uid + ";database=" + database + ";port=" + port + ";password=" + password;
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            bool result;
            try
            {
                connection.Open();
                result = true;
            }
            catch (MySqlException ex)
            {
                int number = ex.Number;
                int num = number;
                if (num != 0)
                {
                    if (num == 1045)
                    {
                        MessageBox.Show("Invalid username/password, please try again");
                    }
                }
                else
                {
                    MessageBox.Show("Cannot connect to server.  Contact administrator");
                }
                result = false;
            }
            return result;
        }

        private bool CloseConnection()
        {
            bool result;
            try
            {
                connection.Close();
                result = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            return result;
        }

        public void Insert(string tableName, string[] keys, string[] values)
        {
            string query = "INSERT INTO " + tableName + " (";
            foreach (string s in keys)
            {
                query = query + s + ", ";
            }
            query = query.Substring(0, query.Length - 2) + ") VALUES (";
            foreach (string s2 in values)
            {
                query = query + s2 + ", ";
            }
            query = query.Substring(0, query.Length - 2) + ")";
            bool flag = OpenConnection();
            if (flag)
            {
                MySqlCommand SQLcmd = new MySqlCommand(query, connection);
                SQLcmd.ExecuteNonQuery();
                Console.WriteLine("Insert completed on table: " + tableName);
                CloseConnection();
            }
        }

        public void Update(string tableName, string[] data, string[] cond)
        {
            string query = "UPDATE " + tableName + " SET ";
            foreach (string s in data)
            {
                query = query + s + ", ";
            }
            query = query.Substring(0, query.Length - 2) + " WHERE ";
            foreach (string s2 in cond)
            {
                query = query + s2 + ", ";
            }
            query = query.Substring(0, query.Length - 2);
            bool flag = OpenConnection();
            if (flag)
            {
                new MySqlCommand
                {
                    CommandText = query,
                    Connection = connection
                }.ExecuteNonQuery();
                Console.WriteLine("Update completed on table: " + tableName);
                CloseConnection();
            }
        }

        public void Delete(string tableName, string cond)
        {
            string query = "DELETE FROM " + tableName + " WHERE " + cond;
            bool flag = OpenConnection();
            if (flag)
            {
                MySqlCommand SQLcmd = new MySqlCommand(query, connection);
                SQLcmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public List<string[]> Select(string tableName, string[] select, string[] cond)
        {
            string query = "SELECT ";
            foreach (string s in select)
            {
                query = query + s + ", ";
            }
            query = query.Substring(0, query.Length - 2) + " FROM " + tableName;
            bool flag = cond != null;
            if (flag)
            {
                query += " WHERE ";
                foreach (string s2 in cond)
                {
                    query = query + s2 + ", ";
                }
                query = query.Substring(0, query.Length - 2);
            }
            List<string[]> list = new List<string[]>();
            bool flag2 = OpenConnection();
            List<string[]> result;
            if (flag2)
            {
                MySqlCommand SQLcmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = SQLcmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int count = dataReader.FieldCount;
                    string[] tmp = new string[count];
                    for (int i = 0; i < count; i++)
                    {
                        tmp[i] = dataReader.GetString(i);
                    }
                    list.Add(tmp);
                }
                dataReader.Close();
                CloseConnection();
                result = list;
            }
            else
            {
                result = list;
            }
            return result;
        }

        public int Count(string tableName)
        {
            string query = "SELECT Count(*) FROM " + tableName;
            int Count = -1;
            bool flag = OpenConnection();
            int result;
            if (flag)
            {
                MySqlCommand SQLcmd = new MySqlCommand(query, connection);
                object obj = SQLcmd.ExecuteScalar();
                Count = int.Parse(((obj != null) ? obj.ToString() : null) ?? "");
                CloseConnection();
                result = Count;
            }
            else
            {
                result = Count;
            }
            return result;
        }

        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;
                string path = string.Concat(new string[]
                {
                    "C:\\MySqlBackup",
                    year.ToString(),
                    "-",
                    month.ToString(),
                    "-",
                    day.ToString(),
                    "-",
                    hour.ToString(),
                    "-",
                    minute.ToString(),
                    "-",
                    second.ToString(),
                    "-",
                    millisecond.ToString(),
                    ".sql"
                });
                StreamWriter file = new StreamWriter(path);
                Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = "mysqldump",
                    RedirectStandardInput = false,
                    RedirectStandardOutput = true,
                    Arguments = string.Format("-u{0} -p{1} -h{2} {3}", new object[]
                    {
                        uid,
                        password,
                        server,
                        database
                    }),
                    UseShellExecute = false
                });
                string output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        public void Restore()
        {
            try
            {
                string path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();
                Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = "mysql",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = false,
                    Arguments = string.Format("-u{0} -p{1} -h{2} {3}", new object[]
                    {
                        uid,
                        password,
                        server,
                        database
                    }),
                    UseShellExecute = false
                });
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string port;
        private string password;
    }
}
