using System.Collections;

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
