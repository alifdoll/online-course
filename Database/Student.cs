using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Student : IDatabase
    {
        private string id;
        private string name;
        private string username;
        private string password;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        private string Password { get => password; set => password = value; }

        public Student(string id,  string username, string password, string name)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }

        public void Insert()
        {
            string command = $"INSERT INTO Student(Id, Username, Password, Name) VALUES('{Id}', '{Username}', '{Password}', '{Name.Replace("'", "\\'")}'";
            Execute.DML(command);
        }

        public void Update()
        {
            string command = $"UPDATE Student SET Username='{Username}', Password='{Password}', Name='{Name.Replace("'", "\\'")}' WHERE Id='{id}'";
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
            catch(Exception error)
            {
                return $"{error.Message}, SQL Command : {command}";
            }
        }

        public ArrayList QueryData(string criteria = "", string value = "")
        {
            string command;
            if(criteria == "")
            {
                command = $"SELECT * FROM Student";
            }
            else
            {
                command = $"SELECT * FROM Student WHERE {criteria} LIKE '%{value}%'";
            }

            MySqlDataReader result = Execute.Query(command);

            ArrayList list = new ArrayList();

            while(result.Read() == true)
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
    }
}
