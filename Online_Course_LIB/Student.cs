using MySql.Data.MySqlClient;
using System;
using System.Collections;

namespace Database
{
    public class Student : IDatabase
    {
        #region data members
        private string id;
        private string name;
        private string username;
        private string password;
        #endregion

        #region properties
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        private string Password { get => password; set => password = value; }
        #endregion

        #region constructors
        public Student(string id = "", string name = "", string username = "", string password = "")
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }
        #endregion

        #region methods
        public void Insert()
        {
            string command = $"INSERT INTO Student(Id, Username, Password, Nama) VALUES ('{Id}', '{Username}', '{Password}', '{Name.Replace("'", "\\'")}')";
            Execute.DML(command);
        }

        public void Update()
        {
            string command = $"UPDATE Student SET Username='{Username}', Password='{Password}', Nama='{Name.Replace("'", "\\'")}' WHERE Id='{id}'";
            Execute.DML(command);
        }

        public string Delete()
        {
            string command = $"DELETE FROM Student WHERE Id='{Id}'";

            try
            {
                Execute.DML(command);
                return "1";
            }
            catch (Exception error)
            {
                return $"{error.Message}, SQL Command : {command}";
            }
        }

        public ArrayList QueryData(string criteria = "", string value = "")
        {
            string command;
            if (criteria == "")
            {
                command = $"SELECT * FROM Student";
            }
            else
            {
                command = $"SELECT * FROM Student WHERE {criteria} LIKE '%{value}%'";
            }

            MySqlDataReader result = Execute.Query(command);

            ArrayList list = new ArrayList();

            while (result.Read() == true)
            {
                Student student = new Student(
                    result.GetValue(0).ToString(),
                    result.GetValue(1).ToString(),
                    result.GetValue(2).ToString(),
                    result.GetValue(3).ToString());

                list.Add(student);
            }

            return list;
        }

        public string GeneratePrimaryKey()
        {
            string command = "SELECT Max(Id) FROM Student";
            int pKey;

            MySqlDataReader result = Execute.Query(command);

            if (result.Read() == true)
            {
                pKey = result.GetInt32(0) + 1;
            }
            else
            {
                pKey = 1;
            }

            return pKey.ToString();
        }

        public string GetPass()
        {
            string masked = Password;
            if (Password.Length > 0)
            {
                string.Concat("".PadLeft(Password.Length, '*'), masked.Substring(masked.Length));
            }
            return masked;
        }
        #endregion







    }
}
