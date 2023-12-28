using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarFuelForm : Form
    {
        private int rowNumber;
        private string id = "";
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        public CarFuelForm()
        {
            InitializeComponent();
        }

        private void CarFuelForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.RODZAJE_PALIWA' table. You can move, or remove it, as needed.
            this.rODZAJE_PALIWATableAdapter.Fill(this.allDataSet.RODZAJE_PALIWA);
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                command = new SqlCommand("DELETE FROM RODZAJE_PALIWA WHERE ID_PALIWO LIKE'" + rowNumber + "'", connection.connect());
                connection.open();
                command.ExecuteNonQuery();
                connection.close();
                MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
                this.rODZAJE_PALIWATableAdapter.Update(this.allDataSet.RODZAJE_PALIWA);
                this.rODZAJE_PALIWATableAdapter.Fill(this.allDataSet.RODZAJE_PALIWA);
                FuelTextBox.Text = "";
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber = Int32.Parse(id);
            FuelTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                command = new SqlCommand("UPDATE RODZAJE_PALIWA SET NAZWA_RODZAJ = @FuelName WHERE ID_PALIWO LIKE'" + rowNumber + "'", connection.connect());
                command.Parameters.AddWithValue("@FuelName", FuelTextBox.Text);
                try
                {
                    connection.open();
                    if (string.IsNullOrEmpty(FuelTextBox.Text))
                    {
                        MessageBox.Show("Nazwa paliwa nie może być pusta!");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        connection.close();
                        MessageBox.Show("Zaktualizowano rekord z ID: " + rowNumber + " !");
                        this.rODZAJE_PALIWATableAdapter.Update(this.allDataSet.RODZAJE_PALIWA);
                        this.rODZAJE_PALIWATableAdapter.Fill(this.allDataSet.RODZAJE_PALIWA);
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
                command = new SqlCommand("INSERT INTO RODZAJE_PALIWA (NAZWA_RODZAJ) VALUES (@FuelName)", connection.connect());
                command.Parameters.AddWithValue("@FuelName", FuelTextBox.Text);
                try
                {
                    connection.open();
                    if (string.IsNullOrEmpty(FuelTextBox.Text))
                    {
                        MessageBox.Show("Nazwa paliwa nie może być pusta!");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        connection.close();
                        MessageBox.Show("Dodano rekord pomyślnie!");
                        this.rODZAJE_PALIWATableAdapter.Update(this.allDataSet.RODZAJE_PALIWA);
                        this.rODZAJE_PALIWATableAdapter.Fill(this.allDataSet.RODZAJE_PALIWA);
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
    }
}
