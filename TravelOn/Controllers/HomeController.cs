using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelOn.Models;

namespace TravelOn.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
            // return RedirectToAction("Contents", "Reviews");
        }

        public ActionResult About()
        {
            ViewBag.Message = "TravelOn is the #1 travel review site";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Connect with us!";

            return View();
        }
    }
}