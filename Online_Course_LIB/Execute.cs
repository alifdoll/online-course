using MySql.Data.MySqlClient;

namespace Database
{
    public class Execute
    {
        private static MySqlDataReader result;

        public static MySqlDataReader Result { get => result; set => result = value; }

        public static void DML(string query)
        {
            DbConnect connect = new DbConnect();
            connect.ConnectTotDB();
            MySqlCommand command = new MySqlCommand(query, connect.Connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public static MySqlDataReader Query(string query)
        {
            DbConnect connect = new DbConnect();
            MySqlCommand command = new MySqlCommand(query, connect.Connection);
            Result = command.ExecuteReader();
            return Result;
        }

        public static void CloseReader()
        {
            Result.Close();
        }
    }
}
