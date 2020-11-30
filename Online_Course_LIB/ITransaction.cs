using System.Collections;

namespace Database
{
    public interface ITransaction
    {
        void Insert();

        ArrayList QueryData(string criteria = "", string value1 = "", string value2 = "");

        string GenerateNoNota(string id);

    }
}
