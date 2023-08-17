using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroToHero.Controllers
{
    public class ElectricalEngineeringController : Controller
    {
        // GET: ElectricalEngineering
        public ActionResult ElectricalMachies()
        {
            return View();
        }

        public ActionResult Matlab()
        {
            return View();
        }

        public ActionResult PowerSystems()
        {
            return View();
        }
    }
}