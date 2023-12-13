using System;
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
    public partial class RentalPlacesForm : Form
    {
        private int rowNumber;
        private string id = "";
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        public RentalPlacesForm()
        {
            InitializeComponent();
        }

        private void RentalPlacesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalCWDataSet.WYPOZYCZALNIE' table. You can move, or remove it, as needed.
            this.wYPOZYCZALNIETableAdapter.Fill(this.carRentalCWDataSet.WYPOZYCZALNIE);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("DELETE FROM WYPOZYCZALNIE WHERE ID_WYPOZYCZALNIA LIKE'" + rowNumber + "'", connection.connect());
            connection.open();
            command.ExecuteNonQuery();
            connection.close();
            MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
            this.wYPOZYCZALNIETableAdapter.Update(this.carRentalCWDataSet.WYPOZYCZALNIE);
            this.wYPOZYCZALNIETableAdapter.Fill(this.carRentalCWDataSet.WYPOZYCZALNIE);
            CityTextBox.Text = "";
            AddressTextBox.Text = "";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE WYPOZYCZALNIE SET MIASTO = @City, ADRES = @Address WHERE ID_WYPOZYCZALNIA LIKE'" + rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@City", CityTextBox.Text);
            command.Parameters.AddWithValue("@Address", AddressTextBox.Text);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(CityTextBox.Text))
                {
                    MessageBox.Show("Nazwa miasta nie może być pusta!");
                }
                else if (string.IsNullOrEmpty(AddressTextBox.Text))
                {
                    MessageBox.Show("Adres nie może być pusty!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Zaktualizowano rekord z ID: " + rowNumber + " !");
                    this.wYPOZYCZALNIETableAdapter.Update(this.carRentalCWDataSet.WYPOZYCZALNIE);
                    this.wYPOZYCZALNIETableAdapter.Fill(this.carRentalCWDataSet.WYPOZYCZALNIE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("INSERT INTO WYPOZYCZALNIE (MIASTO, ADRES) VALUES (@City, @Address)", connection.connect());
            command.Parameters.AddWithValue("@City", CityTextBox.Text);
            command.Parameters.AddWithValue("@Address", AddressTextBox.Text);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(CityTextBox.Text))
                {
                    MessageBox.Show("Nazwa miasta nie może być pusta!");
                }
                else if (string.IsNullOrEmpty(AddressTextBox.Text))
                {
                    MessageBox.Show("Adres nie może być pusty!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Dodano rekord pomyślnie!");
                    this.wYPOZYCZALNIETableAdapter.Update(this.carRentalCWDataSet.WYPOZYCZALNIE);
                    this.wYPOZYCZALNIETableAdapter.Fill(this.carRentalCWDataSet.WYPOZYCZALNIE);
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
            CityTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            AddressTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
