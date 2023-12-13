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
    public partial class CarModelForm : Form
    {
        public CarModelForm()
        {
            InitializeComponent();
        }

        private void CarModelForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalCWDataSet.MODELE' table. You can move, or remove it, as needed.
            this.mODELETableAdapter.Fill(this.carRentalCWDataSet.MODELE);

        }
    }
}
