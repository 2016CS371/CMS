using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassManagment.Controllers
{
    public class SdashboardController : Controller
    {
        // GET: Sdashboard
        public ActionResult ViewSchedule()
        {
            return View();
        }
    }
}