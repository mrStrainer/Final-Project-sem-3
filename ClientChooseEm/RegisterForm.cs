using System;
using System.Windows.Forms;


namespace ClientChooseEm
{
    public partial class RegisterForm : Form
    {
        private readonly WCFLogin.ILogIn _service = new WCFLogin.LogInClient("Http");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new LoginForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var userLogin = new WCFLogin.UserLoginTable {
                email  = EmailTxt.Text,
                password = PasswordTxt.Text
            };

            var user = new WCFLogin.UserTable
            {
                firstName = FnameTxt.Text,
                lastName =LnameTxt.Text,
                zip = int.Parse(ZipTxt.Text)
            };

            _service.RegisterUser(user, userLogin);
            BackBtn_Click(sender, e);
        }
    }
}
