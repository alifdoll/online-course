using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Course : IDatabase
    {
        #region members
        private string id;
        private string name;
        private string desc;
        private string lang;
        private DateTime release;
        private double price;
        private Topic topic;
        private Instructor instructor;
        #endregion

        #region constructor
        public Course(int id, string name, string desc, string lang, DateTime release, double price,Topic topic, Instructor instructor)
        {
            Id = Id;
            Name = Name;
            Desc = Desc;
            Lang = Lang;
            Release = Release;
            Topic = Topic;
            Instructor = Instructor;
            Price = price;
        }
        #endregion

        #region properties
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Lang { get => lang; set => lang = value; }
        public DateTime Release { get => release; set => release = value; }
        public double Price { get => price; set => price = value; }
        public Topic Topic { get => topic; set => topic = value; }
        public Instructor Instructor { get => instructor; set => instructor = value; }
        #endregion

        #region methods

        public void Insert()
        {
            string command = $"INSERT INTO Course(Id, Name, Description, Language, Release_Date, Price, Id_Topic, Id_Instructor)" +
                $"Values('{Id}', '{Name.Replace("'", "\\")}', '{Desc}', '{Lang}', '{Release:yyyy-MM-dd}', '{Price}', '{Topic.Id}', '{Instructor.Id}')";

            Execute.DML(command);
        }

        public void Update()
        {
            string command = $"UPDATE Course set nama='{Name}', description='{Desc}', language='{Lang}', Release_Date='{Release:yyy-MM-dd}', Price='{Price}'" +
                 $"WHERE Id='{Id}'";
            Execute.DML(command);
        }

        public string Delete()
        {
            string command = $"DELETE FROM Course WHERE Id='{Id}'";

            try
            {
                Execute.DML(command);
                return "1";
            }
            catch(Exception error)
            {
                return $"{error.Message}, Command : {command}";
            }
        }

        public string GeneratePrimaryKey()
        {
            string command = $"SELECT Max(Right(Id,3)) FROM Course WHERE Id_Topic='{Topic.Id}'";
            string code = "";

            MySqlDataReader result = Execute.Query(command);

            if (result.Read())
            {
                if(result.GetValue(0).ToString() != "")
                {
                    int newcode = result.GetInt32(0) + 1;
                    code = Instructor.Id + newcode;
                }
                else
                {
                    code = Instructor.Id + "001";
                }

            }
            return code;


        }

        public ArrayList QueryData(string criteria = "", string value = "")
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
