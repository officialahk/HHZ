using HHZ.Common;
using HHZ.Data;
using HHZ.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HHZ.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //if (User.Identity.IsAuthenticated)
            //{
            //    var user = User.Identity;
            //    ViewBag.Name = user.Name;

            //    ViewBag.displayMenu = "No";

            //    if (isDoctor())
            //    {
            //        ViewBag.displayMenu = "Yes";
            //    }
            //    return RedirectToAction("Dashboard", "Home", new { area = "Doctor" });

            //}
            //else
            //{
            //    //ViewBag.Name = "Not Logged IN";
            //    return View();

            //}

            return View();

        }

        //public Boolean isDoctor()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        var user = User.Identity;
        //        ApplicationDbContext context = new ApplicationDbContext();
        //        var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
        //        var s = UserManager.GetRoles(user.GetUserId());
        //        if (s[0].ToString() == "Doctor")
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    return false;
        //}


        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult SearchResult()
        {


            return View();
        }


        public ActionResult HowItsWorks()
        {

            return View();
        }


        public ActionResult BlogPost()
        {

            return View();
        }


        public ActionResult BlogPostDetail()
        {

            return View();
        }


        public ActionResult DoctorDetail()
        {

            return View();
        }
    }
}