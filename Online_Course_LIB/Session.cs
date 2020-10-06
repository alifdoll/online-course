using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Session
    {
        private string name;
        private static Session instance;

        public string Name { get => name; set => name = value; }

        
        private Session()
        {
            Name = "";
        }
       

        public static Session Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }

        public void SessionClear()
        {
            Name = "";
        }

    }
}
