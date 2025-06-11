using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Exercise02.Controllers
{
    public class HomeController : Controller
    {
    
        public ActionResult Index()
        {
            ViewBag.Name = "mahdi";

            return View();
        }

        public ActionResult Welcome()
        {
            ViewBag.Welcome = "Welcome to app.";
            return View();
        }


    }
}