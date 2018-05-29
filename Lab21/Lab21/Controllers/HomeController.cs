using Lab21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        } 

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register()
        {

            return View();
        }
        public ActionResult AddNewUser(UserInfo newuser)
        {
            //Validation
            if (ModelState.IsValid)
            {
                //insert newUser into the DB
                ViewBag.Message = $"Thank you for registering {newuser.FirstName}";
                return View("confirm");
            }
            else
            {
                ViewBag.Address = Request.UserHostAddress;
                return View("Error");
            }
        }
    }
}