﻿using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ClientForm : Form
    {
        public static int rowNumber;
        public static int nextRow;
        public static int idInt;
        private string id = "";

        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        ClientOptionsForm clientOptionsForm = new ClientOptionsForm() { TopLevel = true, TopMost = true };
        public ClientForm()
        {
            InitializeComponent();
        }

        private void getId()
        {
            idInt = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells[0].Value));
            Console.WriteLine(idInt.ToString());
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.KONTA_KLIENTOW' table. You can move, or remove it, as needed.
            this.kONTA_KLIENTOWTableAdapter.Fill(this.allDataSet.KONTA_KLIENTOW);
            // TODO: This line of code loads data into the 'allDataSet.KLIENCI' table. You can move, or remove it, as needed.
            this.kLIENCITableAdapter.Fill(this.allDataSet.KLIENCI);
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
            this.dataGridView2.Sort(this.dataGridView2.Columns[0], ListSortDirection.Ascending);
            nextRow = dataGridView1.Rows.Count;
            getId();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE KLIENCI SET ID_KON_KLIENT = NULL WHERE ID_KLIENT LIKE'" + rowNumber + "'", connection.connect());
            connection.open();
            command.ExecuteNonQuery();
            command.CommandText = "DELETE FROM KONTA_KLIENTOW WHERE ID_KON_KLIENT LIKE'" + rowNumber + "'";
            command.ExecuteNonQuery();
            command.CommandText = "DELETE FROM KLIENCI WHERE ID_KLIENT LIKE '" + rowNumber + "'";
            command.ExecuteNonQuery();
            command.CommandText = "DBCC CHECKIDENT (KONTA_KLIENTOW, RESEED, 0)";
            command.ExecuteNonQuery();
            command.CommandText = "DBCC CHECKIDENT (KLIENCI, RESEED, 0)";
            command.ExecuteNonQuery();
            command.CommandText = "DBCC CHECKIDENT (KONTA_KLIENTOW, RESEED)";
            command.ExecuteNonQuery();
            command.CommandText = "DBCC CHECKIDENT (KLIENCI, RESEED)";
            command.ExecuteNonQuery();
            connection.close();
            MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
            this.kONTA_KLIENTOWTableAdapter.Update(this.allDataSet.KONTA_KLIENTOW);
            this.kONTA_KLIENTOWTableAdapter.Fill(this.allDataSet.KONTA_KLIENTOW);
            this.kLIENCITableAdapter.Update(this.allDataSet.KLIENCI);
            this.kLIENCITableAdapter.Fill(this.allDataSet.KLIENCI);
            getId();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            clientOptionsForm.ShowDialog();
            getId();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber = Int32.Parse(id);
            clientOptionsForm.NameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            clientOptionsForm.SurnameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            clientOptionsForm.PeselTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            clientOptionsForm.PhoneTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            clientOptionsForm.FaxTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            clientOptionsForm.NipTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            clientOptionsForm.UsernameTextBox.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            clientOptionsForm.PasswordTextBox.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.kONTA_KLIENTOWTableAdapter.Update(this.allDataSet.KONTA_KLIENTOW);
            this.kONTA_KLIENTOWTableAdapter.Fill(this.allDataSet.KONTA_KLIENTOW);
            this.kLIENCITableAdapter.Update(this.allDataSet.KLIENCI);
            this.kLIENCITableAdapter.Fill(this.allDataSet.KLIENCI);
            nextRow = dataGridView1.Rows.Count;
            getId();
        }
    }
}
