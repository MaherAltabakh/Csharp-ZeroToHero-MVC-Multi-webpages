using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroToHero.Controllers
{
    public class DataScienceController : Controller
    {
        // GET: DataScience
        public ActionResult ArtificialIntelligence()
        {
            return View();
        }

        public ActionResult MachineLearning()
        {
            return View();
        }

        public ActionResult Python()
        {
            return View();
        }


    }
}