using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroToHero.Controllers
{
    public class IslamicController : Controller
    {
        // GET: Islamic
        public ActionResult Quran()
        {
            return View();
        }

        public ActionResult Sunnah()
        {
            return View();
        }

        public ActionResult NewMuslim()
        {
            return View();
        }
    }
}