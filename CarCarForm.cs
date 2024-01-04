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
            updateGrid();
            }

        private void updateGrid()
        {
            using (CarRentalCWEntities db = new CarRentalCWEntities())
            {
                dataGridView1.DataSource = db.SAMOCHODY
                    .Join(db.WYPOZYCZALNIE,
                    a => a.ID_WYPOZYCZALNIA,
                    b => b.ID_WYPOZYCZALNIA,
                    (a, b) => new
                    {
                        a,
                        b
                    })
                    .Join(db.RODZAJE_PALIWA,
                    c => c.a.ID_PALIWO,
                    d => d.ID_PALIWO,
                    (c, d) => new
                    {
                        c,
                        d
                    })
                    .Join(db.MODELE,
                    e => e.c.a.ID_MODEL,
                    f => f.ID_MODEL,
                    (e, f) => new
                    {
                        e,
                        f
                    })
                    .Select(result => new
                    {
                        result.e.c.a.ID_SAMOCHOD,
                        result.e.d.NAZWA_RODZAJ,
                        result.f.NAZWA_MODEL,
                        result.e.c.b.MIASTO,
                        result.e.c.a.ZDJECIE,
                        result.e.c.a.KOLOR,
                        result.e.c.a.PRZEBIEG,
                        result.e.c.a.VIN,
                        result.e.c.a.POJEMNOSC,
                        result.e.c.a.MOC,
                        result.e.c.a.SKRZYNIA,
                        result.e.c.a.MIEJSCA,
                        result.e.c.a.CENA_DZIEN,
                        result.e.c.a.CENA_TYDZIEN,
                        result.e.c.a.CENA_MIESIAC,
                        result.e.c.a.KAUCJA,
                        result.e.c.a.ID_PALIWO,
                        result.e.c.a.ID_MODEL,
                        result.e.c.a.ID_WYPOZYCZALNIA,
                    })
                    .OrderBy(a => a.ID_SAMOCHOD)
                    .ToList();
            }
        }

        private void getId()
        {
            idInt = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells[0].Value));
            Console.WriteLine(idInt.ToString());
        }

        private void CarCarForm_Load(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                command = new SqlCommand("DELETE FROM SAMOCHODY WHERE ID_SAMOCHOD LIKE'" + rowNumber + "'", connection.connect());
                try
                {
                    connection.open();
                    command.ExecuteNonQuery();
                    command.CommandText = "DBCC CHECKIDENT (SAMOCHODY, RESEED, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "DBCC CHECKIDENT (SAMOCHODY, RESEED)";
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
                    updateGrid();
                    getId();
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
                carCarOptionsForm.ShowDialog();
                getId();
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!"); 
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                updateGrid();
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowNumber = Int32.Parse(id);
                carCarOptionsForm.ColorTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                carCarOptionsForm.OdometerNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                carCarOptionsForm.VinTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                carCarOptionsForm.DisplacementNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                carCarOptionsForm.PowerNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                carCarOptionsForm.GearboxTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                carCarOptionsForm.SeatsNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                carCarOptionsForm.DayNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                carCarOptionsForm.WeekNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                carCarOptionsForm.MonthNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                carCarOptionsForm.DepositNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
                nextRow = dataGridView1.Rows.Count;
                getId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
