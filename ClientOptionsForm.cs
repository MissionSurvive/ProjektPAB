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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRental
{
    public partial class ClientOptionsForm : Form
    {
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        public ClientOptionsForm()
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

        private void PeselTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '!'))
            {
                e.Handled = true;
            }
        }

        private void NipTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '!'))
            {
                e.Handled = true;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE KLIENCI SET IMIE_KLIENT = @Name, " +
                                     "NAZWISKO_KLIENT = @Surname, PESEL_KLIENT = @Pesel, TELEFON_KLIENT = @Phone, " +
                                     "FAX = @Fax, NIP = @Nip WHERE ID_KLIENT LIKE'"
                                     + ClientForm.rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@Name", NameTextBox.Text);
            command.Parameters.AddWithValue("@Surname", SurnameTextBox.Text);
            command.Parameters.AddWithValue("@Pesel", CheckNull(PeselTextBox.Text));
            command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
            command.Parameters.AddWithValue("@Fax", CheckNull(FaxTextBox.Text));
            command.Parameters.AddWithValue("@Nip", CheckNull(NipTextBox.Text));
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(SurnameTextBox.Text) ||
                    string.IsNullOrEmpty(PhoneTextBox.Text))
                {
                    MessageBox.Show("Pole to nie może być puste!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Zaktualizowano rekord z ID: " + ClientForm.rowNumber + " !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("INSERT INTO KLIENCI (IMIE_KLIENT, NAZWISKO_KLIENT, PESEL_KLIENT, TELEFON_KLIENT, FAX, NIP) " +
                                     "VALUES (@Name, @Surname, @Pesel, @Phone, @Fax, @Nip)", connection.connect());
            command.Parameters.AddWithValue("@Role", RoleCombo.SelectedIndex);
            command.Parameters.AddWithValue("@Name", NameTextBox.Text);
            command.Parameters.AddWithValue("@Surname", SurnameTextBox.Text);
            command.Parameters.AddWithValue("@Pesel", CheckNull(PeselTextBox.Text));
            command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
            command.Parameters.AddWithValue("@Fax", CheckNull(FaxTextBox.Text));
            command.Parameters.AddWithValue("@Nip", CheckNull(NipTextBox.Text));
            command.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
            command.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(NameTextBox.Text) ||
                    string.IsNullOrEmpty(PhoneTextBox.Text) || string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    MessageBox.Show("Pole to nie może być puste!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show(ClientForm.idInt.ToString() + " Done 1!");
                    ClientForm.idInt = ClientForm.idInt + 1;
                    command.CommandText = "INSERT INTO KONTA_KLIENTOW (ID_ROLA, ID_KLIENT, NAZWA_KLIENT, HASLO_KLIENT) VALUES (@Role + 1, " + ClientForm.idInt + " ," + "@Username, @Password)";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done 2!");
                    command.CommandText = "UPDATE KLIENCI SET ID_KON_KLIENT = " + ClientForm.idInt + " WHERE ID_KLIENT = " + ClientForm.idInt + " ";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done 3!");
                    connection.close();
                    MessageBox.Show("Dodano rekord pomyślnie!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClientOptionsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalCWDataSet6.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.carRentalCWDataSet6.ROLE);

        }

        private void UpdateAccountButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE KONTA_KLIENTOW SET NAZWA_KLIENT = @Username, HASLO_KLIENT = @Password WHERE ID_KLIENT LIKE'"
                                    + ClientForm.rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
            command.Parameters.AddWithValue("@Password", PasswordTextBox.Text);

            try
            {
                connection.open();
                if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    MessageBox.Show("Pole to nie może być puste!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Zmodyfikowano dane rekordu użytkownika z ID: " + EmployeeForm.rowNumber + " !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
