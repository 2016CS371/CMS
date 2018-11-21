using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassManagment.Controllers
{
    public class FacultyController : Controller
    {
        // GET: Faculty
        public ActionResult ShowFaculty()
        {
            return View();
        }
        public ActionResult AddFaculty()
        {
            return View();
        }
    }
}