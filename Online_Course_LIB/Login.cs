using MySql.Data.MySqlClient;

namespace Database
{
    public class Login
    {
        public static string StudentLogin(string username, string password)
        {
            _ = new DbConnect("127.0.0.1", "online_course", "root", "");
            string user = "";

            string command = $"SELECT * FROM Student WHERE username='{username}' AND password='{password}'";

            MySqlDataReader result = Execute.Query(command);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    user = result.GetString(1);
                }

            }
            else
            {
                user = "0";
            }
            return user;
        }

        public static string InstructorLogin(string username, string password)
        {
            _ = new DbConnect("127.0.0.1", "online_course", "root", "");
            string instruct = "";

            string command = $"SELECT * FROM Instructor WHERE username='{username}' AND password='{password}'";

            MySqlDataReader result = Execute.Query(command);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    instruct = result.GetString(1);
                }
            }
            else
            {
                instruct = "0";
            }
            return instruct;
        }

        public static void AdminLogin(string username = "root", string password = "")
        {
            DbConnect connect = new DbConnect("127.0.0.1", "online_course", username, password);
        }

    }
}
