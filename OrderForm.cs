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

        private void button8_Click(object sender, EventArgs e)
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
    }
}
