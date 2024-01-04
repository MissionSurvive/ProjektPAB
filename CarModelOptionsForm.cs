using System;
using System.Data.SqlClient;
using System.Linq;
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

        private object CheckNull(string data)
        {
            return string.IsNullOrEmpty(data) ? DBNull.Value : (object)data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CarModelOptionsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.RODZAJE_NADWOZIA' table. You can move, or remove it, as needed.
            this.rODZAJE_NADWOZIATableAdapter.Fill(this.allDataSet.RODZAJE_NADWOZIA);
            // TODO: This line of code loads data into the 'allDataSet.MARKI' table. You can move, or remove it, as needed.
            this.mARKITableAdapter.Fill(this.allDataSet.MARKI);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE MODELE SET ID_MARKA = @Brand, ID_NADWOZIE = @Chassis, NAZWA_MODEL = @ModelName, " +
                                     "ROCZNIK = @Year, GENERACJA = @Generation, SEGMENT = @Segment WHERE ID_model LIKE'" 
                                     + CarModelForm.rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@Brand", BrandCombo.SelectedValue);
            command.Parameters.AddWithValue("@Chassis", ChassisCombo.SelectedValue);
            command.Parameters.AddWithValue("@ModelName", CheckNull(ModelTextBox.Text));
            command.Parameters.AddWithValue("@Year", YearTextBox.Text);
            command.Parameters.AddWithValue("@Generation", CheckNull(GenerationTextBox.Text));
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("INSERT INTO MODELE (ID_MARKA, ID_NADWOZIE, NAZWA_MODEL, ROCZNIK, GENERACJA, SEGMENT) " +
                                     "VALUES (@Brand, @Chassis, @ModelName, @Year, @Generation, @Segment)", connection.connect());
            command.Parameters.AddWithValue("@Brand", BrandCombo.SelectedValue);
            command.Parameters.AddWithValue("@Chassis", ChassisCombo.SelectedValue);
            command.Parameters.AddWithValue("@ModelName", CheckNull(ModelTextBox.Text));
            command.Parameters.AddWithValue("@Year", YearTextBox.Text);
            command.Parameters.AddWithValue("@Generation", CheckNull(GenerationTextBox.Text));
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

        private void YearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '!'))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }
}
