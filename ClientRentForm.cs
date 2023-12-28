using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ClientRentForm : Form
    {
        SAMOCHODY model = new SAMOCHODY();
        private string id = "";
        private string rental = "";
        private string day = "";
        private string week = "";
        private string month = "";
        private string deposit = "";
        public static int rowNumber = 0;
        public static int rentalNumber = 0;
        public static int dayPrice = 0;
        public static int weekPrice = 0;
        public static int monthPrice = 0;
        public static int depositPrice = 0;
        public static int idInt;
        public ClientRentForm()
        {
            InitializeComponent();
            using (CarRentalCWEntities db = new CarRentalCWEntities())
            {
                dataGridView1.DataSource = db.SAMOCHODY
                    .Join(db.WYPOZYCZALNIE,
                    a => a.ID_WYPOZYCZALNIA,
                    b => b.ID_WYPOZYCZALNIA,
                    (a, b) => new
                    {
                        a,b
                    })
                    .Join(db.RODZAJE_PALIWA,
                    c => c.a.ID_PALIWO,
                    d => d.ID_PALIWO,
                    (c, d) => new
                    {
                        c, d
                    })
                    .Join(db.MODELE,
                    e => e.c.a.ID_MODEL,
                    f =>  f.ID_MODEL,
                    (e, f) => new
                    {
                        e, f
                    })
                    .Join(db.RODZAJE_NADWOZIA,
                    g => g.f.ID_NADWOZIE,
                    h => h.ID_NADWOZIE,
                    (g, h) => new
                    {
                        g, h
                    })
                    .Join(db.MARKI,
                    i => i.g.f.ID_MARKA,
                    j => j.ID_MARKA,
                    (i, j) => new
                    {
                        i, j
                    }).Select(result => new
                    {
                        result.i.g.e.c.a.ID_SAMOCHOD, //0
                        result.j.NAZWA_MARKA,
                        result.i.g.f.NAZWA_MODEL,
                        result.i.g.e.d.NAZWA_RODZAJ,
                        result.i.h.NAZWA_NADWOZIE,
                        result.i.g.e.c.b.MIASTO,
                        result.i.g.e.c.a.ZDJECIE,
                        result.i.g.e.c.a.KOLOR,
                        result.i.g.e.c.a.MOC,
                        result.i.g.e.c.a.SKRZYNIA,
                        result.i.g.e.c.a.MIEJSCA,
                        result.i.g.e.c.a.CENA_DZIEN, //11
                        result.i.g.e.c.a.CENA_TYDZIEN, //12
                        result.i.g.e.c.a.CENA_MIESIAC, //13
                        result.i.g.e.c.a.KAUCJA, //14
                        result.i.g.e.c.a.ID_MODEL, //15
                        result.i.g.e.c.a.ID_PALIWO, //16
                        result.i.g.e.c.a.ID_WYPOZYCZALNIA, //17
                    })
                    .ToList();
                ModelCombo.DataSource = db.MODELE.ToList();
                ModelCombo.DisplayMember = "NAZWA_MODEL";
                ModelCombo.ValueMember = "ID_MODEL";
                FuelCombo.DataSource = db.RODZAJE_PALIWA.ToList();
                FuelCombo.DisplayMember = "NAZWA_RODZAJ";
                FuelCombo.ValueMember = "ID_PALIWO";
                RentalCombo.DataSource = db.WYPOZYCZALNIE.ToList();
                RentalCombo.DisplayMember = "MIASTO";
                RentalCombo.ValueMember = "ID_WYPOZYCZALNIA";
            }
        }

        private void getId()
        {
            idInt = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells[0].Value));
            Console.WriteLine(idInt.ToString());
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int modelID = Convert.ToInt32(ModelCombo.SelectedValue);
                int fuelID = Convert.ToInt32(FuelCombo.SelectedValue);
                int rentalID = Convert.ToInt32(RentalCombo.SelectedValue);
                int powerDown = 0;
                int powerUp = 0;
                int seats = 0;
                if (string.IsNullOrEmpty(PowerDownTextBox.Text))     
                    PowerDownTextBox.Text = "";   
                else
                    powerDown = Convert.ToInt32(PowerDownTextBox.Text);
                if (string.IsNullOrEmpty(PowerUpTextBox.Text))
                    PowerUpTextBox.Text = "";
                else
                    powerUp = Convert.ToInt32(PowerUpTextBox.Text);
                if (string.IsNullOrEmpty(SeatsTextBox.Text))
                    SeatsTextBox.Text = "";
                else
                    seats = Convert.ToInt32(SeatsTextBox.Text);

                using (CarRentalCWEntities db = new CarRentalCWEntities())
                {
                    dataGridView1.DataSource = db.SAMOCHODY
                    .Join(db.WYPOZYCZALNIE,
                    a => a.ID_WYPOZYCZALNIA,
                    b => b.ID_WYPOZYCZALNIA,
                    (a, b) => new
                    {
                        id = a.ID_WYPOZYCZALNIA,
                        a,
                        b
                    })
                    .Where(a => a.id == rentalID)
                    .Join(db.RODZAJE_PALIWA,
                    c => c.a.ID_PALIWO,
                    d => d.ID_PALIWO,
                    (c, d) => new
                    {
                        id = d.ID_PALIWO,
                        c,
                        d
                    })
                    .Where(d => d.id == fuelID)
                    .Join(db.MODELE,
                    ee => ee.c.a.ID_MODEL,
                    f => f.ID_MODEL,
                    (ee, f) => new
                    {
                        id = f.ID_MODEL,
                        ee,
                        f
                    })
                    .Where(f => f.id == modelID)
                    .Join(db.RODZAJE_NADWOZIA,
                    g => g.f.ID_NADWOZIE,
                    h => h.ID_NADWOZIE,
                    (g, h) => new
                    {
                        g,
                        h
                    })
                    .Join(db.MARKI,
                    i => i.g.f.ID_MARKA,
                    j => j.ID_MARKA,
                    (i, j) => new
                    {
                        i,
                        j
                    }).Select(result => new
                    {
                        result.i.g.ee.c.a.ID_SAMOCHOD, //0
                        result.j.NAZWA_MARKA,
                        result.i.g.f.NAZWA_MODEL,
                        result.i.g.ee.d.NAZWA_RODZAJ,
                        result.i.h.NAZWA_NADWOZIE,
                        result.i.g.ee.c.b.MIASTO,
                        result.i.g.ee.c.a.ZDJECIE,
                        result.i.g.ee.c.a.KOLOR,
                        result.i.g.ee.c.a.MOC,
                        result.i.g.ee.c.a.SKRZYNIA,
                        result.i.g.ee.c.a.MIEJSCA,
                        result.i.g.ee.c.a.CENA_DZIEN, //11
                        result.i.g.ee.c.a.CENA_TYDZIEN, //12
                        result.i.g.ee.c.a.CENA_MIESIAC, //13
                        result.i.g.ee.c.a.KAUCJA, //14
                        result.i.g.ee.c.a.ID_MODEL, //15
                        result.i.g.ee.c.a.ID_PALIWO, //16
                        result.i.g.ee.c.a.ID_WYPOZYCZALNIA, //17
                    })
                    .ToList();
                    /*PowerDownTextBox.Text != null && x.MOC >= powerDown &&
                         PowerUpTextBox.Text != null && x.MOC <= powerUp &&
                         ColorTextBox.Text != null && x.KOLOR.StartsWith(ColorTextBox.Text) &&
                         GearboxTextBox.Text != null && x.SKRZYNIA.StartsWith(GearboxTextBox.Text) &&
                         SeatsTextBox.Text !=null && x.MIEJSCA == seats)
                        .ToList();*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowNumber = Int32.Parse(id);
                rental = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
                rentalNumber = Int32.Parse(rental);
                day = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                dayPrice = Int32.Parse(float.Parse(day).ToString());
                week = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                weekPrice = Int32.Parse(float.Parse(week).ToString());
                month = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                monthPrice = Int32.Parse(float.Parse(month).ToString());
                deposit = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                depositPrice = Int32.Parse(float.Parse(deposit).ToString());
                getId();
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ClientRentOptionsForm clientRentOptionsForm = new ClientRentOptionsForm();
            clientRentOptionsForm.ShowDialog();
        }
    }
}
