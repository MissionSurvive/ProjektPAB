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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarForm carForm = new CarForm() { TopLevel = false, TopMost = true };
            carForm.FormBorderStyle = FormBorderStyle.None;
            dataPanel.Controls.Add(carForm);
            carForm.Show();
        }
    }
}
