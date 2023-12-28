using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarCarForm : Form
    {
        public static int rowNumber;
        public static int nextRow;
        public static int idInt;
        private string id = "";
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        CarCarOptionsForm carCarOptionsForm = new CarCarOptionsForm() { TopLevel = true, TopMost = true };
        public CarCarForm()
        {
            InitializeComponent();
        }

        private void getId()
        {
            idInt = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells[0].Value));
            Console.WriteLine(idInt.ToString());
        }

        private void CarCarForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.WYPOZYCZALNIE' table. You can move, or remove it, as needed.
            this.wYPOZYCZALNIETableAdapter.Fill(this.allDataSet.WYPOZYCZALNIE);
            // TODO: This line of code loads data into the 'allDataSet.RODZAJE_PALIWA' table. You can move, or remove it, as needed.
            this.rODZAJE_PALIWATableAdapter.Fill(this.allDataSet.RODZAJE_PALIWA);
            // TODO: This line of code loads data into the 'allDataSet.SAMOCHODY' table. You can move, or remove it, as needed.
            this.sAMOCHODYTableAdapter.Fill(this.allDataSet.SAMOCHODY);
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                command = new SqlCommand("DELETE FROM SAMOCHODY WHERE ID_SAMOCHOD LIKE'" + rowNumber + "'", connection.connect());
                connection.open();
                command.ExecuteNonQuery();
                command.CommandText = "DBCC CHECKIDENT (SAMOCHODY, RESEED, 0)";
                command.ExecuteNonQuery();
                command.CommandText = "DBCC CHECKIDENT (SAMOCHODY, RESEED)";
                command.ExecuteNonQuery();
                connection.close();
                MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
                this.sAMOCHODYTableAdapter.Update(this.allDataSet.SAMOCHODY);
                this.sAMOCHODYTableAdapter.Fill(this.allDataSet.SAMOCHODY);
                getId();
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                carCarOptionsForm.ShowDialog();
                getId();
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!"); 
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber = Int32.Parse(id);
            carCarOptionsForm.ColorTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            carCarOptionsForm.OdometerNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            carCarOptionsForm.VinTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            carCarOptionsForm.DisplacementNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            carCarOptionsForm.PowerNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            carCarOptionsForm.VinTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            carCarOptionsForm.PowerNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            carCarOptionsForm.GearboxTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            carCarOptionsForm.SeatsNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            carCarOptionsForm.DayNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            carCarOptionsForm.WeekNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            carCarOptionsForm.MonthNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            carCarOptionsForm.DepositNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            this.sAMOCHODYTableAdapter.Update(this.allDataSet.SAMOCHODY);
            this.sAMOCHODYTableAdapter.Fill(this.allDataSet.SAMOCHODY);
            nextRow = dataGridView1.Rows.Count;
            getId();
        }
    }
}
