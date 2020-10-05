using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IDatabase 
    {
         void Insert();

         void Update();

         string Delete();

        ArrayList QueryData(string criteria = "", string value = "");

        string GeneratePrimaryKey();
    }
}
