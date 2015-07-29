using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arthur_GitHub_Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Arthur GitHub Test";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Basic Telerk Grid";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Other";

            return View();
        }
    }
}
