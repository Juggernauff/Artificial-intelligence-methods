using System;
using System.Windows.Forms;

namespace DeliveryAppClient
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            User user = APIManager.Authorization(new User(login, password));
            //MessageBox.Show(user.id.ToString());
            MainMenu mainMenu = new MainMenu(user);
            mainMenu.Show(this);
            Hide();
        }

        private void lnklblRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registratonForm = new RegistrationForm();
            registratonForm.Show(this);
            Hide();
        }
    }
}
