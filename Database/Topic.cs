using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Database
{
    public class Topic : IDatabase
    {
        private string id;
        private string name;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    
        public Topic(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Insert()
        {
            string command = $"INSERT INTO Topic(Id, Nama) VALUES('{Id}', {Name.Replace("'", "\\'")}')";
            Execute.DML(command);
        }

        public void Update()
        {
            string command = $"UPDATE Topic SET Nama='{Name.Replace("'", "\\'")}' WHERE Id='{Id}'";
            Execute.DML(command);
        }

        public string Delete()
        {
            string command = $"DELETE FROM Topic WHERE Id='{Id}'";
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
                command = "SELECT * FROM Topic";
            }
            else
            {
                command = $"SELECT * FROM Topic WHHERE {criteria} LIKE '%{value}%'";
            }

            MySqlDataReader result = Execute.Query(command);

            ArrayList list = new ArrayList();

            while (result.Read() == true)
            {
                Topic topic = new Topic(result.GetValue(0).ToString(), result.GetValue(1).ToString());
                list.Add(topic);
            }

            return list;
        }
    }
}
