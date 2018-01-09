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
    /// <summary>
    /// TODO:refactor this thing
    /// </summary>
    public partial class FriendsForm : Form
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

        public FriendsForm()
        {
            RegisterClient();

            InitializeComponent();
            btnSeeFriends_Click(new object(), new EventArgs());
            //FriendsGridView.SelectionChanged += new EventHandler(FriendsGridView_SelectionChanged);
        }

        private void btnSeeFriends_Click(object sender, EventArgs e)
        {
            FriendsGridView.Rows.Clear();
            var allUsers = _service.GetAllTheUsers();
            
            foreach (var aux in allUsers)
            {
                if (aux.ID != _dataStorage.UserId)
                {
                    var userTable = new UserTable
                    {
                        ID = aux.ID,
                        firstName = aux.firstName

                    };
                    var index = FriendsGridView.Rows.Add();
                    var row = FriendsGridView.Rows[index];
                    if (userTable.ID != _dataStorage.UserId)
                    {
                        row.Cells["ID"].Value = userTable.ID;
                        row.Cells["PersonName"].Value = userTable.firstName + " " + userTable.lastName;
                        if (_service.AreFriends(_dataStorage.UserId, userTable.ID))
                            row.Cells["isFriend"].Value = "true";
                        else
                            row.Cells["isFriend"].Value = "false";
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new MainMenu();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            var index = FriendsGridView.CurrentCell.RowIndex;
            var selectedRow = FriendsGridView.Rows[index];
            var a = Convert.ToInt64(selectedRow.Cells["ID"].Value);
            var friendsLink = new WCFService.FriendTable
            {
                idOne = a,
                idTwo = _dataStorage.UserId
            };
            _service.CreateFriendsLink(a, _dataStorage.UserId);
            btnSeeFriends_Click(sender, e);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            var index = FriendsGridView.CurrentCell.RowIndex;
            var selectedRow = FriendsGridView.Rows[index];
            var a = Convert.ToInt64(selectedRow.Cells["ID"].Value);

            if (!selectedRow.Cells["isFriend"].Value.Equals("true")) return;

            var friendsLink = new WCFService.FriendTable
            {
                idTwo = a,
                idOne = _dataStorage.UserId
            };
            _service.RemoveFriend(_dataStorage.UserId, a);
            selectedRow.Cells["isFriend"].Value = "Not your friend anymore";

            btnSeeFriends_Click(sender, e);
            // RemoveBtn_Click(sender, e);
        }

        private void FriendsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FriendsGridView.Rows.Count == 0) return;

            var index = FriendsGridView.CurrentCell.RowIndex;
            if (index == -1) return;

            var selectedRow = FriendsGridView.Rows[index];
            try {
                if (selectedRow.Cells["isFriend"].Value.Equals("false"))
                {
                    btnAddFriend.Enabled = true;
                    RemoveBtn.Enabled = false;
                }
                else
                {
                    btnAddFriend.Enabled = false;
                    RemoveBtn.Enabled = true;
                }
            } catch (NullReferenceException ex)
            {
                return;
            }
            
        }

        private void FriendsGridView_TabIndexChanged(object sender, EventArgs e)
        {
            var index = FriendsGridView.CurrentCell.RowIndex;
            if (index == -1) return;
            var selectedRow = FriendsGridView.Rows[index];

            if (selectedRow.Cells["isFriend"].Value.Equals("false"))
            {
                btnAddFriend.Enabled = true;
                RemoveBtn.Enabled = false;
            }
            else
            {
                btnAddFriend.Enabled = false;
                RemoveBtn.Enabled = true;
            }
        }
    }
}
