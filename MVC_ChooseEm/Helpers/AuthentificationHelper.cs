using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_ChooseEm.Models;

namespace MVC_ChooseEm.Helper
{
    public class AuthentificationHelper
    {
        private static string SessionName = "UserLoggedIn";
        private static UserLogInModel currUser;
        public static UserLogInModel CurrUser
        {
            get
            {
                return HttpContext.Current.Session[SessionName] as UserLogInModel;
            }
            set
            {
                currUser = value;
            }
        }
        public static bool IsLoggedIn()
        {
            return HttpContext.Current.Session[SessionName] != null;
        }
        public static void LogIn(UserLogInModel user)
        {
            HttpContext.Current.Session[SessionName] = user;
        }
        public static void LogOut()
        {
            HttpContext.Current.Session[SessionName] = null;
        }
    }
}