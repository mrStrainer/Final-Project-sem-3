using System;
using System.Windows.Forms; 

namespace ClientChooseEm
{
    public partial class LoginForm : Form
    {
        private readonly DataStorage _dataStorage = DataStorage.Instance;
        private readonly WCFLogin.ILogIn _loginService = new WCFLogin.LogInClient("Http");
        public LoginForm()
        {
            InitializeComponent();
            
            //For test purposes
            EmailBox.Text = "test";
            PasswordBox.Text = "test";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            /* Fetch the stored value */
           
            
            var id = _loginService.CheckCredentials(EmailBox.Text, PasswordBox.Text);
            // LoginButton.Text = ID.ToString();
            if (id > 0)
            {
                _dataStorage.UserId = id;
                //TODO: Here get UserTable or userID
                Hide();
                var form2 = new MainMenu();
                form2.Closed += (s, args) => Close();
                form2.Show();
            }
            else
            {
                var popup = new PopupWindow();
                const string userEnteredText = ("User or password invalid");
                popup.SetErrorText(userEnteredText);
                popup.ShowDialog();
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new RegisterForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            LoginButton_Click(sender, e);
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
}
