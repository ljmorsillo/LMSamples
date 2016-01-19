using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthObservations.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Demo MVC App v0.1 Lindsay Morsillo";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Lindsay Morsillo";
            return View();
        }
    }
}
