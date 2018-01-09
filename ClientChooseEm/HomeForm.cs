using System;
using System.Windows.Forms;

namespace ClientChooseEm
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnMyParties_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new ManagePartiesForm();
            form2.Closed += (s, args) => Close();
            form2.Show();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new LoginForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }


        private void btnCreateParty_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new CreateParty();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }
        
        private void notJoinedPartiesBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new NotJoinedPartiesForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void joinedPartiesBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new JoinedPartiesForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }      
    }
}
