using MySql.Data.MySqlClient;
using System.Configuration;

namespace Database
{
    public class DbConnect
    {
        private MySqlConnection connection;

        public MySqlConnection Connection { get => connection; set => connection = value; }

        public DbConnect(string server, string database, string username, string password)
        {
            string connection;
            if (password != "")
            {
                connection = $"Server={server};Database={database};Uid={username};Pwd={password};";
            }
            else
            {
                connection = $"Server={server};Database={database};Uid={username};";
            }

            Connection = new MySqlConnection();

            Connection.ConnectionString = connection;

            ConnectTotDB();
            UpdateAppConfig(connection);
        }

        public DbConnect()
        {
            Connection = new MySqlConnection();

            Connection.ConnectionString = ConfigurationManager.ConnectionStrings["online_course"].ConnectionString;

            ConnectTotDB();
        }

        public void ConnectTotDB()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
                Connection.Open();
            }
            else
            {
                Connection.Open();
            }

        }

        public void CloseConnection()
        {
            Connection.Close();
        }

        public void Exit()
        {
            Connection.Dispose();
        }

        public void UpdateAppConfig(string connection)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.ConnectionStrings.ConnectionStrings["online_course"].ConnectionString = connection;
            configuration.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }


    }
}
