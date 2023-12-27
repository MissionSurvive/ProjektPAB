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
        public static int rowNumber = 0;
        public static int rentalNumber = 0;
        public static int dayPrice = 0;
        public static int weekPrice = 0;
        public static int monthPrice = 0;
        public static int idInt;
        public ClientRentForm()
        {
            InitializeComponent();
            using (CarRentalCWEntities db = new CarRentalCWEntities())
            {
                dataGridView1.DataSource = db.SAMOCHODY.ToList();
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
                        .Where(x => 
                         x.ID_MODEL == modelID &&
                         x.ID_PALIWO == fuelID &&
                         x.ID_WYPOZYCZALNIA == rentalID)
                         //PowerDownTextBox.Text != null && x.MOC >= powerDown &&
                         //PowerUpTextBox.Text != null && x.MOC <= powerUp &&
                         //ColorTextBox.Text != null && x.KOLOR.StartsWith(ColorTextBox.Text) &&
                         //GearboxTextBox.Text != null && x.SKRZYNIA.StartsWith(GearboxTextBox.Text) &&
                         //SeatsTextBox.Text !=null && x.MIEJSCA == seats)
                        .ToList();
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
                rental = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                rentalNumber = Int32.Parse(rental);
                day = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                dayPrice = Int32.Parse(float.Parse(day).ToString());
                week = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                weekPrice = Int32.Parse(float.Parse(week).ToString());
                month = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                monthPrice = Int32.Parse(float.Parse(month).ToString());
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
