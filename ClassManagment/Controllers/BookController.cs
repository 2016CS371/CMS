using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassManagment.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult ShowBooks()
        {
            return View();
        }
        public ActionResult AddBooks()
        {
            return View();
        }
    }
}