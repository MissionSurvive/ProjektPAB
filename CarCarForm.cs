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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            carCarOptionsForm.ShowDialog();
            getId();
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


        /*var select = "SELECT ID_SAMOCHOD, MODELE.NAZWA_MODEL, RODZAJE_PALIWA.NAZWA_RODZAJ, WYPOZYCZALNIE.MIASTO, " +
                    "MARKI.NAZWA_MARKA, RODZAJE_NADWOZIA.NAZWA_NADWOZIE, KOLOR, PRZEBIEG, VIN, POJEMNOSC, MOC, SKRZYNIA, MIEJSCA, " +
                    "CENA_DZIEN, CENA_TYDZIEN, CENA_MIESIAC, KAUCJA FROM SAMOCHODY " +
                    "JOIN WYPOZYCZALNIE ON SAMOCHODY.ID_WYPOZYCZALNIA = WYPOZYCZALNIE.ID_WYPOZYCZALNIA " +
                    "JOIN MODELE ON SAMOCHODY.ID_MODEL = MODELE.ID_MODEL " +
                    "JOIN RODZAJE_PALIWA ON SAMOCHODY.ID_PALIWO = RODZAJE_PALIWA.ID_PALIWO " +
                    "JOIN MARKI ON MODELE.ID_MARKA = MARKI.ID_MARKA " +
                    "JOIN RODZAJE_NADWOZIA ON MODELE.ID_NADWOZIE = RODZAJE_NADWOZIA.ID_NADWOZIE";
        var c = new SqlConnection(@"Data Source = X280\SQLEXPRESS; Initial Catalog = CarRentalCW; Integrated Security = True");
        var adapter = new SqlDataAdapter(select, c);
        var CommandBuilder = new SqlCommandBuilder(adapter);
        DataSet set = new DataSet();
        adapter.Fill(set);
        dataGridView2.DataSource = set.Tables[0];*/

        private void FilterButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (FilterCheck.Checked)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = dataGridView2.DataSource;
                    source.Filter = "KOLOR LIKE '%" + ColorTextBox.Text + "%' OR SKRZYNIA LIKE '%" + GearboxTextBox.Text + "%' OR MOC = " + PowerDownNumeric.Value + " OR MIEJSCA = " + SeatsNumeric.Value + "";
                    dataGridView2.DataSource = source.DataSource;
                }
                else
                {
                    MessageBox.Show("Włącz filtrację!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            
        }
    }
}
