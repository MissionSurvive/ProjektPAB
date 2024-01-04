using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental
{
    public partial class EmployeeOptionsForm : Form
    {
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        public EmployeeOptionsForm()
        {
            InitializeComponent();
        }

        private object CheckNull(string data)
        {
            return string.IsNullOrEmpty(data) ? DBNull.Value : (object)data;
        }

        private void EmployeeOptionsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.allDataSet.ROLE);
            // TODO: This line of code loads data into the 'allDataSet.WYPOZYCZALNIE' table. You can move, or remove it, as needed.
            this.wYPOZYCZALNIETableAdapter.Fill(this.allDataSet.WYPOZYCZALNIE);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE PRACOWNICY SET ID_WYPOZYCZALNIA = @Rental, IMIE_PRACOWNIK = @Name, " +
                                     "NAZWISKO_PRACOWNIK = @Surname, PESEL_PRACOWNIK = @Pesel, TELEFON_PRACOWNIK = @Phone, " +
                                     "STANOWISKO = @Rank, DATA_ZATRUDNIENIA = @date, WYNAGRODZENIE = @Salary, PREMIA = @Extra WHERE ID_PRAC LIKE'"
                                     + EmployeeForm.rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@Rental", RentalCombo.SelectedValue);
            command.Parameters.AddWithValue("@Role", RoleCombo.SelectedValue);
            command.Parameters.AddWithValue("@Name", NameTextBox.Text);
            command.Parameters.AddWithValue("@Surname", SurnameTextBox.Text);
            command.Parameters.AddWithValue("@Pesel", CheckNull(PeselTextBox.Text));
            command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
            command.Parameters.AddWithValue("@Rank", CheckNull(RankTextBox.Text));
            command.Parameters.AddWithValue("@Date", DateEmployedPicker.Value);
            command.Parameters.AddWithValue("@Salary", SalaryNumeric.Value);
            command.Parameters.AddWithValue("@Extra", ExtraNumeric.Value);
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
                    command.CommandText = "UPDATE KONTA_PRACOWNIKOW SET ID_ROLA = @Role WHERE ID_KON_PRACOWNIK = " + EmployeeForm.rowNumber + " ";
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Zaktualizowano rekord z ID: " + EmployeeForm.rowNumber + " !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("INSERT INTO PRACOWNICY (ID_WYPOZYCZALNIA, IMIE_PRACOWNIK, NAZWISKO_PRACOWNIK, PESEL_PRACOWNIK, TELEFON_PRACOWNIK, STANOWISKO, DATA_ZATRUDNIENIA, WYNAGRODZENIE, PREMIA) " +
                                     "VALUES (@Rental, @Name, @Surname, @Pesel, @Phone, @Rank, @Date, @Salary, @Extra)", connection.connect());
            command.Parameters.AddWithValue("@Rental", RentalCombo.SelectedValue);
            command.Parameters.AddWithValue("@Role", RoleCombo.SelectedValue);
            command.Parameters.AddWithValue("@Name", NameTextBox.Text);
            command.Parameters.AddWithValue("@Surname", SurnameTextBox.Text);
            command.Parameters.AddWithValue("@Pesel", CheckNull(PeselTextBox.Text));
            command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
            command.Parameters.AddWithValue("@Rank", CheckNull(RankTextBox.Text));
            command.Parameters.AddWithValue("@Date", DateEmployedPicker.Value);
            command.Parameters.AddWithValue("@Salary", SalaryNumeric.Value);
            command.Parameters.AddWithValue("@Extra", ExtraNumeric.Value);
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
                    MessageBox.Show(EmployeeForm.idInt.ToString() + " Done 1!");
                    EmployeeForm.idInt = EmployeeForm.idInt + 1;  
                    command.CommandText = "INSERT INTO KONTA_PRACOWNIKOW (ID_ROLA, ID_PRAC, NAZWA_PRACOWNIK, HASLO_PRACOWNIK) VALUES (@Role, " + EmployeeForm.idInt + " ," + "@Username, @Password)";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done 2!");
                    command.CommandText = "UPDATE PRACOWNICY SET ID_KON_PRACOWNIK = " + EmployeeForm.idInt + " WHERE ID_PRAC = " + EmployeeForm.idInt+ " ";
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

        private void PESELTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '!'))
            {
                e.Handled = true;
            }
        }

        private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '!'))
            {
                e.Handled = true;
            }
        }

        private void ExtraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '!'))
            {
                e.Handled = true;
            }
        }

        private void UpdateAccountButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE KONTA_PRACOWNIKOW SET NAZWA_PRACOWNIK = @Username, HASLO_PRACOWNIK = @Password WHERE ID_PRAC LIKE'"
                                     + EmployeeForm.rowNumber + "'", connection.connect());
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
