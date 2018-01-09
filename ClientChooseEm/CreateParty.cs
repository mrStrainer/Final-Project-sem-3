using ClientChooseEm.WCFService;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ClientChooseEm
{


    public partial class CreateParty : Form
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
            if (InvokeRequired)
            {
                BeginInvoke(new HandleBroadcastCallback(HandleBroadcast), sender, e);
            }
            else
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

        private readonly DataStorage _dataStorage = DataStorage.Instance;
        private readonly WCFService.ServiceClient _service;

        public CreateParty()
        {
            BroadcastorCallback cb = new BroadcastorCallback();
            cb.SetHandler(this.HandleBroadcast);
            InitializeComponent();
            System.ServiceModel.InstanceContext context =
                new System.ServiceModel.InstanceContext(cb);
            this._service =
                new WCFService.ServiceClient(context, "TCPEndpoint");
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            short aPlaces = 0;
            if (LimitBox.Text != string.Empty)
            {
                aPlaces = short.Parse(LimitBox.Text);
            }

            var party = new WCFService.PartyTable
            {
                ownerID = _dataStorage.UserId,
                startDate = StartDateTimePicker.Value.Date.AddHours(StartTimePicker.Value.Hour).AddMinutes(StartTimePicker.Value.Minute),
                endDate = EndDateTimePicker.Value.Date.AddHours(EndTimePicker.Value.Hour).AddMinutes(EndTimePicker.Value.Minute),
                locationLatitude = 0,
                locationLongitude = 0,
                privacy = YesCheckBox.Checked,
                Name = NameTxt.Text,
                AvailablePlaces = aPlaces

            };

            _dataStorage.CurrentSelectedPartyId = _service.CreateParty(party);

            BackBtn_Click(sender, e);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new MainMenu();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void SongsForPlaylistBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new SeeParty();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
