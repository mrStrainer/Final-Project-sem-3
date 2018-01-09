using System;
using System.Windows.Forms;

namespace ClientChooseEm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void PartiesBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new Parties();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void CreatePartyBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new CreateParty();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void FriendsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new FriendsForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new LoginForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }
    }
}
