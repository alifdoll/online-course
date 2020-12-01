using MySql.Data.MySqlClient;
using System;
using System.Collections;

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
        public Course(string id, string name, string desc, string lang, double price, DateTime release, Topic topic, Instructor instructor)
        {
            Id = id;
            Name = name;
            Desc = desc;
            Lang = lang;
            Release = release;
            Topic = topic;
            Instructor = instructor;
            Price = price;
        }

        public Course(string id = "", string name = "", string desc = "", string lang = "", double price = 0)
        {
            Id = id;
            Name = name;
            Desc = desc;
            Lang = lang;
            Release = DateTime.Now;
            Topic = new Topic();
            Instructor = new Instructor();
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
            string command = $"INSERT INTO Course(Id, Nama, Description, Language, harga, Release_Date, Id_Topic, Id_Instructor) " +
                $"Values('{Id}', '{Name.Replace("'", "\\")}', '{Desc}', '{Lang}', '{Price}', '{Release:yyyy-MM-dd}', '{Topic.Id}', '{Instructor.Id}')";

            Execute.DML(command);
        }

        public void Update()
        {
            string command = $"UPDATE Course set nama='{Name}', description='{Desc}', language='{Lang}', Release_Date='{Release:yyy-MM-dd}', Harga='{Price}', Id_Topic='{Topic.Id}'" +
                 $" WHERE Id='{Id}'";
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
            catch (Exception error)
            {
                return $"{error.Message}, Command : {command}";
            }
        }

        public string GeneratePrimaryKey()
        {
            string command = $"SELECT Max(Right(Id,3)) FROM Course WHERE course.id_instructor='{Instructor.Id}'";
            string code = "";

            MySqlDataReader result = Execute.Query(command);

            if (result.Read())
            {
                if (result.GetValue(0).ToString() != "")
                {
                    int newcode = result.GetInt32(0) + 1;
                    code = Instructor.Id + newcode.ToString().PadLeft(3, '0');
                }
                else
                {
                    code = Instructor.Id + "001";
                }

            }
            return code;

        }

        public string GeneratePrimaryKey(Instructor instructor)
        {
            Instructor = instructor;
            return GeneratePrimaryKey();
        }

        public ArrayList QueryData(string criteria = "", string value = "")
        {
            string command;
            if (criteria == "")
            {
                command =
                    "SELECT course.id, course.nama, course.description, course.language, course.harga, course.release_date, course.id_topic, topic.nama, course.id_instructor, instructor.nama " +
                    "FROM course " +
                    "INNER JOIN topic on course.id_topic = topic.id " +
                    "INNER JOIN instructor on course.id_instructor = instructor.id ";
            }
            else
            {
                command =
                    "SELECT course.id, course.nama, course.description, course.language, course.harga, course.release_date, course.id_topic, topic.nama, course.id_instructor, instructor.nama " +
                    "FROM course " +
                    "INNER JOIN topic on course.id_topic = topic.id " +
                    "INNER JOIN instructor on course.id_instructor = instructor.id " +
                    $"WHERE {criteria} LIKE '%{value}%' AND instructor.id LIKE '%{value}%'";
            }

            MySqlDataReader result = Execute.Query(command);

            ArrayList list = new ArrayList();

            while (result.Read() == true)
            {
                Topic topic = new Topic(result.GetValue(6).ToString(), result.GetValue(7).ToString());

                Instructor instructor = new Instructor(result.GetValue(8).ToString(), result.GetValue(9).ToString());

                Course course = new Course(
                    result.GetValue(0).ToString(),
                    result.GetValue(1).ToString(),
                    result.GetValue(2).ToString(),
                    result.GetValue(3).ToString(),
                    result.GetDouble(4),
                    result.GetDateTime(5),
                    topic,
                    instructor);

                list.Add(course);
            }

            return list;
        }

        public ArrayList QueryData(string criteria = "", string value = "", string instructorId = "")
        {
            string command =
                    "SELECT course.id, course.nama, course.description, course.language, course.harga, course.release_date, course.id_topic, topic.nama, course.id_instructor, instructor.nama " +
                    "FROM course " +
                    "INNER JOIN topic on course.id_topic = topic.id " +
                    "INNER JOIN instructor on course.id_instructor = instructor.id " +
                    $"WHERE {criteria} LIKE '%{value}%' AND instructor.id LIKE '%{instructorId}%'";


            MySqlDataReader result = Execute.Query(command);

            ArrayList list = new ArrayList();

            while (result.Read() == true)
            {
                Topic topic = new Topic(result.GetValue(6).ToString(), result.GetValue(7).ToString());

                Instructor instructor = new Instructor(result.GetValue(8).ToString(), result.GetValue(9).ToString());

                Course course = new Course(
                    result.GetValue(0).ToString(),
                    result.GetValue(1).ToString(),
                    result.GetValue(2).ToString(),
                    result.GetValue(3).ToString(),
                    result.GetDouble(4),
                    result.GetDateTime(5),
                    topic,
                    instructor);

                list.Add(course);
            }

            return list;
        }




        #endregion
    }
}
