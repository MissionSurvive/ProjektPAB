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
        HISTORIA_ZAMOWIENIA model3 = new HISTORIA_ZAMOWIENIA();
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
            packet = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            packetPrice = Int32.Parse(float.Parse(packet).ToString());
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            packetId= Int32.Parse(id);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int length = (int)LengthNumeric.Value;
            sum = (ClientRentForm.dayPrice * length) + packetPrice + ClientRentForm.depositPrice;
            SumTextBox.Text = sum.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(ClientRentForm.weekPrice == 0)
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(ClientRentForm.monthPrice == 0)
            {
                MessageBox.Show("Nie można wypożyczyć tego pojazdu na miesiące!");
                DayRadio.Checked = true;
            }
            else
            {
                int length = (int)LengthNumeric.Value;
                sum = (ClientRentForm.monthPrice * length) + packetPrice + ClientRentForm.depositPrice;
                SumTextBox.Text = sum.ToString();
            } 
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
                    int length = (int)LengthNumeric.Value;
                    string sum = SumTextBox.Text;
                    decimal sumDec = Convert.ToDecimal(sum);
                    DateTime startDate = StartDatePicker.Value;
                    DateTime endDate = startDate.AddDays(length);
                    
                    model.ID_PAKIET = packetId;
                    model.ID_WYPOZYCZALNIA = ClientRentForm.rentalNumber;
                    model.ID_KLIENT = LoginForm.userID;
                    model.ID_SAMOCHOD = ClientRentForm.rowNumber;
                    model.LICZBA_DNI = length;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
