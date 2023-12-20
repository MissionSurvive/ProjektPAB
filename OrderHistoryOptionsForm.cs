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
    public partial class OrderHistoryOptionsForm : Form
    {
        public static int rowNumber;
        public static int rowNumber2;
        public static int nextRow;
        public static int idInt;
        private string id = "";
        private string id2 = "";
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        public OrderHistoryOptionsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrderHistoryOptionsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.PRACOWNICY' table. You can move, or remove it, as needed.
            this.pRACOWNICYTableAdapter.Fill(this.allDataSet.PRACOWNICY);

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber = Int32.Parse(id);
            EmployeeCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE HISTORIA_ZAMOWIENIA SET ID_PRAC = @Employee, DATA_WYDANIE = @Start, DATA_PRZYJECIE = @End, " +
                "TANKOWANIE = @Fueled, ILOSC_TANKOWANIE = @Count, KOSZT_TANKOWANIE = @Price, KOLIZJA = @Collision, DATA_KOLIZJA = @Date, " +
                "KARA_KOLIZJA = @Penalty WHERE ID_HISTORIA LIKE'" + OrderHistoryForm.rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@Employee", EmployeeCombo.SelectedValue);
            command.Parameters.AddWithValue("@Start", StartDatePicker.Value);
            command.Parameters.AddWithValue("@End", EndDatePicker.Value);
            command.Parameters.AddWithValue("@Fueled", FueledCheck.Checked);
            command.Parameters.AddWithValue("@Count", CountNumeric.Value);
            command.Parameters.AddWithValue("@Price", PriceNumeric.Value);
            command.Parameters.AddWithValue("@Collision", CollisionCheck.Checked);
            command.Parameters.AddWithValue("@Date", CollisionDatePicker.Value);
            command.Parameters.AddWithValue("@Penalty", PenaltyNumeric.Value);
            try
            {
                connection.open();
                command.ExecuteNonQuery();
                connection.close();
                MessageBox.Show("Zaktualizowano rekord z ID: " + OrderHistoryForm.rowNumber + " !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
