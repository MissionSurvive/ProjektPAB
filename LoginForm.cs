using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class LoginForm : Form
    {
        public static int userRoleLogged;
        public static int userID;
        public static string username;
        public static string surname;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = X280\SQLEXPRESS; Initial Catalog = CarRentalCW; Integrated Security = True");
            if(EmployeeRadio.Checked)
            {
                var command = ("SELECT KONTA_PRACOWNIKOW.ID_PRAC, NAZWA_PRACOWNIK, HASLO_PRACOWNIK, PRACOWNICY.IMIE_PRACOWNIK, PRACOWNICY.NAZWISKO_PRACOWNIK FROM KONTA_PRACOWNIKOW " +
                    "JOIN PRACOWNICY ON KONTA_PRACOWNIKOW.ID_PRAC = PRACOWNICY.ID_PRAC " +
                    "WHERE NAZWA_PRACOWNIK = @Username AND HASLO_PRACOWNIK = @Password");
                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                adapter.SelectCommand.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count == 1 )
                {
                    object idObj = dt.Rows[0][0];
                    object nameObj = dt.Rows[0][3];
                    object surnameObj = dt.Rows[0][4];
                    userID = Convert.ToInt32(idObj);
                    username = nameObj.ToString();
                    surname = surnameObj.ToString();
                    connection.Close();
                    Form1 mainForm = new Form1();
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowa nazwa użytkownika lub hasło!");
                }
            }   
            else if(ClientRadio.Checked)
            {
                var command = ("SELECT KONTA_KLIENTOW.ID_KLIENT, NAZWA_KLIENT, HASLO_KLIENT, KLIENCI.IMIE_KLIENT, KLIENCI.NAZWISKO_KLIENT FROM KONTA_KLIENTOW " +
                    "JOIN KLIENCI ON KONTA_KLIENTOW.ID_KLIENT = KLIENCI.ID_KLIENT " +
                    "WHERE NAZWA_KLIENT = @Username AND HASLO_KLIENT = @Password");
                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                adapter.SelectCommand.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    object idObj = dt.Rows[0][0];
                    object nameObj = dt.Rows[0][3];
                    object surnameObj = dt.Rows[0][4];
                    userID = Convert.ToInt32(idObj);
                    username = nameObj.ToString();
                    surname = surnameObj.ToString();
                    connection.Close();
                    ClientDashboardForm mainClientForm = new ClientDashboardForm();
                    this.Hide();
                    mainClientForm.Show();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowa nazwa użytkownika lub hasło!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(EmployeeRadio.Checked)
            {
                MessageBox.Show("Opcja tylko dla klientów!");
            }
            else if(ClientRadio.Checked)
            {
                ClientRegisterForm registerForm = new ClientRegisterForm();
                registerForm.ShowDialog();
            }
        }
    }
}
