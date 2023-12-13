using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class OrderForm : Form
    {
        OrderPacketForm orderPacketForm = new OrderPacketForm() { TopLevel = false, TopMost = true };
        FormCollection collection = Application.OpenForms;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            orderPacketForm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(orderPacketForm);
            orderPacketForm.Show();
        }
    }
}
