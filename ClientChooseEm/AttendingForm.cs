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
    public partial class AttendingForm : Form
    {
        #region "callback services"

        public class BroadcastorCallback : WCFService.IServiceCallback
        {

            public void BroadcastToClient(EventDataType eventData)
            {

            }

        }

        private delegate void HandleBroadcastCallback(object sender, EventArgs e);
        private void HandleBroadcast(object sender, EventArgs e)
        {

        }

        #endregion
        private readonly DataStorage _dataStorage = DataStorage.Instance;
        private WCFService.ServiceClient _service;

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

        public AttendingForm()
        {
            RegisterClient();
            InitializeComponent();
        }

        private void GetGuestsBtn_Click(object sender, EventArgs e)
        {
            var users = _service.GetAllUsers(_dataStorage.CurrentSelectedPartyId);
            var friends = _service.GetAllFriends(_dataStorage.UserId);


            AttendingGridView.Rows.Clear();
            
            foreach (var user in users)
            {
                //check whether it's the user's id 
                if(user.userID != _dataStorage.UserId)
                {
                    var index = AttendingGridView.Rows.Add();
                    var row = AttendingGridView.Rows[index];
                    var auxUser = _service.GetUser(user.userID);

                    row.Cells["UserName"].Value = auxUser.firstName + " " + auxUser.lastName;
                    row.Cells["Status"].Value = user.status;


                    if (user.adminPrivileges)
                        row.Cells["IsAdmin"].Value = 1;
                    else row.Cells["IsAdmin"].Value = 0;


                    if (_service.AreFriends(_dataStorage.UserId,auxUser.ID))
                        row.Cells["IsFriend"].Value = true;
                    else
                        row.Cells["IsFriend"].Value = false;
                }
                
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new SeeParty();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }
    }
}
