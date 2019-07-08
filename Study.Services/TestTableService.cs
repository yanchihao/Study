using Study.Data;
using Study.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Service
{
    public class TestTableService: ITestTableService
    {
        public DataOperation<c_member> dop = new DataOperation<c_member>();
        public void AddTestTable(c_member t)
        {

            dop.Add(t);
        }
        public void UpdateTestTable(c_member t)
        {
            dop.Update(t);
        }
        public void DeleteTestTable(c_member t)
        {
            dop.Remove(t);
        }
        public IQueryable<c_member> QueryTestTable(c_member t)
        {
           return dop.FindList(q=>q.c_id==t.c_id);
        }
    }
}
