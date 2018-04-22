using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NecessaryTools.Models;

namespace NecessaryTools.Controllers
{
    public class PassMakeController : Controller
    {
        // GET: PassMake
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PassGen(string Pass)
        {
            PassMake aPassMake = new PassMake(Pass);
            return Json(aPassMake);
        }
        public ActionResult GtrPass(string Pass)
        {
            PassMake.GtrPassword aPassMake = new PassMake.GtrPassword(Pass);
            return Json(aPassMake);
        }
    }
}