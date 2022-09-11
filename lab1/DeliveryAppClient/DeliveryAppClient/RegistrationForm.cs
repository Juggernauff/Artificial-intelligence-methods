using System;
using System.Windows.Forms;

namespace DeliveryAppClient
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            // Добавить проверку на textBox
            //User user = APIManager.Registration(new User(textBox1.Text, textBox2.Text, textBox3.Text, maskedTextBox1.Text, textBox5.Text, textBox6.Text, textBox7.Text, (int)Role.User));
            //MessageBox.Show(user.id.ToString());
            Close();
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
