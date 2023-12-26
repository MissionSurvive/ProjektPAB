using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ReportForm : Form
    { 
        public ReportForm()
        {
            InitializeComponent();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source = X280\SQLEXPRESS; Initial Catalog = CarRentalCW; Integrated Security = True";
            if (ReportRadio1.Checked)
            {
                DateTime nextDay = StartDatePicker.Value;
                nextDay = nextDay.AddDays(1);
                EndDatePicker.Value = nextDay;
                string command = "SELECT ZAMOWIENIA.ID_ZAMOWIENIE, PAKIETY.NAZWA, WYPOZYCZALNIE.MIASTO, MODELE.NAZWA_MODEL LICZBA_DNI, " +
                    "CENA_ZAMOWIENIE, HISTORIA_ZAMOWIENIA.KOSZT_TANKOWANIE, DATA_START FROM ZAMOWIENIA " +
                    "JOIN PAKIETY ON ZAMOWIENIA.ID_PAKIET = PAKIETY.ID_PAKIET " +
                    "JOIN WYPOZYCZALNIE ON ZAMOWIENIA.ID_WYPOZYCZALNIA = WYPOZYCZALNIE.ID_WYPOZYCZALNIA " +
                    "JOIN SAMOCHODY ON ZAMOWIENIA.ID_SAMOCHOD = SAMOCHODY.ID_SAMOCHOD " +
                    "JOIN MODELE ON SAMOCHODY.ID_MODEL = MODELE.ID_MODEL " +
                    "JOIN HISTORIA_ZAMOWIENIA ON ZAMOWIENIA.ID_HISTORIA = HISTORIA_ZAMOWIENIA.ID_HISTORIA " +
                    "WHERE DATA_START BETWEEN @Start AND @End";
                var connect = new SqlConnection(connection);
                var dataAdapter = new SqlDataAdapter(command, connect);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Start", StartDatePicker.Value);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@End", EndDatePicker.Value);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                double sum = 0;
                double sum2 = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                    sum2 += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    
                }
                double sumall = sum + sum2;
                SumTextBox.Text = sumall.ToString();
                connect.Close();
            } 
            else if(ReportRadio2.Checked)
            {
                string command = "SELECT ZAMOWIENIA.ID_ZAMOWIENIE, PAKIETY.NAZWA, WYPOZYCZALNIE.MIASTO, MODELE.NAZWA_MODEL LICZBA_DNI, " +
                    "CENA_ZAMOWIENIE, HISTORIA_ZAMOWIENIA.KOSZT_TANKOWANIE, DATA_START FROM ZAMOWIENIA " +
                    "JOIN PAKIETY ON ZAMOWIENIA.ID_PAKIET = PAKIETY.ID_PAKIET " +
                    "JOIN WYPOZYCZALNIE ON ZAMOWIENIA.ID_WYPOZYCZALNIA = WYPOZYCZALNIE.ID_WYPOZYCZALNIA " +
                    "JOIN SAMOCHODY ON ZAMOWIENIA.ID_SAMOCHOD = SAMOCHODY.ID_SAMOCHOD " +
                    "JOIN MODELE ON SAMOCHODY.ID_MODEL = MODELE.ID_MODEL " +
                    "JOIN HISTORIA_ZAMOWIENIA ON ZAMOWIENIA.ID_HISTORIA = HISTORIA_ZAMOWIENIA.ID_HISTORIA " +
                    "WHERE DATA_START BETWEEN @Start AND @End";
                var connect = new SqlConnection(connection);
                var dataAdapter = new SqlDataAdapter(command, connect);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Start", StartDatePicker.Value);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@End", EndDatePicker.Value);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                double sum = 0;
                double sum2 = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                    sum2 += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);

                }
                double sumall = sum + sum2;
                SumTextBox.Text = sumall.ToString();
                connect.Close();
            }
            else if(ReportRadio3.Checked)
            {
                string command = "SELECT ZAMOWIENIA.ID_ZAMOWIENIE, PRACOWNICY.IMIE_PRACOWNIK, PRACOWNICY.NAZWISKO_PRACOWNIK, PAKIETY.NAZWA, WYPOZYCZALNIE.MIASTO, MODELE.NAZWA_MODEL LICZBA_DNI, " +
                    "CENA_ZAMOWIENIE, HISTORIA_ZAMOWIENIA.KOSZT_TANKOWANIE, DATA_START FROM ZAMOWIENIA " +
                    "JOIN PAKIETY ON ZAMOWIENIA.ID_PAKIET = PAKIETY.ID_PAKIET " +
                    "JOIN WYPOZYCZALNIE ON ZAMOWIENIA.ID_WYPOZYCZALNIA = WYPOZYCZALNIE.ID_WYPOZYCZALNIA " +
                    "JOIN SAMOCHODY ON ZAMOWIENIA.ID_SAMOCHOD = SAMOCHODY.ID_SAMOCHOD " +
                    "JOIN MODELE ON SAMOCHODY.ID_MODEL = MODELE.ID_MODEL " +
                    "JOIN HISTORIA_ZAMOWIENIA ON ZAMOWIENIA.ID_HISTORIA = HISTORIA_ZAMOWIENIA.ID_HISTORIA " +
                    "JOIN PRACOWNICY ON HISTORIA_ZAMOWIENIA.ID_PRAC = PRACOWNICY.ID_PRAC " +
                    "WHERE HISTORIA_ZAMOWIENIA.ID_PRAC = @Surname AND DATA_START BETWEEN @Start AND @End";
                var connect = new SqlConnection(connection);
                var dataAdapter = new SqlDataAdapter(command, connect);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Start", StartDatePicker.Value);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@End", EndDatePicker.Value);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Surname", EmployeeCombo.SelectedValue);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                double sum = 0;
                double sum2 = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                    sum2 += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);

                }
                double sumall = sum + sum2;
                SumTextBox.Text = sumall.ToString();
                connect.Close();
            }
            else if(ReportRadio4.Checked)
            {
                
                string command = "SELECT HISTORIA_ZAMOWIENIA.ID_HISTORIA, PRACOWNICY.IMIE_PRACOWNIK, PRACOWNICY.NAZWISKO_PRACOWNIK, " +
                    "KLIENCI.PESEL_KLIENT, WYPOZYCZALNIE.MIASTO, KOSZT_TANKOWANIE, DATA_KOLIZJA, KARA_KOLIZJA  FROM HISTORIA_ZAMOWIENIA " +
                    "JOIN PRACOWNICY ON HISTORIA_ZAMOWIENIA.ID_PRAC = PRACOWNICY.ID_PRAC  " +
                    "JOIN KLIENCI ON HISTORIA_ZAMOWIENIA.ID_KLIENT = KLIENCI.ID_KLIENT  " +
                    "JOIN ZAMOWIENIA ON HISTORIA_ZAMOWIENIA.ID_ZAMOWIENIE = ZAMOWIENIA.ID_ZAMOWIENIE  " +
                    "JOIN WYPOZYCZALNIE ON ZAMOWIENIA.ID_WYPOZYCZALNIA = WYPOZYCZALNIE.ID_WYPOZYCZALNIA  " +
                    "WHERE DATA_KOLIZJA BETWEEN @Start AND @End";
                var connect = new SqlConnection(connection);
                var dataAdapter = new SqlDataAdapter(command, connect);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Start", StartDatePicker.Value);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@End", EndDatePicker.Value);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                double sum = 0;
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                }
                SumTextBox.Text = sum.ToString();
                connect.Close();
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.PRACOWNICY' table. You can move, or remove it, as needed.
            this.pRACOWNICYTableAdapter.Fill(this.allDataSet.PRACOWNICY);
        }
    }
}
