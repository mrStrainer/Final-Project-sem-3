using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MVC_ChooseEm.Models;

namespace MVC_ChooseEm.Controllers
{
    public class LogInController : Controller
    {
        private readonly ServiceReference2.ILogIn authObj = new ServiceReference2.LogInClient("Http");
        // GET: LogIn
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLogInModel user)
        {
            // Check if the Model is valid or not
            // Check if user exists 
            if (ModelState.IsValid)
            {
                string username = user.email;
                string password = user.password;


                long ID = authObj.CheckCredentials(username, password);
                if (ID >= 0)
                {

                    Session["UserId"] = ID.ToString();

                    RedirectToAction("contact", "Home");

                }
                else
                {
                    ModelState.AddModelError("", "Username & password combination is invalid");
                }

            }

            return View();

        }

        //public ActionResult LogOff()
        //{
        //    FormsAuthentication.SignOut();

        //    return RedirectToAction("Index", "Home");
        //}
    }
}