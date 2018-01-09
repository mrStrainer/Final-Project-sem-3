using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Threading;
using WebClientV2.WCFService;

namespace WebClientV2
{
    public partial class Friends : System.Web.UI.Page
    {

    //    #region "callback services"

    //    public class BroadcastorCallback : WCFService.IServiceCallback
    //    {
    //        private System.Threading.SynchronizationContext syncContext = AsyncOperationManager.SynchronizationContext;

    //        private EventHandler _broadcastorCallBackHandler;
    //        public void SetHandler(EventHandler handler)
    //        {
    //            this._broadcastorCallBackHandler = handler;
    //        }

    //        public void BroadcastToClient(EventDataType eventData)
    //        {
    //            syncContext.Post(new System.Threading.SendOrPostCallback(OnBroadcast), eventData);
    //        }

    //        private void OnBroadcast(object eventData)
    //        {
    //            this._broadcastorCallBackHandler.Invoke(eventData, null);
    //        }
    //    }

    //    private delegate void HandleBroadcastCallback(object sender, EventArgs e);
    //    public void HandleBroadcast(object sender, EventArgs e)
    //    {
    //        //if (this.Dispatcher.CheckAccess())
    //        //{
    //        //    BeginInvoke(new HandleBroadcastCallback(HandleBroadcast), sender, e);
    //        //}
    //        //else
    //        {
    //            try
    //            {
    //                var eventData = (WCFService.EventDataType)sender;

    //                System.Diagnostics.Debug.WriteLine("Need to update because of " + eventData.ClientId);
    //                //if (this.txtEventMessages.Text != "")
    //                //    this.txtEventMessages.Text += "\r\n";
    //                //this.txtEventMessages.Text += string.Format("{0} (from {1})",
    //                //    eventData.EventMessage, eventData.ClientName);
    //            }
    //            catch (Exception ex)
    //            {
    //            }
    //        }
    //    }

    //    #endregion


    //    private void RegisterClient()
    //    {
    //        if ((this._service != null))
    //        {
    //            this._service.Abort();
    //            this._service = null;
    //        }

    //        BroadcastorCallback cb = new BroadcastorCallback();
    //        cb.SetHandler(this.HandleBroadcast);

    //        System.ServiceModel.InstanceContext context =
    //            new System.ServiceModel.InstanceContext(cb);
    //        this._service =
    //            new WCFService.ServiceClient(context, "HttpEndpoint");

    //        this._service.RegisterClient(Convert.ToInt64(Session["id"]));
    //    }


    //    private WebClientV2.WCFService.ServiceClient _service;
    //    private DataTable dt;


    //    protected void Page_Load(object sender, EventArgs e)
    //    {

    //        this.RegisterClient();
    //        if (!Page.IsPostBack)
    //        {
    //            dt = new DataTable();

    //            dt.Columns.Add("ID");
    //            dt.Columns.Add("Name");
    //            dt.Columns.Add("IsFriend");
    //            Session["TempTable"] = dt;
    //            PartiesGridView.DataSource = dt;
    //        }
    //        else
    //        {
    //            dt = (DataTable)Session["TempTable"];
    //            PartiesGridView.DataSource = dt;
    //        }

    //    }


    //    private void datastructure()

    //    {
    //        DataTable dt = new DataTable();
    //        //DataColumn column = new DataColumn();
    //        dt.Columns.Add("ID");
    //        dt.Columns.Add("Name");
    //        dt.Columns.Add("IsFriend");

    //        ViewState["dt"] = dt;



    //    }



    //    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    //    {
    //        foreach (GridViewRow row in FriendsGridView.Rows)
    //        {
    //            if (row.RowIndex == FriendsGridView.SelectedIndex)
    //            {
    //                row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
    //                row.ToolTip = string.Empty;
    //            }
    //            else
    //            {
    //                row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
    //                row.ToolTip = "Click to select this row.";
    //            }
    //        }
    //        long ID = Convert.ToInt64(FriendsGridView.SelectedRow.Cells[1].Text);
    //        Session["SelectedfriendID"] = ID;

    //    }


    //    protected void OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
    //    {
    //        if (e.Row.RowType == DataControlRowType.DataRow)
    //        {
    //            e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(FriendsGridView, "Select$" + e.Row.RowIndex);
    //            e.Row.ToolTip = "Click to select this row.";
    //        }
    //    }

    //    private void GetUsers()
    //    {
    //        var users = _service.GetAllUsers(Convert.ToInt64(Session["id"]));
    //        GetUsers(users);
    //    }


    //    private void GetUSers(UserTable[] listOfParties)
    //    {

    //        {
    //            FriendsGridView.DataSource = null;
    //            FriendsGridView.DataBind();
    //            dt.Rows.Clear();
    //            if (FriendsGridView.Rows.Count > 0) FriendsGridView.Columns.Clear();
    //            PartiesGridView.DataBind();
    //            var usersList = _service.GetAllUsers(Convert.ToInt64(Session["id"]));
    //            dt = (DataTable)Session["TempTable"];

    //            foreach (var user in listOfParties)
    //            {
    //                DataRow row = null;
    //                row = dt.NewRow();
    //                row["ID"] = user.ID.ToString();
    //                row["Name"] = user.Name;
    //                if (user.FirstOrDefault(u => u.idOne == _dataStorage.UserId && u.idTwo == userTable.ID || u.idOne == userTable.ID && u.idTwo == _dataStorage.UserId) != null)
    //                    row.Cells["isFriend"].Value = "true";
    //                else
    //                    row.Cells["isFriend"].Value = "false";
    //                dt.Rows.Add(row);
    //                dt.AcceptChanges();
    //            }
    //            Session["TempTable"] = dt;
    //            FriendsGridView.DataSource = dt;
    //            FriendsGridView.DataBind();

    //        }


    //    }

    //    protected void UsersBtn_Click(object sender, EventArgs e)
    //    {
    //        GetUsers();
    //    }

    //    private void BackBtn_Click(object sender, EventArgs e)
    //    {
    //        Hide();
    //        var form2 = new MainMenu();
    //        form2.Closed += (s, args) => Close();
    //        form2.Show();
    //    }




    }
}