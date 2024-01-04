using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class OrderForm : Form
    {
        OrderPacketForm orderPacketForm = new OrderPacketForm() { TopLevel = false, TopMost = true };
        OrderOrderForm orderOrderForm = new OrderOrderForm() {  TopLevel = false, TopMost = true };
        FormCollection collection = Application.OpenForms;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                foreach (Form form in collection)
                {
                    if (form.Name == "OrderOrderForm")
                    {
                        orderOrderForm.Hide();
                    }
                    if (form.Name == "OrderPacketForm")
                    {
                        orderPacketForm.Hide();
                    }
                }
                orderPacketForm.FormBorderStyle = FormBorderStyle.None;
                panel2.Controls.Add(orderPacketForm);
                orderPacketForm.Show();
            }
            else MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Wydający")
            {
                foreach (Form form in collection)
                {
                    if (form.Name == "OrderOrderForm")
                    {
                        orderOrderForm.Hide();
                    }
                    if (form.Name == "OrderPacketForm")
                    {
                        orderPacketForm.Hide();
                    }
                }
                orderOrderForm.FormBorderStyle = FormBorderStyle.None;
                panel2.Controls.Add(orderOrderForm);
                orderOrderForm.Show();
            }
            else MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }
    }
}
