using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class CalendarController : Controller
    {
        //
        // GET: /Calendar/

        public ActionResult Index()
        {
            var match = new List<CalendarModel>
            {
            new CalendarModel
            {
              Date = "23/09/2015 21:45",
              Match = "Juventus - Frozinone",
              Competition = "Seria A",
              Chanel = "Football 1"
            },
            new CalendarModel
            {
              Date = "23/09/2015 21:45",
              Match = "Walsall - Chelsea",
              Competition = "English Legea Cup",
              Chanel = "Football 2"
            }
            };
            ViewBag.Matches = match;
            return View();
        }


    }
}
