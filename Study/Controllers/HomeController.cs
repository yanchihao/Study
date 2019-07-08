using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Study.IService;

namespace Study.Controllers
{
    public class HomeController : BaseController
    {
        IStudyAutoFacService _services = CreateRefObj<IStudyAutoFacService>();
        
        public ActionResult Index()
        {
           ViewBag.textTest= _services.GetText("test");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}