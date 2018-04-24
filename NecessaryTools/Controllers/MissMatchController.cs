using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NecessaryTools.Models;

namespace NecessaryTools.Controllers
{
    public class MissMatchController : Controller
    {
		// GET: MissMatch
		public ActionResult Index()
		{
			return View();
		}

        public ActionResult Find(MissMatch aMissMatch)
        {
            List<MissMatch.Missing> missList = MissMatch.GetMissingItems(aMissMatch);
            if (missList.Count == 0)
                return  Json("All data in list b is cosist in list a.");
            else
            {
                return Json(missList);
            }
        }

        public ActionResult AgeCal(MissMatch.AgeCalculator newAgeCalculator)
        {
            return Json(MissMatch.AgeCalculator.AgeCalculate(newAgeCalculator));
        }
    }
}