using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroToHero.Controllers
{
    public class LanguagesController : Controller
    {
        // GET: Languages
        public ActionResult Arabic()
        {
            return View();
        }

        public ActionResult English()
        {
            return View();
        }

        public ActionResult Korean()
        {
            return View();
        }

        public ActionResult Turkish()
        {
            return View();
        }

    }
}