using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ChooseEm.Models;
using MVC_ChooseEm.ServiceReference1;

namespace MVC_ChooseEm.Controllers
{
    public class UserController : Controller
    {
        #region "callback services"

        public class BroadcastorCallback 
        {
            
        }

        #endregion

        private void RegisterClient()
        {
            if ((this._service != null))
            {
                this._service.Abort();
                this._service = null;
            }

            BroadcastorCallback cb = new BroadcastorCallback();

            System.ServiceModel.InstanceContext context =
                new System.ServiceModel.InstanceContext(cb);
            this._service =
                new ServiceReference1.ServiceClient(context, "HttpEndpoint");

            this._service.RegisterClient(Convert.ToInt64(Session["id"]));
        }



        private ServiceReference1.ServiceClient _service;

        private ServiceReference2.ILogIn logOgj = new ServiceReference2.LogInClient("Http");
        
        // GET: User
        public ActionResult AddUser()
        {
            return View();
        }



        [HttpPost]
        public ActionResult AddUser(UserModel user, UserLogInModel uLogIn)
        {
            RegisterClient();

            if (ModelState.IsValid)
            {
                System.Diagnostics.Debug.WriteLine(user.firstName + user.lastName + user.zip + uLogIn.password + uLogIn.email);
                ServiceReference2.UserTable User = new ServiceReference2.UserTable

                {
                    firstName = user.firstName,
                    lastName = user.lastName,
                    zip = user.zip,
                    accountType = user.accountType
                };
                ServiceReference2.UserLoginTable ULogIn = new ServiceReference2.UserLoginTable
                {
                    email = uLogIn.email,
                    password = uLogIn.password
                };

                long created = logOgj.RegisterUser(User, ULogIn);

                if (created > 0)
                {
                    RedirectToAction("Login", "LogIn");
                }
                else
                    ModelState.AddModelError("", "Informatiion input invalid");
            }
            return View();
        }


    }
}