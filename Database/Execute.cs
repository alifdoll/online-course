using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Database
{
    public class Execute
    {
        public static void DML(string query)
        {
            DbConnect connect = new DbConnect();
            connect.ConnecTotDB();
            MySqlCommand command = new MySqlCommand(query, connect.Connection);
            command.ExecuteNonQuery();
        }

        public static MySqlDataReader Query(string query)
        {
            DbConnect connect = new DbConnect();
            MySqlCommand command = new MySqlCommand(query, connect.Connection);
            MySqlDataReader result = command.ExecuteReader();
            return result;
        }
    }
}
