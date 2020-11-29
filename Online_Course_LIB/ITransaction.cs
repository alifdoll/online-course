using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface ITransaction
    {
        void Insert();

        ArrayList QueryData(string criteria = "", string value1 = "", string value2 = "");

        string GenerateNoNota(string id);

    }
}
