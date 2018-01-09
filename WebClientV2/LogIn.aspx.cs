using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebClientChooseEm
{
    
    public partial class LogIn : System.Web.UI.Page
    {
        private WebClientV2.WCFLogin.ILogIn _loginService = new WebClientV2.WCFLogin.LogInClient("Http");
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogInBtn_Click(object sender, EventArgs e)
        {
            if (EmailTxt.Text.Length > 0)
            {
                // this happens if the login name is filled out
                if (PasswordTxt.Text.Length > 0)
                {
                    long id = _loginService.CheckCredentials(EmailTxt.Text, PasswordTxt.Text);

                    if (id > 0)
                    {
                        Session["id"] = id;
                        Response.Redirect("MainMenu.aspx");
                    }
                    else
                    {
                      //lblErrorMessage.Text = "Incorrect login ";
                    }

                }
                else
                {

                    //lblErrorMessage.Text = "Incorrect login ";
                }
            }
            else
            {

                //lblErrorMessage.Text = "Login error";
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterUser.aspx");
        }
    }

    
}