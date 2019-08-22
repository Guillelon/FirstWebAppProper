using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class TestController : Controller
    {

        public ActionResult Temp()
        {
            return Content("barrio ");
        }

        public ActionResult Temp2()
        {
            return Content("fino");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}