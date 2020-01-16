using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IOCWeb.Controllers
{
    public class DefaultController : Controller
    {
        private ITest _test;

        public DefaultController(ITest test)
        {
            _test = test;
        }

        public ActionResult Index()
        {
            string ss = _test.Add();
            return View();
        }
    }
}