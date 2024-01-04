using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Form1 : Form
    {
        CarForm carForm = new CarForm() { TopLevel = false, TopMost = true };
        OrderForm orderForm = new OrderForm() { TopLevel = false, TopMost = true };
        RentalPlacesForm rentalPlacesForm = new RentalPlacesForm() { TopLevel = false, TopMost = true };
        RoleForm roleForm = new RoleForm() { TopLevel = false, TopMost = true };
        EmployeeForm employeeForm = new EmployeeForm() { TopLevel = false, TopMost = true };
        ClientForm clientForm = new ClientForm() { TopLevel = false, TopMost = true };
        OrderHistoryForm orderHistoryForm = new OrderHistoryForm() { TopLevel = false, TopMost = true };
        ReportForm reportForm = new ReportForm() { TopLevel = false, TopMost = true };
        
        FormCollection collection = Application.OpenForms;
        public Form1()
        {
            InitializeComponent();
            userLabel.Text = LoginForm.username + " " + LoginForm.surname;
            roleLabel.Text = LoginForm.userRoleLogged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(LoginForm.userRoleLogged == "Administrator" ||  LoginForm.userRoleLogged == "Wydający" || LoginForm.userRoleLogged == "Mechanik")
            {
                foreach (Form form in collection)
                {
                    if (form.Name == "CarForm")
                    {
                        carForm.Hide();
                    }
                    if (form.Name == "OrderForm")
                    {
                        orderForm.Hide();
                    }
                    if (form.Name == "RentalPlacesForm")
                    {
                        rentalPlacesForm.Hide();
                    }
                    if (form.Name == "RoleForm")
                    {
                        roleForm.Hide();
                    }
                    if (form.Name == "EmployeeForm")
                    {
                        employeeForm.Hide();
                    }
                    if (form.Name == "ClientForm")
                    {
                        clientForm.Hide();
                    }
                    if (form.Name == "OrderHistoryForm")
                    {
                        orderHistoryForm.Hide();
                    }
                    if (form.Name == "ReportForm")
                    {
                        reportForm.Hide();
                    }
                }
                carForm.FormBorderStyle = FormBorderStyle.None;
                dataPanel.Controls.Add(carForm);
                carForm.Show();
            }
            else MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Wydający" || LoginForm.userRoleLogged == "Mechanik")
            {
                foreach (Form form in collection)
                {
                    if (form.Name == "CarForm")
                    {
                        carForm.Hide();
                    }
                    if (form.Name == "OrderForm")
                    {
                        orderForm.Hide();
                    }
                    if (form.Name == "RentalPlacesForm")
                    {
                        rentalPlacesForm.Hide();
                    }
                    if (form.Name == "RoleForm")
                    {
                        roleForm.Hide();
                    }
                    if (form.Name == "EmployeeForm")
                    {
                        employeeForm.Hide();
                    }
                    if (form.Name == "ClientForm")
                    {
                        clientForm.Hide();
                    }
                    if (form.Name == "OrderHistoryForm")
                    {
                        orderHistoryForm.Hide();
                    }
                    if (form.Name == "ReportForm")
                    {
                        reportForm.Hide();
                    }
                }
                orderForm.FormBorderStyle = FormBorderStyle.None;
                dataPanel.Controls.Add(orderForm);
                orderForm.Show();
            }
            else MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(LoginForm.userRoleLogged == "Administrator" ||  LoginForm.userRoleLogged == "Prezes")
            {
                foreach (Form form in collection)
                {
                    if (form.Name == "CarForm")
                    {
                        carForm.Hide();
                    }
                    if (form.Name == "OrderForm")
                    {
                        orderForm.Hide();
                    }
                    if (form.Name == "RentalPlacesForm")
                    {
                        rentalPlacesForm.Hide();
                    }
                    if (form.Name == "RoleForm")
                    {
                        roleForm.Hide();
                    }
                    if (form.Name == "EmployeeForm")
                    {
                        employeeForm.Hide();
                    }
                    if (form.Name == "ClientForm")
                    {
                        clientForm.Hide();
                    }
                    if (form.Name == "OrderHistoryForm")
                    {
                        orderHistoryForm.Hide();
                    }
                    if (form.Name == "ReportForm")
                    {
                        reportForm.Hide();
                    }
                }
                rentalPlacesForm.FormBorderStyle = FormBorderStyle.None;
                dataPanel.Controls.Add(rentalPlacesForm);
                rentalPlacesForm.Show();
            }
            else MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator")
            {
                foreach (Form form in collection)
                {
                    if (form.Name == "CarForm")
                    {
                        carForm.Hide();
                    }
                    if (form.Name == "OrderForm")
                    {
                        orderForm.Hide();
                    }
                    if (form.Name == "RentalPlacesForm")
                    {
                        rentalPlacesForm.Hide();
                    }
                    if (form.Name == "RoleForm")
                    {
                        roleForm.Hide();
                    }
                    if (form.Name == "EmployeeForm")
                    {
                        employeeForm.Hide();
                    }
                    if (form.Name == "ClientForm")
                    {
                        clientForm.Hide();
                    }
                    if (form.Name == "OrderHistoryForm")
                    {
                        orderHistoryForm.Hide();
                    }
                    if (form.Name == "ReportForm")
                    {
                        reportForm.Hide();
                    }
                }
                roleForm.FormBorderStyle = FormBorderStyle.None;
                dataPanel.Controls.Add(roleForm);
                roleForm.Show();
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(LoginForm.userRoleLogged == "Administrator" ||  LoginForm.userRoleLogged == "Prezes")
            {
                foreach (Form form in collection)
                {
                    if (form.Name == "CarForm")
                    {
                        carForm.Hide();
                    }
                    if (form.Name == "OrderForm")
                    {
                        orderForm.Hide();
                    }
                    if (form.Name == "RentalPlacesForm")
                    {
                        rentalPlacesForm.Hide();
                    }
                    if (form.Name == "RoleForm")
                    {
                        roleForm.Hide();
                    }
                    if (form.Name == "EmployeeForm")
                    {
                        employeeForm.Hide();
                    }
                    if (form.Name == "ClientForm")
                    {
                        clientForm.Hide();
                    }
                    if (form.Name == "OrderHistoryForm")
                    {
                        orderHistoryForm.Hide();
                    }
                    if (form.Name == "ReportForm")
                    {
                        reportForm.Hide();
                    }
                }
                employeeForm.FormBorderStyle = FormBorderStyle.None;
                dataPanel.Controls.Add(employeeForm);
                employeeForm.Show();
            }
            else MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(LoginForm.userRoleLogged == "Administrator" ||  LoginForm.userRoleLogged == "Wydający")
            {
                foreach (Form form in collection)
                {
                    if (form.Name == "CarForm")
                    {
                        carForm.Hide();
                    }
                    if (form.Name == "OrderForm")
                    {
                        orderForm.Hide();
                    }
                    if (form.Name == "RentalPlacesForm")
                    {
                        rentalPlacesForm.Hide();
                    }
                    if (form.Name == "RoleForm")
                    {
                        roleForm.Hide();
                    }
                    if (form.Name == "EmployeeForm")
                    {
                        employeeForm.Hide();
                    }
                    if (form.Name == "ClientForm")
                    {
                        clientForm.Hide();
                    }
                    if (form.Name == "OrderHistoryForm")
                    {
                        orderHistoryForm.Hide();
                    }
                    if (form.Name == "ReportForm")
                    {
                        reportForm.Hide();
                    }
                }
                clientForm.FormBorderStyle = FormBorderStyle.None;
                dataPanel.Controls.Add(clientForm);
                clientForm.Show();
            }
            else MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(LoginForm.userRoleLogged == "Administrator" ||  LoginForm.userRoleLogged == "Wydający")
            {
                foreach (Form form in collection)
                {
                    if (form.Name == "CarForm")
                    {
                        carForm.Hide();
                    }
                    if (form.Name == "OrderForm")
                    {
                        orderForm.Hide();
                    }
                    if (form.Name == "RentalPlacesForm")
                    {
                        rentalPlacesForm.Hide();
                    }
                    if (form.Name == "RoleForm")
                    {
                        roleForm.Hide();
                    }
                    if (form.Name == "EmployeeForm")
                    {
                        employeeForm.Hide();
                    }
                    if (form.Name == "ClientForm")
                    {
                        clientForm.Hide();
                    }
                    if (form.Name == "OrderHistoryForm")
                    {
                        orderHistoryForm.Hide();
                    }
                    if (form.Name == "ReportForm")
                    {
                        reportForm.Hide();
                    }
                }
                orderHistoryForm.FormBorderStyle = FormBorderStyle.None;
                dataPanel.Controls.Add(orderHistoryForm);
                orderHistoryForm.Show();
            }
            else MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Prezes")
            {
                foreach (Form form in collection)
                {
                    if (form.Name == "CarForm")
                    {
                        carForm.Hide();
                    }
                    if (form.Name == "OrderForm")
                    {
                        orderForm.Hide();
                    }
                    if (form.Name == "RentalPlacesForm")
                    {
                        rentalPlacesForm.Hide();
                    }
                    if (form.Name == "RoleForm")
                    {
                        roleForm.Hide();
                    }
                    if (form.Name == "EmployeeForm")
                    {
                        employeeForm.Hide();
                    }
                    if (form.Name == "ClientForm")
                    {
                        clientForm.Hide();
                    }
                    if (form.Name == "OrderHistoryForm")
                    {
                        orderHistoryForm.Hide();
                    }
                    if (form.Name == "ReportForm")
                    {
                        reportForm.Hide();
                    }
                }
                reportForm.FormBorderStyle = FormBorderStyle.None;
                dataPanel.Controls.Add(reportForm);
                reportForm.Show();
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Dispose();
            loginForm.Show();
        }
    }
}
