using System;
using System.Windows.Forms;

namespace ClientChooseEm
{
    public partial class NotJoinedPartiesForm : Form
    {
        private readonly DataStorage _dataStorage = DataStorage.Instance;
        private readonly WCFService.IService _service = new WCFService.ServiceClient("TCPEndpoint");
        
        public NotJoinedPartiesForm()
        {
            InitializeComponent();
        }
        
        private void FindPartiesBtn_Click(object sender, EventArgs e)
        {
            PartiesDataGridView.Rows.Clear();
            var list = _service.GetAllNotJoinedParties(_dataStorage.UserId);
            foreach (var aux in list)
            {
                var partyTable = new WCFService.PartyTable
                {
                    ID = aux.ID,
                    ownerID = aux.ownerID,
                    startDate = aux.startDate,
                    endDate = aux.endDate,
                    locationLatitude = aux.locationLatitude,
                    locationLongitude = aux.locationLongitude,
                    Name = aux.Name,
                    privacy = aux.privacy
                };

                var index = PartiesDataGridView.Rows.Add();
                var row = PartiesDataGridView.Rows[index];

                row.Cells["ID"].Value = partyTable.ID;
                row.Cells["ownerID"].Value = partyTable.ownerID;
                row.Cells["startDate"].Value = partyTable.startDate;
                row.Cells["endDate"].Value = partyTable.endDate;
                row.Cells["locationLatitude"].Value = partyTable.locationLatitude;
                row.Cells["locationLongitude"].Value = partyTable.locationLongitude;
                row.Cells["PartyName"].Value = partyTable.Name;
                row.Cells["privacy"].Value = partyTable.privacy;

            }
        }

        private void PartyPlaylistButton_Click(object sender, EventArgs e)
        {
            var index = PartiesDataGridView.CurrentCell.RowIndex;
            var selectedRow = PartiesDataGridView.Rows[index];
            var a = Convert.ToInt64(selectedRow.Cells["ID"].Value);
            Hide();
            var form2 = new ManageSongsForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new HomeForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void btnJoinParty_Click(object sender, EventArgs e)
        {
            var index = PartiesDataGridView.CurrentCell.RowIndex;
            var selectedRow = PartiesDataGridView.Rows[index];
            var a = Convert.ToInt64(selectedRow.Cells["ID"].Value);
            var userAtParty = new WCFService.UsersAtParty
            {
                userID = _dataStorage.UserId,
                partyID = a,
                adminPrivileges = false,
                status = 0
            };
            _service.CreateUserAtParty(userAtParty);
            Hide();
            var form2 = new JoinedPartiesForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }
    }
}
