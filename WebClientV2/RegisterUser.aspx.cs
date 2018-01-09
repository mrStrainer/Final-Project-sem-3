using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientV2
{
    public partial class RegisterUser : System.Web.UI.Page
    {


        private WebClientV2.WCFLogin.ILogIn _loginService = new WebClientV2.WCFLogin.LogInClient("Http");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            var userLogin = new WCFLogin.UserLoginTable
            {
                email = EmailTxt.Text,
                password = PasswordTxt.Text
            };

            var user = new WCFLogin.UserTable
            {
                firstName = FnameTxt.Text,
                lastName = LnameTxt.Text,
                zip = int.Parse(ZipTxt.Text)
            };

            _loginService.RegisterUser(user, userLogin);
            Response.Redirect("LogIn.aspx");
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Parties.aspx");
        }
    }
}