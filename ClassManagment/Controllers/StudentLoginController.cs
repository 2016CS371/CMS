using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassManagment.Controllers
{
    public class StudentLoginController : Controller
    {
        // GET: StudentLogin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult index()
        {

        }

        public ActionResult StudentRegistration()
        {
            return View();
        }
    }
}