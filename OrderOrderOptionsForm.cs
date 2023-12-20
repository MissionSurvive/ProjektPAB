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
    public partial class OrderOrderOptionsForm : Form
    {
        public static int rowNumber;
        public static int rowNumber2;
        public static int nextRow;
        public static int idInt;
        private string id = "";
        private string id2 = "";
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        public OrderOrderOptionsForm()
        {
            InitializeComponent();
        }

        private void OrderOrderOptionsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.PRACOWNICY' table. You can move, or remove it, as needed.
            this.pRACOWNICYTableAdapter.Fill(this.allDataSet.PRACOWNICY);

            // TODO: This line of code loads data into the 'allDataSet.KLIENCI' table. You can move, or remove it, as needed.
            this.kLIENCITableAdapter.Update(this.allDataSet.KLIENCI);
            this.kLIENCITableAdapter.Fill(this.allDataSet.KLIENCI);
            // TODO: This line of code loads data into the 'allDataSet.WYPOZYCZALNIE' table. You can move, or remove it, as needed.
            this.wYPOZYCZALNIETableAdapter.Fill(this.allDataSet.WYPOZYCZALNIE);
            // TODO: This line of code loads data into the 'allDataSet.PAKIETY' table. You can move, or remove it, as needed.
            this.pAKIETYTableAdapter.Fill(this.allDataSet.PAKIETY);
            // TODO: This line of code loads data into the 'allDataSet.SAMOCHODY' table. You can move, or remove it, as needed.
            this.sAMOCHODYTableAdapter.Update(this.allDataSet.SAMOCHODY);
            this.sAMOCHODYTableAdapter.Fill(this.allDataSet.SAMOCHODY);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber = Int32.Parse(id);
            CarCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            RentalCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            EmployeeCombo.SelectedValue = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE ZAMOWIENIA SET ID_PAKIET = @Packet, ID_WYPOZYCZALNIA = @Rental, ID_KLIENT = @Client, " +
                "ID_SAMOCHOD = @Car, LICZBA_DNI = @Days, CENA_ZAMOWIENIE = @Price, DATA_START = @Start, DATA_KONIEC = @End " +
                "WHERE ID_ZAMOWIENIE LIKE'" + OrderOrderForm.rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@Packet", PacketCombo.SelectedValue);
            command.Parameters.AddWithValue("@Rental", RentalCombo.SelectedValue);
            command.Parameters.AddWithValue("@Client", ClientCombo.SelectedValue);
            command.Parameters.AddWithValue("@Car", CarCombo.SelectedValue);
            command.Parameters.AddWithValue("@Days", DaysNumeric.Value);
            command.Parameters.AddWithValue("@Price", PriceNumeric.Value);
            command.Parameters.AddWithValue("@Start", StartDatePicker.Value);
            command.Parameters.AddWithValue("@End", EndDatePicker.Value);
            try
            {
                connection.open();

                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Zaktualizowano rekord z ID: " + OrderOrderForm.rowNumber + " !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("INSERT INTO ZAMOWIENIA (ID_PAKIET, ID_WYPOZYCZALNIA, ID_KLIENT, ID_SAMOCHOD, LICZBA_DNI, CENA_ZAMOWIENIE, DATA_START, DATA_KONIEC) " +
                                     "VALUES (@Packet, @Rental, @Client, @Car, @Days, @Price, @Start, @End)", connection.connect());
            command.Parameters.AddWithValue("@Packet", PacketCombo.SelectedValue);
            command.Parameters.AddWithValue("@Rental", RentalCombo.SelectedValue);
            command.Parameters.AddWithValue("@Client", ClientCombo.SelectedValue);
            command.Parameters.AddWithValue("@Employee", EmployeeCombo.SelectedValue);
            command.Parameters.AddWithValue("@Car", CarCombo.SelectedValue);
            command.Parameters.AddWithValue("@Days", DaysNumeric.Value);
            command.Parameters.AddWithValue("@Price", PriceNumeric.Value);
            command.Parameters.AddWithValue("@Start", StartDatePicker.Value);
            command.Parameters.AddWithValue("@End", EndDatePicker.Value);
            try
            {
                connection.open();
                command.ExecuteNonQuery();
                MessageBox.Show(OrderOrderForm.idInt.ToString() + " Done 1!");
                OrderOrderForm.idInt = OrderOrderForm.idInt + 1;
                command.CommandText = "INSERT INTO HISTORIA_ZAMOWIENIA (ID_PRAC, ID_KLIENT, DATA_WYDANIE, DATA_PRZYJECIE, TANKOWANIE, KOLIZJA) VALUES (@Employee, @Client, @Start, @End, 0, 0)";
                command.ExecuteNonQuery();
                MessageBox.Show("Done 2!");
                command.CommandText = "UPDATE ZAMOWIENIA SET ID_HISTORIA = " + OrderOrderForm.idInt + " WHERE ID_ZAMOWIENIE = " + OrderOrderForm.idInt + " ";
                command.ExecuteNonQuery();
                MessageBox.Show("Done 3!");
                connection.close();
                MessageBox.Show("Dodano rekord pomyślnie!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id2 = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber2 = Int32.Parse(id2);
            ClientCombo.SelectedValue = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
