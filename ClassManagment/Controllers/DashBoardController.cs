using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassManagment.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult index()
        {
            return View();
        }
        public ActionResult CreateLecture()
        {
            return View();
        }
        public ActionResult updateLecture()
        {
            return View();
        }
    }

}