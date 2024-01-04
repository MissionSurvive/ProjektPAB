using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ClientRentOptionsForm : Form
    {
        ZAMOWIENIA model = new ZAMOWIENIA();
        HISTORIA_ZAMOWIENIA model2 = new HISTORIA_ZAMOWIENIA();
        string packet = "";
        string id = "";
        int packetId;
        int packetPrice = -1;
        int sum = 0;
        public ClientRentOptionsForm()
        {
            InitializeComponent();
            SumTextBox.Text = sum.ToString();
            using (CarRentalCWEntities db = new CarRentalCWEntities())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = db.PAKIETY.ToList();
                EmployeeCombo.DataSource = db.PRACOWNICY
                    .Where(x => x.ID_WYPOZYCZALNIA == ClientRentForm.rentalNumber)
                    .ToList();
                EmployeeCombo.DisplayMember = "NAZWISKO_PRACOWNIK";
                EmployeeCombo.ValueMember = "ID_PRAC";
            }    
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                packet = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                packetPrice = Int32.Parse(float.Parse(packet).ToString());
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                packetId = Int32.Parse(id);
                if (DayRadio.Checked)
                {
                    sumDays();
                }
                else if (WeekRadio.Checked)
                {
                    sumWeeks();
                }
                else if (MonthRadio.Checked)
                {
                    sumMonths();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sumDays()
        {
            int length = (int)LengthNumeric.Value;
            sum = (ClientRentForm.dayPrice * length) + packetPrice + ClientRentForm.depositPrice;
            SumTextBox.Text = sum.ToString();
        }

        private void sumWeeks()
        {
            if (ClientRentForm.weekPrice == 0)
            {
                MessageBox.Show("Nie można wypożyczyć tego pojazdu na tygodnie!");
                DayRadio.Checked = true;
            }
            else
            {
                int length = (int)LengthNumeric.Value;
                sum = (ClientRentForm.weekPrice * length) + packetPrice + ClientRentForm.depositPrice;
                SumTextBox.Text = sum.ToString();
            }
        }

        private void sumMonths()
        {
            if (ClientRentForm.monthPrice == 0)
            {
                MessageBox.Show("Nie można wypożyczyć tego pojazdu na tygodnie!");
                DayRadio.Checked = true;
            }
            else
            {
                int length = (int)LengthNumeric.Value;
                sum = (ClientRentForm.monthPrice * length) + packetPrice + ClientRentForm.depositPrice;
                SumTextBox.Text = sum.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sumDays();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sumWeeks();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sumMonths();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (packetPrice == -1)
                {
                    MessageBox.Show("Nie wybrano pakietu!");
                }
                else if (!DayRadio.Checked && !WeekRadio.Checked && !MonthRadio.Checked)
                {
                    MessageBox.Show("Nie wybrano okresu!");
                }
                else if (LengthNumeric.Value == 0)
                {
                    MessageBox.Show("Nieprawidłowy okres wypożyczenia!");
                }
                else
                {
                    SqlConnection connection = new SqlConnection(@"Data Source = X280\SQLEXPRESS; Initial Catalog = CarRentalCW; Integrated Security = True");
                    var command = ("SELECT MAX(ID_ZAMOWIENIE) FROM ZAMOWIENIA");
                    SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    object idObj = dt.Rows[0][0];
                    int idInt = Convert.ToInt32(idObj);
                    connection.Close();
;
                    string sum = SumTextBox.Text;
                    decimal sumDec = Convert.ToDecimal(sum);
                    DateTime startDate = new DateTime(StartDatePicker.Value.Year, StartDatePicker.Value.Month, StartDatePicker.Value.Day, 0, 0, 0);
                    DateTime endDate = new DateTime(StartDatePicker.Value.Year, StartDatePicker.Value.Month, StartDatePicker.Value.Day, 0, 0, 0);
                    
                    int length = (int)LengthNumeric.Value;
                    if (DayRadio.Checked)
                    {
                        endDate = startDate.AddDays(length);
                    }
                    else if (WeekRadio.Checked)
                    {
                        endDate = startDate.AddDays(length * 7);
                    }
                    else if (MonthRadio.Checked)
                    {
                        endDate = startDate.AddMonths(length);
                    }
                    string startString = startDate.ToString("yyyy-MM-dd HH:mm:ss");
                    string endString = endDate.ToString("yyyy-MM-dd HH:mm:ss");
                    int diff = (endDate - startDate).Days;
                    SqlConnection connection2 = new SqlConnection(@"Data Source = X280\SQLEXPRESS; Initial Catalog = CarRentalCW; Integrated Security = True");
                    var command2 = ("SELECT * FROM ZAMOWIENIA WHERE ID_SAMOCHOD = " + ClientRentForm.rowNumber + " AND DATA_START BETWEEN '" + startString + "' AND '" + endString + "' OR ID_SAMOCHOD = " + ClientRentForm.rowNumber + " AND DATA_KONIEC BETWEEN '" + startString + "' AND '" + endString + "'");
                    SqlDataAdapter adapter2 = new SqlDataAdapter(command2, connection2);
                    DataTable dt2 = new DataTable();
                    adapter2.Fill(dt2);
                    int xd = dt2.Rows.Count;
                    if(dt2.Rows.Count >= 1) 
                    {
                        MessageBox.Show("Dany pojazd jest niedostępny w danym terminie!");
                    }
                    else
                    {
                        model.ID_PAKIET = packetId;
                        model.ID_WYPOZYCZALNIA = ClientRentForm.rentalNumber;
                        model.ID_KLIENT = LoginForm.userID;
                        model.ID_SAMOCHOD = ClientRentForm.rowNumber;
                        model.LICZBA_DNI = diff;
                        model.CENA_ZAMOWIENIE = sumDec;
                        model.DATA_START = startDate;
                        model.DATA_KONIEC = endDate;

                        using (CarRentalCWEntities db = new CarRentalCWEntities())
                        {
                            db.ZAMOWIENIA.Add(model);
                            db.SaveChanges();
                        }
                        MessageBox.Show("Done 1!");

                        int empId = Convert.ToInt32(EmployeeCombo.SelectedValue);
                        int nextId = idInt + 1;

                        model2.ID_PRAC = empId;
                        model2.ID_ZAMOWIENIE = nextId;
                        model2.ID_KLIENT = LoginForm.userID;
                        model2.DATA_WYDANIE = startDate;
                        model2.DATA_PRZYJECIE = endDate;
                        model2.TANKOWANIE = false;
                        model2.ILOSC_TANKOWANIE = 0;
                        model2.KOSZT_TANKOWANIE = 0;
                        model2.KOLIZJA = false;

                        using (CarRentalCWEntities db = new CarRentalCWEntities())
                        {
                            db.HISTORIA_ZAMOWIENIA.Add(model2);
                            db.SaveChanges();
                        }
                        MessageBox.Show("Done 2!");

                        model.ID_HISTORIA = nextId;

                        using (CarRentalCWEntities db = new CarRentalCWEntities())
                        {
                            db.Entry(model).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                        MessageBox.Show("Done 3!");
                        MessageBox.Show("Złożono zamówienie pomyślnie!");
                    }
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

        private void LengthNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (DayRadio.Checked)
            {
                sumDays();
            }
            else if (WeekRadio.Checked)
            {
                sumWeeks();
            }
            else if (MonthRadio.Checked)
            {
                sumMonths();
            }
        }


    }
}
