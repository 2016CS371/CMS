using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassManagment.Controllers
{
    public class HolidayController : Controller
    {
        // GET: Holiday
        public ActionResult ShowHoliday()
        {
            return View();
        }
        public ActionResult CreateHoliday()
        {
            return View();
        }
    }
}