using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public abstract class Database
    {
        protected abstract void Insert();

        protected abstract void Update();

        protected abstract void Delete();

    }
}
