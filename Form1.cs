﻿using System;
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
        CarForm carForm = new CarForm() { TopLevel = false, TopMost = true };
        OrderForm orderForm = new OrderForm() { TopLevel = false, TopMost = true };
        RentalPlacesForm rentalPlacesForm = new RentalPlacesForm() { TopLevel = false, TopMost = true };
        RoleForm roleForm = new RoleForm() { TopLevel = false, TopMost = true };
        FormCollection collection = Application.OpenForms;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            }
            carForm.FormBorderStyle = FormBorderStyle.None;
            dataPanel.Controls.Add(carForm);
            carForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
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
            }
            orderForm.FormBorderStyle = FormBorderStyle.None;
            dataPanel.Controls.Add(orderForm);
            orderForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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
            }
            rentalPlacesForm.FormBorderStyle = FormBorderStyle.None;
            dataPanel.Controls.Add(rentalPlacesForm);
            rentalPlacesForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
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
            }
            roleForm.FormBorderStyle = FormBorderStyle.None;
            dataPanel.Controls.Add(roleForm);
            roleForm.Show();
        }
    }
}
