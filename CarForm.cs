using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarForm : Form
    {
        CarBrandForm carBrandForm = new CarBrandForm() { TopLevel = false, TopMost = true };
        CarCarForm carCarForm = new CarCarForm() { TopLevel = false, TopMost = true };
        CarChassisForm carChassisForm = new CarChassisForm() { TopLevel = false, TopMost = true };
        CarFuelForm carFuelForm = new CarFuelForm() { TopLevel = false, TopMost = true };
        CarModelForm carModelForm = new CarModelForm() { TopLevel = false, TopMost = true };
        FormCollection collection = Application.OpenForms;

        public CarForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Wydający" || LoginForm.userRoleLogged == "Mechanik")
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
                    if (form.Name == "CarModelForm")
                    {
                        carModelForm.Hide();
                    }
                }

                carBrandForm.FormBorderStyle = FormBorderStyle.None;
                carPanel.Controls.Add(carBrandForm);
                carBrandForm.Show();
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!"); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Wydający" || LoginForm.userRoleLogged == "Mechanik")
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
                    if (form.Name == "CarModelForm")
                    {
                        carModelForm.Hide();
                    }
                }
                carCarForm.FormBorderStyle = FormBorderStyle.None;
                carPanel.Controls.Add(carCarForm);
                carCarForm.Show();
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Wydający" || LoginForm.userRoleLogged == "Mechanik")
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
                    if (form.Name == "CarModelForm")
                    {
                        carModelForm.Hide();
                    }
                }
                carChassisForm.FormBorderStyle = FormBorderStyle.None;
                carPanel.Controls.Add(carChassisForm);
                carChassisForm.Show();
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Wydający" || LoginForm.userRoleLogged == "Mechanik")
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
                    if (form.Name == "CarModelForm")
                    {
                        carModelForm.Hide();
                    }
                }
                carFuelForm.FormBorderStyle = FormBorderStyle.None;
                carPanel.Controls.Add(carFuelForm);
                carFuelForm.Show();
            }
            else MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Wydający" || LoginForm.userRoleLogged == "Mechanik")
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
                    if (form.Name == "CarModelForm")
                    {
                        carModelForm.Hide();
                    }
                }
                carModelForm.FormBorderStyle = FormBorderStyle.None;
                carPanel.Controls.Add(carModelForm);
                carModelForm.Show();
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }
    }
}
