using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Instructor
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

        public Instructor(string id, string name, string username, string password, string bio)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
            Biography = bio;
        }
    }
}
