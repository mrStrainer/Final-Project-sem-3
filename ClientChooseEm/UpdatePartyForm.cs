using ClientChooseEm.WCFService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientChooseEm
{
    public partial class UpdatePartyForm : Form
    {
        #region "callback services"

        public class BroadcastorCallback : IServiceCallback
        {
            public void BroadcastToClient(EventDataType eventData)
            {
                
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
            

            System.ServiceModel.InstanceContext context =
                new System.ServiceModel.InstanceContext(cb);
            this._service =
                new WCFService.ServiceClient(context, "TCPEndpoint");

            this._service.RegisterClient(_dataStorage.UserId);
        }

        private readonly DataStorage _dataStorage = DataStorage.Instance;
        private WCFService.ServiceClient _service;
        private byte[] currentRowVersion;
        public UpdatePartyForm()
        {
            InitializeComponent();
            this.RegisterClient();
            var currentParty = _service.GetPartyById(_dataStorage.CurrentSelectedPartyId);
            NameTxt.Text = currentParty.Name;
            LimitBox.Text = string.Empty+currentParty.AvailablePlaces;
            YesCheckBox.Checked = currentParty.privacy;
            //not sure if works like this
            StartDateTimePicker.Value = currentParty.startDate;
            StartTimePicker.Value = currentParty.startDate;
            EndDateTimePicker.Value = currentParty.endDate;
            EndTimePicker.Value = currentParty.endDate;
            currentRowVersion = currentParty.RowVersion;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var party = new WCFService.PartyTable
            {
                ID = _dataStorage.CurrentSelectedPartyId,
                ownerID = _dataStorage.UserId,
                startDate = StartDateTimePicker.Value.Date.AddHours(StartTimePicker.Value.Hour).AddMinutes(StartTimePicker.Value.Minute),
                endDate = EndDateTimePicker.Value.Date.AddHours(EndTimePicker.Value.Hour).AddMinutes(EndTimePicker.Value.Minute),
                locationLatitude = 0,
                locationLongitude = 0,
                privacy = YesCheckBox.Checked,
                Name = NameTxt.Text,
                AvailablePlaces = short.Parse(LimitBox.Text),
                RowVersion = currentRowVersion
                
            };

            _service.UpdateParty(party);

            BackBtn_Click(sender, e);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new Parties();
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
    }
}
