using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarModelForm : Form
    {
        public static int rowNumber;
        private string id = "";
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        CarModelOptionsForm carModelOptionsForm = new CarModelOptionsForm() { TopLevel = true, TopMost = true };
        FormCollection collection = Application.OpenForms;
        public CarModelForm()
        {
            InitializeComponent();
        }

        private void CarModelForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.MODELE' table. You can move, or remove it, as needed.
            this.mODELETableAdapter.Fill(this.allDataSet.MODELE);
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        public void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber = Int32.Parse(id);
            carModelOptionsForm.BrandCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            carModelOptionsForm.ChassisCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            carModelOptionsForm.ModelTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            carModelOptionsForm.YearTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            carModelOptionsForm.GenerationTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            carModelOptionsForm.SegmentTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            this.mODELETableAdapter.Update(this.allDataSet.MODELE);
            this.mODELETableAdapter.Fill(this.allDataSet.MODELE);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                carModelOptionsForm.ShowDialog();
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                command = new SqlCommand("DELETE FROM MODELE WHERE ID_MODEL LIKE'" + rowNumber + "'", connection.connect());
                connection.open();
                command.ExecuteNonQuery();
                connection.close();
                MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
                this.mODELETableAdapter.Update(this.allDataSet.MODELE);
                this.mODELETableAdapter.Fill(this.allDataSet.MODELE);
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void FilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FilterCheck.Checked == true)
            {
                AddButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            else
            {
                AddButton.Enabled = true;
                DeleteButton.Enabled = true;
                this.mODELETableAdapter.Fill(this.allDataSet.MODELE);
                dataGridView1.DataSource = this.allDataSet.MODELE;
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterCheck.Checked == true)
            {
                using (CarRentalCWEntities db = new CarRentalCWEntities())
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = db.MODELE
                        .Where(
                        x => x.NAZWA_MODEL.StartsWith(ModelTextBox.Text)
                        )
                        .ToList();
                }
            }
        }
    }
}
