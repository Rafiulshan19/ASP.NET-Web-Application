using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Bio()
        {
            //ViewBag.Message = "I am an AIUBian. I want to become Millionior. Honesty is the best policy but being honest you can't become millioniar.";
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Info()
        {
            return View();
        }
        public ActionResult Projects()
        {
            string[] names = new string[2];
                names[0] = "UMS";
                names[1] = "AMS";

            ViewBag.Names = names;

            return View();
        }

        public ActionResult Reference()
        {
            return View();
        }
    }
}