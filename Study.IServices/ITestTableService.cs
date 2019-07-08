using Study.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IService
{
    public interface ITestTableService
    {
        void AddTestTable(c_member t);
        void UpdateTestTable(c_member t);

        void DeleteTestTable(c_member t);

        IQueryable<c_member> QueryTestTable(c_member t);

    }
}
