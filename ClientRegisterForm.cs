using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ClientRegisterForm : Form
    {
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        int idInt;
        public ClientRegisterForm()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@"Data Source = X280\SQLEXPRESS; Initial Catalog = CarRentalCW; Integrated Security = True");
            var command = ("SELECT * FROM KLIENCI");
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            idInt = Convert.ToInt32(dt.Compute("max([ID_KLIENT])", string.Empty));
            connection.Close();
        }

        private object CheckNull(string data)
        {
            return string.IsNullOrEmpty(data) ? DBNull.Value : (object)data;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("INSERT INTO KLIENCI (IMIE_KLIENT, NAZWISKO_KLIENT, PESEL_KLIENT, TELEFON_KLIENT, FAX, NIP) " +
                                     "VALUES (@Name, @Surname, @Pesel, @Phone, @Fax, @Nip)", connection.connect());
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
                if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(SurnameTextBox.Text) ||
                    string.IsNullOrEmpty(PhoneTextBox.Text) || string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    MessageBox.Show("Pole to nie może być puste!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show(idInt.ToString() + " Done 1!");
                    idInt = idInt + 1;
                    command.CommandText = "INSERT INTO KONTA_KLIENTOW (ID_ROLA, ID_KLIENT, NAZWA_KLIENT, HASLO_KLIENT) VALUES (5, " + idInt + " ," + "@Username, @Password)";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done 2!");
                    command.CommandText = "UPDATE KLIENCI SET ID_KON_KLIENT = " + idInt + " WHERE ID_KLIENT = " + idInt + " ";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done 3!");
                    connection.close();
                    MessageBox.Show("Zarejestrowano użytkownika pomyślnie!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
