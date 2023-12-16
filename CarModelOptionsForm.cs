using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarModelOptionsForm : Form
    {
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        public CarModelOptionsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CarModelOptionsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalCWDataSet4.RODZAJE_NADWOZIA' table. You can move, or remove it, as needed.
            this.rODZAJE_NADWOZIATableAdapter.Fill(this.carRentalCWDataSet4.RODZAJE_NADWOZIA);
            // TODO: This line of code loads data into the 'carRentalCWDataSet3.MARKI' table. You can move, or remove it, as needed.
            this.mARKITableAdapter.Fill(this.carRentalCWDataSet3.MARKI);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE MODELE SET ID_MARKA = @Brand + 1, ID_NADWOZIE = @Chassis + 1, NAZWA_MODEL = @ModelName, " +
                                     "ROCZNIK = @Year, GENERACJA = @Generation, SEGMENT = @Segment WHERE ID_model LIKE'" 
                                     + CarModelForm.rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@Brand", BrandCombo.SelectedIndex);
            command.Parameters.AddWithValue("@Chassis", ChassisCombo.SelectedIndex);
            command.Parameters.AddWithValue("@ModelName", ModelTextBox.Text);
            command.Parameters.AddWithValue("@Year", YearTextBox.Text);
            command.Parameters.AddWithValue("@Generation", GenerationTextBox.Text);
            command.Parameters.AddWithValue("@Segment", SegmentTextBox.Text);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(YearTextBox.Text) || string.IsNullOrEmpty(SegmentTextBox.Text))
                {
                    MessageBox.Show("Pole to nie może być puste!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Zaktualizowano rekord z ID: " + CarModelForm.rowNumber + " !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BrandCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("INSERT INTO MODELE (ID_MARKA, ID_NADWOZIE, NAZWA_MODEL, ROCZNIK, GENERACJA, SEGMENT) " +
                                     "VALUES (@Brand, @Chassis, @ModelName, @Year, @Generation, @Segment)", connection.connect());
            command.Parameters.AddWithValue("@Brand", BrandCombo.SelectedIndex);
            command.Parameters.AddWithValue("@Chassis", ChassisCombo.SelectedIndex);
            command.Parameters.AddWithValue("@ModelName", ModelTextBox.Text);
            command.Parameters.AddWithValue("@Year", YearTextBox.Text);
            command.Parameters.AddWithValue("@Generation", GenerationTextBox.Text);
            command.Parameters.AddWithValue("@Segment", SegmentTextBox.Text);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(YearTextBox.Text) || string.IsNullOrEmpty(SegmentTextBox.Text))
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
    }
}
