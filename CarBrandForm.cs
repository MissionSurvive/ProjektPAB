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
    public partial class CarBrandForm : Form
    {
        private int rowNumber;
        private string id = "";
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        public CarBrandForm()
        {
            InitializeComponent();
        }

        private void CarBrandForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalCWDataSet.MARKI' table. You can move, or remove it, as needed.
            this.mARKITableAdapter.Fill(this.carRentalCWDataSet.MARKI);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("DELETE FROM MARKI WHERE ID_MARKA LIKE'" + rowNumber + "'", connection.connect());
            connection.open();
            command.ExecuteNonQuery();
            connection.close();
            MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
            this.mARKITableAdapter.Update(this.carRentalCWDataSet.MARKI);
            this.mARKITableAdapter.Fill(this.carRentalCWDataSet.MARKI);
            BrandTextBox.Text = "";
            CountryTextBox.Text = "";
            RegionTextBox.Text = "";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber = Int32.Parse(id);
            BrandTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            CountryTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            RegionTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE MARKI SET NAZWA_MARKA = @BrandName, KRAJ = @Country, REGION = @Region WHERE ID_MARKA LIKE'" + rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@BrandName", BrandTextBox.Text);
            command.Parameters.AddWithValue("@Country", CountryTextBox.Text);
            command.Parameters.AddWithValue("@Region", RegionTextBox.Text);
            try
            {
                connection.open();
                if(string.IsNullOrEmpty(BrandTextBox.Text))
                {
                    MessageBox.Show("Nazwa marki nie może być pusta!");
                } else
                {
                    if(string.IsNullOrEmpty(CountryTextBox.Text))
                    {
                        CountryTextBox.Text = null;
                    } else if(string.IsNullOrEmpty(RegionTextBox.Text))
                    {
                        RegionTextBox.Text = null;
                    }
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Zaktualizowano rekord z ID: " + rowNumber + " !");
                    this.mARKITableAdapter.Update(this.carRentalCWDataSet.MARKI);
                    this.mARKITableAdapter.Fill(this.carRentalCWDataSet.MARKI);
                } 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("INSERT INTO MARKI (NAZWA_MARKA, KRAJ, REGION) VALUES (@BrandName, @Country, @Region)", connection.connect());
            command.Parameters.AddWithValue("@BrandName", BrandTextBox.Text);
            command.Parameters.AddWithValue("@Country", CountryTextBox.Text);
            command.Parameters.AddWithValue("@Region", RegionTextBox.Text);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(BrandTextBox.Text))
                {
                    MessageBox.Show("Nazwa marki nie może być pusta!");
                }
                else
                {
                    if (string.IsNullOrEmpty(CountryTextBox.Text))
                    {
                        CountryTextBox.Text = null;
                    }
                    else if (string.IsNullOrEmpty(RegionTextBox.Text))
                    {
                        RegionTextBox.Text = null;
                    }
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Dodano rekord pomyślnie!");
                    this.mARKITableAdapter.Update(this.carRentalCWDataSet.MARKI);
                    this.mARKITableAdapter.Fill(this.carRentalCWDataSet.MARKI);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
