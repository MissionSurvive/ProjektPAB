using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

        private object CheckNull(string data)
        {
            return string.IsNullOrEmpty(data) ? DBNull.Value : (object)data;
        }

        private void CarBrandForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.MARKI' table. You can move, or remove it, as needed.
            this.mARKITableAdapter.Fill(this.allDataSet.MARKI);
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                command = new SqlCommand("DELETE FROM MARKI WHERE ID_MARKA LIKE'" + rowNumber + "'", connection.connect());
                connection.open();
                command.ExecuteNonQuery();
                connection.close();
                MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
                this.mARKITableAdapter.Update(this.allDataSet.MARKI);
                this.mARKITableAdapter.Fill(this.allDataSet.MARKI);
                BrandTextBox.Text = "";
                CountryTextBox.Text = "";
                RegionTextBox.Text = "";
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowNumber = Int32.Parse(id);
                BrandTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                CountryTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                RegionTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                command = new SqlCommand("UPDATE MARKI SET NAZWA_MARKA = @BrandName, KRAJ = @Country, REGION = @Region WHERE ID_MARKA LIKE'" + rowNumber + "'", connection.connect());
                command.Parameters.AddWithValue("@BrandName", BrandTextBox.Text);
                command.Parameters.AddWithValue("@Country", CheckNull(CountryTextBox.Text));
                command.Parameters.AddWithValue("@Region", CheckNull(RegionTextBox.Text));
                try
                {
                    connection.open();
                    if (string.IsNullOrEmpty(BrandTextBox.Text))
                    {
                        MessageBox.Show("Nazwa marki nie może być pusta!");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        connection.close();
                        MessageBox.Show("Zaktualizowano rekord z ID: " + rowNumber + " !");
                        this.mARKITableAdapter.Update(this.allDataSet.MARKI);
                        this.mARKITableAdapter.Fill(this.allDataSet.MARKI);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!"); 
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                command = new SqlCommand("INSERT INTO MARKI (NAZWA_MARKA, KRAJ, REGION) VALUES (@BrandName, @Country, @Region)", connection.connect());
                command.Parameters.AddWithValue("@BrandName", BrandTextBox.Text);
                command.Parameters.AddWithValue("@Country", CheckNull(CountryTextBox.Text));
                command.Parameters.AddWithValue("@Region", CheckNull(RegionTextBox.Text));
                try
                {
                    connection.open();
                    if (string.IsNullOrEmpty(BrandTextBox.Text))
                    {
                        MessageBox.Show("Nazwa marki nie może być pusta!");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        connection.close();
                        MessageBox.Show("Dodano rekord pomyślnie!");
                        this.mARKITableAdapter.Update(this.allDataSet.MARKI);
                        this.mARKITableAdapter.Fill(this.allDataSet.MARKI);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
            
        }

        private void FilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(FilterCheck.Checked == true)
            {
                AddButton.Enabled = false;
                UpdateButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            else
            {
                AddButton.Enabled = true;
                UpdateButton.Enabled = true;
                DeleteButton.Enabled = true;
                this.mARKITableAdapter.Fill(this.allDataSet.MARKI);
                dataGridView1.DataSource = this.allDataSet.MARKI;
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if(FilterCheck.Checked == true)
            {
                using (CarRentalCWEntities db = new CarRentalCWEntities())
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = db.MARKI
                        .Where(
                        x => x.NAZWA_MARKA.StartsWith(BrandTextBox.Text) 
                        && x.KRAJ.StartsWith(CountryTextBox.Text)
                        && x.REGION.StartsWith(RegionTextBox.Text)
                        )
                        .ToList();
                }
            }
        }
    }
}
