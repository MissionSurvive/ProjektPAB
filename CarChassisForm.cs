﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarChassisForm : Form
    {
        private int rowNumber;
        private string id = "";
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        public CarChassisForm()
        {
            InitializeComponent();
        }

        private void CarChassisForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalCWDataSet.RODZAJE_NADWOZIA' table. You can move, or remove it, as needed.
            this.rODZAJE_NADWOZIATableAdapter.Fill(this.carRentalCWDataSet.RODZAJE_NADWOZIA);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("DELETE FROM RODZAJE_NADWOZIA WHERE ID_NADWOZIE LIKE'" + rowNumber + "'", connection.connect());
            connection.open();
            command.ExecuteNonQuery();
            connection.close();
            MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
            this.rODZAJE_NADWOZIATableAdapter.Update(this.carRentalCWDataSet.RODZAJE_NADWOZIA);
            this.rODZAJE_NADWOZIATableAdapter.Fill(this.carRentalCWDataSet.RODZAJE_NADWOZIA);
            ChassisTextBox.Text = "";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE RODZAJE_NADWOZIA SET NAZWA_NADWOZIE = @ChassisName WHERE ID_NADWOZIE LIKE'" + rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@ChassisName", ChassisTextBox.Text);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(ChassisTextBox.Text))
                {
                    MessageBox.Show("Nazwa nadwozia nie może być pusta!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Zaktualizowano rekord z ID: " + rowNumber + " !");
                    this.rODZAJE_NADWOZIATableAdapter.Update(this.carRentalCWDataSet.RODZAJE_NADWOZIA);
                    this.rODZAJE_NADWOZIATableAdapter.Fill(this.carRentalCWDataSet.RODZAJE_NADWOZIA);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("INSERT INTO RODZAJE_NADWOZIA (NAZWA_NADWOZIE) VALUES (@ChassisName)", connection.connect());
            command.Parameters.AddWithValue("@ChassisName", ChassisTextBox.Text);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(ChassisTextBox.Text))
                {
                    MessageBox.Show("Nazwa nadwozia nie może być pusta!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Dodano rekord pomyślnie!");
                    this.rODZAJE_NADWOZIATableAdapter.Update(this.carRentalCWDataSet.RODZAJE_NADWOZIA);
                    this.rODZAJE_NADWOZIATableAdapter.Fill(this.carRentalCWDataSet.RODZAJE_NADWOZIA);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber = Int32.Parse(id);
            ChassisTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
