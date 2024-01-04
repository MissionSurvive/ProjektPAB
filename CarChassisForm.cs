using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
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
            // TODO: This line of code loads data into the 'allDataSet.RODZAJE_NADWOZIA' table. You can move, or remove it, as needed.
            this.rODZAJE_NADWOZIATableAdapter.Fill(this.allDataSet.RODZAJE_NADWOZIA);
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                command = new SqlCommand("DELETE FROM RODZAJE_NADWOZIA WHERE ID_NADWOZIE LIKE'" + rowNumber + "'", connection.connect());
                try
                {
                    connection.open();
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
                    this.rODZAJE_NADWOZIATableAdapter.Update(this.allDataSet.RODZAJE_NADWOZIA);
                    this.rODZAJE_NADWOZIATableAdapter.Fill(this.allDataSet.RODZAJE_NADWOZIA);
                    ChassisTextBox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
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
                        this.rODZAJE_NADWOZIATableAdapter.Update(this.allDataSet.RODZAJE_NADWOZIA);
                        this.rODZAJE_NADWOZIATableAdapter.Fill(this.allDataSet.RODZAJE_NADWOZIA);
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
                        this.rODZAJE_NADWOZIATableAdapter.Update(this.allDataSet.RODZAJE_NADWOZIA);
                        this.rODZAJE_NADWOZIATableAdapter.Fill(this.allDataSet.RODZAJE_NADWOZIA);
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber = Int32.Parse(id);
            ChassisTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void FilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FilterCheck.Checked == true)
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
                this.rODZAJE_NADWOZIATableAdapter.Fill(this.allDataSet.RODZAJE_NADWOZIA);
                dataGridView1.DataSource = this.allDataSet.RODZAJE_NADWOZIA;
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterCheck.Checked == true)
            {
                using (CarRentalCWEntities db = new CarRentalCWEntities())
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = db.RODZAJE_NADWOZIA
                        .Where(
                        x => x.NAZWA_NADWOZIE.StartsWith(ChassisTextBox.Text)
                        )
                        .ToList();
                }
            }
        }
    }
}
