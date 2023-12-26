using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental
{
    public partial class RoleForm : Form
    {
        private int rowNumber;
        private string id = "";
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        public RoleForm()
        {
            InitializeComponent();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.allDataSet.ROLE);
            // TODO: This line of code loads data into the 'carRentalCWDataSet.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.allDataSet.ROLE);
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("DELETE FROM ROLE WHERE ID_ROLA LIKE'" + rowNumber + "'", connection.connect());
            connection.open();
            command.ExecuteNonQuery();
            connection.close();
            MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
            this.rOLETableAdapter.Update(this.allDataSet.ROLE);
            this.rOLETableAdapter.Fill(this.allDataSet.ROLE);
            RoleTextBox.Text = "";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE ROLE SET ROLA = @RoleName WHERE ID_ROLA LIKE'" + rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@RoleName", RoleTextBox.Text);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(RoleTextBox.Text))
                {
                    MessageBox.Show("Nazwa roli nie może być pusta!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Zaktualizowano rekord z ID: " + rowNumber + " !");
                    this.rOLETableAdapter.Update(this.allDataSet.ROLE);
                    this.rOLETableAdapter.Fill(this.allDataSet.ROLE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("INSERT INTO ROLE (ROLA) VALUES (@RoleName)", connection.connect());
            command.Parameters.AddWithValue("@RoleName", RoleTextBox.Text);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(RoleTextBox.Text))
                {
                    MessageBox.Show("Nazwa roli nie może być pusta!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Dodano rekord pomyślnie!");
                    this.rOLETableAdapter.Update(this.allDataSet.ROLE);
                    this.rOLETableAdapter.Fill(this.allDataSet.ROLE);
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
            RoleTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
