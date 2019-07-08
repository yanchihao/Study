using Study.Common;
using Study.Data;
using Study.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Study.Controllers
{
    public class TestTableController : BaseController
    {
        ITestTableService _services = CreateRefObj<ITestTableService>();
        // GET: TestTable
        public ActionResult Index()
        {
            ViewBag.VideoUrl = getaes();
            return View();
        }

        public string getaes()
        {
            return EncryptionHelper.EncryptByAES("http://gcqq450f71eywn6bv7u.exp.bcevod.com/mda-hbqagik5sfq1jsai/mda-hbqagik5sfq1jsai.mp4", "12345678912345678912345678912345");
        }
        public void AddTestTable(c_member t)
        {
            _services.AddTestTable(t);
        }
        public void UpdateTestTable(c_member t)
        {
            _services.UpdateTestTable(t);
        }

        public void DeleteTestTable(c_member t)
        {
            _services.DeleteTestTable(t);
        }

        public IQueryable<c_member> QueryTestTable(c_member t)
        {
            return _services.QueryTestTable(t);
        }
    }
}