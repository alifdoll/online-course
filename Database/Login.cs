﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Login
    {
        public static string StudentLogin(string username, string password)
        {
            _ = new DbConnect("127.0.0.1", "online_course_db", "root", "");
            string user = "";

            string command = $"SELECT * FROM Student WHERE username='{username}' AND password='{password}'";

            MySqlDataReader result = Execute.Query(command);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    user = result.GetString(0);
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
            _ = new DbConnect("127.0.0.1", "online_course_db", "root", "");
            string instruct = "";

            string command = $"SELECT * FROM Instructor WHERE username='{username}' AND password='{password}'";

            MySqlDataReader result = Execute.Query(command);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    instruct = result.GetString(0);
                }
            }
            else
            {
                instruct = "0";
            }
            return instruct;
        }

    }
}