using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClientV2.WCFService;

namespace WebClientV2
{
    public partial class CreateParty2 : System.Web.UI.Page
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CreateBtn_Click(object sender, EventArgs e)
        {

            var party = new WCFService.PartyTable
            {
                ownerID = Convert.ToInt32(Session["id"]),
                startDate = StartDateCalendar.SelectedDate,
                endDate = EndDateCalendar.SelectedDate,
                locationLatitude = 0,
                locationLongitude = 0,
                privacy = CheckBox.Checked,
                Name = NameTxt.Text

            };
            _service.CreateParty(party);

            Response.Redirect("MainMenu.aspx");

        }
    }
}