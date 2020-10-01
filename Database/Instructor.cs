using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Instructor : IDatabase
    {
        private string id;
        private string name;
        private string username;
        private string password;
        private string biography;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        private string Password {  get => password; set => password = value; }
        public string Biography { get => biography; set => biography = value; }

        public Instructor(string id, string username, string password, string name, string bio)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
            Biography = bio;
        }

        public void Insert()
        {
            string command = $"INSERT INTO Instructor(Id, Username, Password, Nama, Bio) VALUES ('{Id}', '{Username}', '{Password}', '{Name.Replace("'", "\\'")}', '{Biography}')";
            Execute.DML(command);
        }

        public void Update()
        {
            string command = $"UPDATE Instructor SET Username='{Username}', Password='{Password}', Nama='{Name.Replace("'", "\\'")}', Bio='{Biography}' WHERE Id='{Id}'";
            Execute.DML(command);
        }

        public string Delete()
        {
            string command = $"DELETE FROM Instructor WHERE Id='{Id}'";
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
            if (criteria == "")
            {
                command = "SELECT * FROM Instructor";
            }
            else
            {
                command = $"SELECT * FROM Instructor WHERE {criteria} LIKE %'{value}%'";
            }

            MySqlDataReader result = Execute.Query(command);

            ArrayList list = new ArrayList();

            while (result.Read() == true)
            {
                Instructor instructor = new Instructor(
                    result.GetValue(0).ToString(),
                    result.GetValue(1).ToString(),
                    result.GetValue(2).ToString(),
                    result.GetValue(3).ToString(),
                    result.GetValue(4).ToString());

                list.Add(instructor);
            }

            return list;
        }
    }
}
