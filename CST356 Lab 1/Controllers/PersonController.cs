using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CST356_Lab_1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            ViewBag.FirstName = "Dylan";
            ViewBag.LastName = "Brandstetter";
            ViewBag.Age = "20";
            ViewBag.Gender = "Male";

            return View();
        }
    }
}