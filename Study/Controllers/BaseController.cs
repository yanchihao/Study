using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Study.Common;

namespace Study.Controllers
{
    public abstract class BaseController : Controller
    {
        protected virtual Type DataObjectType { get { return typeof(BaseController); } }

        protected static T CreateRefObj<T>()
        {
            return Util.CreateRefObj<T>();
        }
    }
}