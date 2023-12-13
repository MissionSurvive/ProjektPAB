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
    public partial class CarForm : Form
    {
        CarBrandForm carBrandForm = new CarBrandForm() { TopLevel = false, TopMost = true };
        CarCarForm carCarForm = new CarCarForm() { TopLevel = false, TopMost = true };
        CarChassisForm carChassisForm = new CarChassisForm() { TopLevel = false, TopMost = true };
        CarFuelForm carFuelForm = new CarFuelForm() { TopLevel = false, TopMost = true };
        FormCollection collection = Application.OpenForms;

        public CarForm()
        {
            InitializeComponent();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalCWDataSet.SAMOCHODY' table. You can move, or remove it, as needed.
            this.sAMOCHODYTableAdapter.Fill(this.carRentalCWDataSet.SAMOCHODY);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Form form in collection)
            {
                if (form.Name == "CarCarForm")
                {
                    carCarForm.Hide();
                }
                if (form.Name == "CarBrandForm")
                {
                    carBrandForm.Hide();
                }
                if (form.Name == "CarChassisForm")
                {
                    carChassisForm.Hide();
                }
                if (form.Name == "CarFuelForm")
                {
                    carFuelForm.Hide();
                }
            }
            
            carBrandForm.FormBorderStyle = FormBorderStyle.None;
            carPanel.Controls.Add(carBrandForm);
            carBrandForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Form form in collection)
            {
                if (form.Name == "CarCarForm")
                {
                    carCarForm.Hide();
                }
                if (form.Name == "CarBrandForm")
                {
                    carBrandForm.Hide();
                }
                if (form.Name == "CarChassisForm")
                {
                    carChassisForm.Hide();
                }
                if (form.Name == "CarFuelForm")
                {
                    carFuelForm.Hide();
                }
            }
            carCarForm.FormBorderStyle = FormBorderStyle.None;
            carPanel.Controls.Add(carCarForm);
            carCarForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form form in collection)
            {
                if (form.Name == "CarCarForm")
                {
                    carCarForm.Hide();
                }
                if (form.Name == "CarBrandForm")
                {
                    carBrandForm.Hide();
                }
                if (form.Name == "CarChassisForm")
                {
                    carChassisForm.Hide();
                }
                if (form.Name == "CarFuelForm")
                {
                    carFuelForm.Hide();
                }
            }
            carChassisForm.FormBorderStyle = FormBorderStyle.None;
            carPanel.Controls.Add(carChassisForm);
            carChassisForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form form in collection)
            {
                if (form.Name == "CarCarForm")
                {
                    carCarForm.Hide();
                }
                if (form.Name == "CarBrandForm")
                {
                    carBrandForm.Hide();
                }
                if (form.Name == "CarChassisForm")
                {
                    carChassisForm.Hide();
                }
                if (form.Name == "CarFuelForm")
                {
                    carFuelForm.Hide();
                }
            }
            carFuelForm.FormBorderStyle = FormBorderStyle.None;
            carPanel.Controls.Add(carFuelForm);
            carFuelForm.Show();
        }
    }
}
