namespace Database
{
    public class Session
    {
        private string id;
        private string name;
        private string user;
        private static Session instance;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string User { get => user; set => user = value; }


        private Session()
        {
            Id = "";
            Name = "";
            User = "";
        }


        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }



        public void SessionClear()
        {
            Id = "";
            Name = "";
            User = "";
        }

    }
}
