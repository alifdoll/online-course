using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Database
{
    public class DbConnect
    {
        private MySqlConnection connection;

        public MySqlConnection Connection { get => connection; set => connection = value; }

        public DbConnect()
        {
            Connection = new MySqlConnection();

            Connection.ConnectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;

            ConnecTotDB();
        }

        public DbConnect(string server, string database, string username, string password)
        {
            string connection;
            if(password != "")
            {
                connection = $"Server={server};Database={database};Uid={username};Pwd={password};";
            }
            else
            {
                connection = $"Server={server};Database={database};Uid={username};";
            }

            Connection = new MySqlConnection
            {
                ConnectionString = connection
            };
            ConnecTotDB();
            UpdateAppConfig(connection);
        }

        public void ConnecTotDB()
        {
            if(Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }

            Connection.Open();
        }

        public void UpdateAppConfig(string connection)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.ConnectionStrings.ConnectionStrings["database"].ConnectionString = connection;
            configuration.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        
    }
}
