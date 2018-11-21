using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassManagment.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult ShowEvents()
        {
            return View();
        }
        public ActionResult CreateEvents()
        {
            return View();
        }
    }
}