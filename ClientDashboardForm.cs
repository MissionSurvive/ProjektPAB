using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ClientDashboardForm : Form
    {
        public ClientDashboardForm()
        {
            InitializeComponent();
            userLabel.Text = LoginForm.username + " " + LoginForm.surname;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Dispose();
            loginForm.Show();
        }
    }
}
