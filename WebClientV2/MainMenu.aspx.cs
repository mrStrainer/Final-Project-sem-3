using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientChooseEm
{
    public partial class MainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ID"] == null) Response.Redirect("LogIn.aspx");
        }

        protected void PartiesBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Parties.aspx");
        }

        protected void CreatePartyBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateParty2.aspx");
        }
    }
}