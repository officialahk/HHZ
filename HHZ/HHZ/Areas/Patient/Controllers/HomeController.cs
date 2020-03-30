using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HHZ.Areas.Patient.Controllers
{
    public class HomeController : Controller
    {
        // GET: Patient/Home
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}