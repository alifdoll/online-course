using MySql.Data.MySqlClient;

namespace Database
{
    public class Login
    {
        public static string StudentLogin(string username, string password)
        {
            DbConnect dbConnect = new DbConnect("127.0.0.1", "online_course", "o_course_student", "student");
            string user = "";

            string command = $"SELECT * FROM Student WHERE username='{username}' AND password='{password}'";

            MySqlDataReader result = Execute.Query(command);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    user = result.GetString(1);
                }
                result.Close();

            }
            else
            {
                user = "0";
            }
            return user;
        }

        public static string InstructorLogin(string username, string password)
        {
            DbConnect dbConnect = new DbConnect("127.0.0.1", "online_course", "o_course_instruc", "instructor");
            string instruct = "";

            string command = $"SELECT * FROM Instructor WHERE username='{username}' AND password='{password}'";

            MySqlDataReader result = Execute.Query(command);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    instruct = result.GetString(1);
                }
                result.Close();
            }
            else
            {
                instruct = "0";
            }
            return instruct;
        }

        public static void AdminLogin(string username = "o_course_admin", string password = "admin")
        {
            DbConnect connect = new DbConnect("127.0.0.1", "online_course", username, password);
        }

        public static void CloseConnection()
        {
            DbConnect connect = new DbConnect();

            if (connect.Connection.State == System.Data.ConnectionState.Open)
            {
                //connect.CloseConnection();
                connect.Exit();
            }

        }

    }
}
