using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewTimePractice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 12 ? "Good Morning"  : "Good Afternoon";
            return RedirectToAction("MickeyMouse","Registration");
        }
        public ViewResult RsvpForm()
        {

            return View();
        }
    }
}