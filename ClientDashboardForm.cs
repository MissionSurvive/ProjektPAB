using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ClientDashboardForm : Form
    {
        ClientRentForm clientRentForm = new ClientRentForm() { TopLevel = false, TopMost = true };
        ClientOrderForm clientOrderForm = new ClientOrderForm() { TopLevel = false, TopMost = true };
        FormCollection collection = Application.OpenForms;
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in collection)
            {
                if (form.Name == "ClientRentForm")
                {
                    clientRentForm.Hide();
                }
                if (form.Name == "ClientOrderForm")
                {
                    clientOrderForm.Hide();
                }
            }
                clientRentForm.FormBorderStyle = FormBorderStyle.None;
                dataPanel.Controls.Add(clientRentForm);
                clientRentForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Form form in collection)
            {
                if (form.Name == "ClientRentForm")
                {
                    clientRentForm.Hide();
                }
                if (form.Name == "ClientOrderForm")
                {
                    clientOrderForm.Hide();
                }
            }
            clientOrderForm.FormBorderStyle = FormBorderStyle.None;
            dataPanel.Controls.Add(clientOrderForm);
            clientOrderForm.Show();
        }
    }
}
