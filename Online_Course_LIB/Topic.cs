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

        #region data members
        private string id;
        private string name;
        #endregion

        #region properties
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        #endregion

        #region constructors
        public Topic(string id = " ", string name = " ")
        {
            Id = id;
            Name = name;
        }

        #endregion

        #region methods
        public void Insert()
        {
            string command = $"INSERT INTO Topic(Id, Nama) VALUES('{Id}', '{Name.Replace("'", "\\'")}')";
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
                command = "SELECT * FROM topic";
            }
            else
            {
                command = $"SELECT * FROM topic WHERE {criteria} LIKE '%{value}%'";
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

        public string GeneratePrimaryKey()
        {
            string command = "SELECT Max(Id) FROM Topic";

            int pKey;

            MySqlDataReader result = Execute.Query(command);

            if(result.Read())
            {
                pKey = result.GetInt32(0) + 1;

            }
            else
            {
                pKey = 1;
            }
            string newId = pKey.ToString().PadLeft(2, '0');
            return newId;
        }
        #endregion

    }
}
