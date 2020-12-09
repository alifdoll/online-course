using System.Collections;

namespace Database
{
    public interface ITransaction
    {
        void Insert();

        ArrayList QueryData(string studentId, string criteria = "", string value = "");

        string GenerateNoNota(string id);

    }
}
