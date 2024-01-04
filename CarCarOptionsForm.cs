using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarCarOptionsForm : Form
    {
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        public CarCarOptionsForm()
        {
            InitializeComponent();
        }

        private object CheckNull(string data)
        {
            return string.IsNullOrEmpty(data) ? DBNull.Value : (object)data;
        }

        private void CarCarOptionsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.WYPOZYCZALNIE' table. You can move, or remove it, as needed.
            this.wYPOZYCZALNIETableAdapter.Fill(this.allDataSet.WYPOZYCZALNIE);
            // TODO: This line of code loads data into the 'allDataSet.RODZAJE_PALIWA' table. You can move, or remove it, as needed.
            this.rODZAJE_PALIWATableAdapter.Fill(this.allDataSet.RODZAJE_PALIWA);
            // TODO: This line of code loads data into the 'allDataSet.MODELE' table. You can move, or remove it, as needed.
            this.mODELETableAdapter.Fill(this.allDataSet.MODELE);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE SAMOCHODY SET ID_PALIWO = @Fuel, ID_MODEL = @Model, ID_WYPOZYCZALNIA = @Rental, " +
                "KOLOR = @Color, PRZEBIEG = @Odo, VIN = @Vin, POJEMNOSC = @Disp, MOC = @Power, SKRZYNIA = @Gearbox, MIEJSCA = @Seats, " +
                "CENA_DZIEN = @Day, CENA_TYDZIEN = @Week, CENA_MIESIAC = @Month, KAUCJA = @Deposit WHERE ID_SAMOCHOD LIKE'"
                + CarCarForm.rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@Fuel", FuelCombo.SelectedValue);
            command.Parameters.AddWithValue("@Model", ModelCombo.SelectedValue);
            command.Parameters.AddWithValue("@Rental", RentalCombo.SelectedValue);
            command.Parameters.AddWithValue("@Odo", OdometerNumeric.Value);
            command.Parameters.AddWithValue("@Disp", DisplacementNumeric.Value);
            command.Parameters.AddWithValue("@Power", PowerNumeric.Value);
            command.Parameters.AddWithValue("@Seats", SeatsNumeric.Value);
            command.Parameters.AddWithValue("@Day", DayNumeric.Value);
            command.Parameters.AddWithValue("@Week", WeekNumeric.Value);
            command.Parameters.AddWithValue("@Month", MonthNumeric.Value);
            command.Parameters.AddWithValue("@Deposit", DepositNumeric.Value);
            command.Parameters.AddWithValue("@Color", ColorTextBox.Text);
            command.Parameters.AddWithValue("@Vin", VinTextBox.Text);
            command.Parameters.AddWithValue("@Gearbox", GearboxTextBox.Text);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(ColorTextBox.Text) || string.IsNullOrEmpty(VinTextBox.Text) || string.IsNullOrEmpty(GearboxTextBox.Text))
                {
                    MessageBox.Show("Pole to nie może być puste!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Zaktualizowano rekord z ID: " + CarCarForm.rowNumber + " !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("INSERT INTO SAMOCHODY (ID_PALIWO, ID_MODEL, ID_WYPOZYCZALNIA, KOLOR, PRZEBIEG, VIN, POJEMNOSC, MOC," +
                " SKRZYNIA, MIEJSCA, CENA_DZIEN, CENA_TYDZIEN, CENA_MIESIAC, KAUCJA) VALUES (@Fuel, @Model, @Rental, @Color, @Odo, @Vin, " +
                "@Disp, @Power, @Gearbox, @Seats, @Day, @Week, @Month, @Deposit)", connection.connect());
            command.Parameters.AddWithValue("@Fuel", FuelCombo.SelectedValue);
            command.Parameters.AddWithValue("@Model", ModelCombo.SelectedValue);
            command.Parameters.AddWithValue("@Rental", RentalCombo.SelectedValue);
            command.Parameters.AddWithValue("@Odo", OdometerNumeric.Value);
            command.Parameters.AddWithValue("@Disp", DisplacementNumeric.Value);
            command.Parameters.AddWithValue("@Power", PowerNumeric.Value);
            command.Parameters.AddWithValue("@Seats", SeatsNumeric.Value);
            command.Parameters.AddWithValue("@Day", DayNumeric.Value);
            command.Parameters.AddWithValue("@Week", WeekNumeric.Value);
            command.Parameters.AddWithValue("@Month", MonthNumeric.Value);
            command.Parameters.AddWithValue("@Deposit", DepositNumeric.Value);
            command.Parameters.AddWithValue("@Color", ColorTextBox.Text);
            command.Parameters.AddWithValue("@Vin", VinTextBox.Text);
            command.Parameters.AddWithValue("@Gearbox", GearboxTextBox.Text);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(ColorTextBox.Text) || string.IsNullOrEmpty(VinTextBox.Text) || string.IsNullOrEmpty(GearboxTextBox.Text))
                {
                    MessageBox.Show("Pole to nie może być puste!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Dodano rekord pomyślnie!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
