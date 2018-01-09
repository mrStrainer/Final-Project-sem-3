using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClientV2.WCFService;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Threading;

namespace WebClientV2
{
    public partial class Parties : System.Web.UI.Page
    {
        #region "callback services"

        public class BroadcastorCallback : WCFService.IServiceCallback
        {
            private System.Threading.SynchronizationContext syncContext = AsyncOperationManager.SynchronizationContext;

            private EventHandler _broadcastorCallBackHandler;
            public void SetHandler(EventHandler handler)
            {
                this._broadcastorCallBackHandler = handler;
            }

            public void BroadcastToClient(EventDataType eventData)
            {
                syncContext.Post(new System.Threading.SendOrPostCallback(OnBroadcast), eventData);
            }

            private void OnBroadcast(object eventData)
            {
                this._broadcastorCallBackHandler.Invoke(eventData, null);
            }
        }

        private delegate void HandleBroadcastCallback(object sender, EventArgs e);
        public void HandleBroadcast(object sender, EventArgs e)
        {
            //if (this.Dispatcher.CheckAccess())
            //{
            //    BeginInvoke(new HandleBroadcastCallback(HandleBroadcast), sender, e);
            //}
            //else
            {
                try
                {
                    var eventData = (WCFService.EventDataType)sender;

                    System.Diagnostics.Debug.WriteLine("Need to update because of " + eventData.ClientId);
                    //if (this.txtEventMessages.Text != "")
                    //    this.txtEventMessages.Text += "\r\n";
                    //this.txtEventMessages.Text += string.Format("{0} (from {1})",
                    //    eventData.EventMessage, eventData.ClientName);
                }
                catch (Exception ex)
                {
                }
            }
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
            cb.SetHandler(this.HandleBroadcast);

            System.ServiceModel.InstanceContext context =
                new System.ServiceModel.InstanceContext(cb);
            this._service =
                new WCFService.ServiceClient(context, "HttpEndpoint");

            this._service.RegisterClient(Convert.ToInt64(Session["id"]));
        }



        private WebClientV2.WCFService.ServiceClient _service;
        private DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.RegisterClient();
            if (!Page.IsPostBack)
            {
                dt = new DataTable();

                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Start Date");
                dt.Columns.Add("End Date");
                dt.Columns.Add("Host ID");
                Session["TempTable"] = dt;
                PartiesGridView.DataSource = dt;
            }
            else
            {
                dt = (DataTable)Session["TempTable"];
                PartiesGridView.DataSource = dt;
            }

        }

        private void datastructure()

        {
            DataTable dt = new DataTable();
            //DataColumn column = new DataColumn();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Start Date");
            dt.Columns.Add("End Date");
            dt.Columns.Add("Host ID");
            //store the state of the datatable into a ViewState object

            ViewState["dt"] = dt;



        }



        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in PartiesGridView.Rows)
            {
                if (row.RowIndex == PartiesGridView.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }
            }
            long ID = Convert.ToInt64(PartiesGridView.SelectedRow.Cells[1].Text);
            Session["SelectedpartyID"] = ID;
            
        }

        protected void OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(PartiesGridView, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }
        private void GetMyParties()
        {
            var myParties = _service.GetAllJoinedParties(Convert.ToInt64(Session["id"]));
            GetParties(myParties);
        }
        private void GetAvailableParties()
        {
            var availableParties = _service.GetAllNotJoinedParties(Convert.ToInt64(Session["id"]));
            GetParties(availableParties);
        }


        private void GetParties(PartyTable[] listOfParties)
        {

            {
                PartiesGridView.DataSource = null;
                PartiesGridView.DataBind();
                dt.Rows.Clear();
                if (PartiesGridView.Rows.Count > 0) PartiesGridView.Columns.Clear();
                PartiesGridView.DataBind();
                var partiesList = _service.GetAllParties(Convert.ToInt64(Session["id"]));
                dt = (DataTable)Session["TempTable"];

                foreach (var party in listOfParties)
                {
                    DataRow row = null;
                    row = dt.NewRow();
                    row["ID"] = party.ID.ToString();
                    row["Name"] = party.Name;
                    row["Start Date"] = party.startDate.ToString();
                    row["End Date"] = party.endDate.ToString();
                    row["Host ID"] = party.ownerID.ToString();
                    dt.Rows.Add(row);
                    dt.AcceptChanges();
                }
                Session["TempTable"] = dt;
                PartiesGridView.DataSource = dt;
                PartiesGridView.DataBind();

            }


        }
        protected void SeeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SeeParty.aspx");
        }

        protected void MyPartiesBtn_Click(object sender, EventArgs e)
        {
            GetMyParties();
        }

        protected void AvailablePartiesBtn_Click(object sender, EventArgs e)
        {
            GetAvailableParties();
        }
    }
}