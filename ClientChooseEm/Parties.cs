using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientChooseEm.WCFService;
using System.ComponentModel;
using System.ServiceModel;

namespace ClientChooseEm
{
    public partial class Parties : Form
    {
        #region "callback services"

        private class BroadcastorCallback : IServiceCallback
        {
            private readonly System.Threading.SynchronizationContext _syncContext = AsyncOperationManager.SynchronizationContext;

            private EventHandler _broadcastorCallBackHandler;
            public void SetHandler(EventHandler handler)
            {
                _broadcastorCallBackHandler = handler;
            }

            public void BroadcastToClient(EventDataType eventData)
            {
                _syncContext.Post(new System.Threading.SendOrPostCallback(OnBroadcast), eventData);
            }

            private void OnBroadcast(object eventData)
            {
                _broadcastorCallBackHandler.Invoke(eventData, null);
            }
        }

        private delegate void HandleBroadcastCallback(object sender, EventArgs e);

        private void HandleBroadcast(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new HandleBroadcastCallback(HandleBroadcast), sender, e);
            }
            else
            {
                try
                {
                    var eventData = (EventDataType)sender;

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
        private ServiceClient _service;
        private List<long> _ownedParties = new List<long>();

        private void RegisterClient()
        {
            if ((_service != null))
            {
                _service.Abort();
                _service = null;
            }

            BroadcastorCallback cb = new BroadcastorCallback();
            cb.SetHandler(HandleBroadcast);

            System.ServiceModel.InstanceContext context =
                new System.ServiceModel.InstanceContext(cb);
            _service =
                new ServiceClient(context, "TCPEndpoint");

            _service.RegisterClient(_dataStorage.UserId);
        }

        /// if you click on Hosted by on the datagrid header the 
        /// program bricks  for some reason

        /// <summary>
        /// Initialzing, getting the parties you already joined
        /// </summary>
        public Parties()
        {
            RegisterClient();
            InitializeComponent();
            GetMyParties();
            //Get user's details from service
            var _user = _service.GetUser(_dataStorage.UserId);
            IdLbl.Text = _user.ID.ToString();
            FirstNameLbl.Text = _user.firstName;
            LastNameLbl.Text = _user.lastName;
            ZipLbl.Text = _user.zip.ToString();
        }

        /// <summary>
        /// Get parties that you have joined
        /// 
        /// </summary>
        private void GetMyParties()
        {

            var myParties = _service.GetAllJoinedParties(_dataStorage.UserId);
            GetParties(myParties);
            ToPartyBtn.Enabled = false;
            SeePartyBtn.Enabled = true;
        }
        
        /// <summary>
        /// Get parties that you havent joined yet
        /// </summary>
        private void GetAvailableParties()
        {
            var availableParties = _service.GetAllNotJoinedParties(_dataStorage.UserId);
            GetParties(availableParties);
            ToPartyBtn.Enabled = true;
            SeePartyBtn.Enabled = false;

        }
        
        /// <summary>
        /// Put the parties into the datagrid
        /// </summary>
        /// <param name="listOfParties"></param>
        private void GetParties(PartyTable[] listOfParties)
        {
            PartiesGridView.Rows.Clear();
            _ownedParties.Clear();
            foreach (var party in listOfParties)
            {
                var index = PartiesGridView.Rows.Add();
                var row = PartiesGridView.Rows[index];
                
                row.Cells["Party"].Value = party.Name;
                if (party.ownerID == _dataStorage.UserId) {
                    _ownedParties.Add(party.ID);
                } 
                row.Cells["HostName"].Value = party.ownerID;
                row.Cells["StartDate"].Value = party.startDate;
                row.Cells["EndDate"].Value = party.endDate;
                row.Cells["PartyId"].Value = party.ID;
                row.Cells["Places"].Value = party.AvailablePlaces;
            }
        }

        /// <summary>
        /// Click event to get joined parties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPartiesBtn_Click(object sender, EventArgs e)
        {
            GetMyParties();
        }
        
        /// <summary>
        /// Click event to get parties still available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AvailablePartiesBtn_Click(object sender, EventArgs e)
        {
            GetAvailableParties();
        }
        
        /// <summary>
        /// Set teh admin privileges if need be
        /// </summary>
        /// <param name="selectedId"></param>
        /// <returns></returns>
        private bool SetAdminPrivileges(long selectedId)
        {
            var isAdmin = false;
            _ownedParties.ForEach(partyId =>
            {
                if (selectedId == partyId)
                {
                    isAdmin = true;
                    //UpdateBtn.Enabled = true;
                }
            });
            return isAdmin;
        }

        private void SetSelectedParty()
        {
            var index = PartiesGridView.CurrentCell.RowIndex;
            var selectedRow = PartiesGridView.Rows[index];
            _dataStorage.CurrentSelectedPartyId = Convert.ToInt64(selectedRow.Cells["PartyId"].Value);
            _dataStorage.adminAtParty = SetAdminPrivileges(_dataStorage.CurrentSelectedPartyId);
        }
        
        /// <summary>
        /// Click event to join a party
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToPartyBtn_Click(object sender, EventArgs e)
        {
//            var index = PartiesGridView.CurrentCell.RowIndex;
//            var selectedRow = PartiesGridView.Rows[index];
//            _dataStorage.CurrentSelectedPartyId = Convert.ToInt64(selectedRow.Cells["PartyId"].Value);
//            _dataStorage.adminAtParty = SetAdminPrivileges(_dataStorage.CurrentSelectedPartyId);
            SetSelectedParty();
            
            var userAtParty = new UsersAtParty
            {
                userID = _dataStorage.UserId,
                partyID = _dataStorage.CurrentSelectedPartyId,
                adminPrivileges = _dataStorage.adminAtParty,
                status = 0
            };

            try
            {
                _service.CreateUserAtParty(userAtParty, _service.GetPartyById(userAtParty.partyID).RowVersion);
            }
            catch (FaultException ex)
            {
               var aux = new PopupWindow();
                aux.SetErrorText(ex.Message);
                aux.ShowDialog();
                return;
            }
            Hide();
            var form2 = new SeeParty();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }
        
        /// <summary>
        /// Click event to see a party without joining
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeePartyBtn_Click(object sender, EventArgs e)
        {
//            var index = PartiesGridView.CurrentCell.RowIndex;
//            var selectedRow = PartiesGridView.Rows[index];
//            _dataStorage.CurrentSelectedPartyId = Convert.ToInt64(selectedRow.Cells["PartyId"].Value);
//            _dataStorage.adminAtParty = SetAdminPrivileges(_dataStorage.CurrentSelectedPartyId);
            SetSelectedParty();
            
            Hide();
            var form2 = new SeeParty();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }
        
        /// <summary>
        ///  click to go back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new MainMenu();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SetSelectedParty();
            
            if (!_dataStorage.adminAtParty) return;
            
            Hide();
            var form2 = new UpdatePartyForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void LeaveBtn_Click(object sender, EventArgs e)
        {
            var index = PartiesGridView.CurrentCell.RowIndex;
            var selectedRow = PartiesGridView.Rows[index];
            _service.RemoveUserAtParty(_dataStorage.UserId, Convert.ToInt64(selectedRow.Cells["PartyId"].Value));
        }
    }
}
