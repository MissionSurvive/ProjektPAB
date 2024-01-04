using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class OrderOrderOptionsForm : Form
    {
        public static int rowNumber;
        public static int employeeRow;
        public static int nextRow;
        public static int idInt;
        public static int packetPrice = -1;
        private int sum = 0;
        private int dayPrice;
        private int weekPrice;
        private int monthPrice;
        private int depositPrice;
        private string id = "";
        private string packet = "";
        private string day = "";
        private string week = "";
        private string month = "";
        private string deposit = "";
        private string employeeId = "";
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
            PriceNumeric.Value = sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowNumber = Int32.Parse(id);
                employeeId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                employeeRow = Int32.Parse(id);
                day = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                dayPrice = Int32.Parse(float.Parse(day).ToString());
                week = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                weekPrice = Int32.Parse(float.Parse(week).ToString());
                month = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                monthPrice = Int32.Parse(float.Parse(month).ToString());
                deposit = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
                depositPrice = Int32.Parse(float.Parse(deposit).ToString());
                CarCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                RentalCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                using (CarRentalCWEntities db = new CarRentalCWEntities())
                {
                    EmployeeCombo.DataSource = db.PRACOWNICY
                        .Where(x => x.ID_WYPOZYCZALNIA == employeeRow)
                        .ToList();
                    EmployeeCombo.DisplayMember = "NAZWISKO_PRACOWNIK";
                    EmployeeCombo.ValueMember = "ID_PRAC";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowNumber = Int32.Parse(id);
                ClientCombo.SelectedValue = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
                packet = dataGridView4.Rows[e.RowIndex].Cells[3].Value.ToString();
                rowNumber = Int32.Parse(id);
                packetPrice = Int32.Parse(float.Parse(packet).ToString());
                PacketCombo.SelectedValue = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = StartDatePicker.Value;
            DateTime endDate = StartDatePicker.Value;
            int diff = (endDate - startDate).Days;
            int length = (int)DaysNumeric.Value;
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
            command = new SqlCommand("UPDATE ZAMOWIENIA SET ID_PAKIET = @Packet, ID_WYPOZYCZALNIA = @Rental, ID_KLIENT = @Client, " +
                "ID_SAMOCHOD = @Car, LICZBA_DNI = @Days, CENA_ZAMOWIENIE = @Price, DATA_START = @Start, DATA_KONIEC = @End " +
                "WHERE ID_ZAMOWIENIE LIKE'" + OrderOrderForm.rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@Packet", PacketCombo.SelectedValue);
            command.Parameters.AddWithValue("@Rental", RentalCombo.SelectedValue);
            command.Parameters.AddWithValue("@Client", ClientCombo.SelectedValue);
            command.Parameters.AddWithValue("@Car", CarCombo.SelectedValue);
            command.Parameters.AddWithValue("@Days", diff);
            command.Parameters.AddWithValue("@Price", PriceNumeric.Value);
            command.Parameters.AddWithValue("@Start", StartDatePicker.Value);
            command.Parameters.AddWithValue("@End", endDate);
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
            if (packetPrice == -1)
            {
                MessageBox.Show("Nie wybrano pakietu!");
            }
            else if (!DayRadio.Checked && !WeekRadio.Checked && !MonthRadio.Checked)
            {
                MessageBox.Show("Nie wybrano okresu!");
            }
            else if (DaysNumeric.Value == 0)
            {
                MessageBox.Show("Nieprawidłowy okres wypożyczenia!");
            }
            else
            {

            }
            DateTime startDate = new DateTime(StartDatePicker.Value.Year, StartDatePicker.Value.Month, StartDatePicker.Value.Day, 0, 0, 0);
            DateTime endDate = new DateTime(StartDatePicker.Value.Year, StartDatePicker.Value.Month, StartDatePicker.Value.Day, 0, 0, 0);
            int length = (int)DaysNumeric.Value;
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
            else
            {
                string startString = startDate.ToString("yyyy-MM-dd HH:mm:ss");
                string endString = endDate.ToString("yyyy-MM-dd HH:mm:ss");
                int diff = (endDate - startDate).Days;
                SqlConnection connection2 = new SqlConnection(@"Data Source = X280\SQLEXPRESS; Initial Catalog = CarRentalCW; Integrated Security = True");
                var command2 = ("SELECT * FROM ZAMOWIENIA WHERE ID_SAMOCHOD = @Car AND DATA_START BETWEEN '" + startString + "' AND '" + endString + "' OR ID_SAMOCHOD = @Car AND DATA_KONIEC BETWEEN '" + startString + "' AND '" + endString + "'");
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2, connection2);
                adapter2.SelectCommand.Parameters.AddWithValue("@Car", CarCombo.SelectedValue);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                int xd = dt2.Rows.Count;
                if (dt2.Rows.Count >= 1)
                {
                    MessageBox.Show("Dany pojazd jest niedostępny w danym terminie!");
                }
                else
                {
                    command = new SqlCommand("INSERT INTO ZAMOWIENIA (ID_PAKIET, ID_WYPOZYCZALNIA, ID_KLIENT, ID_SAMOCHOD, LICZBA_DNI, CENA_ZAMOWIENIE, DATA_START, DATA_KONIEC) " +
                                         "VALUES (@Packet, @Rental, @Client, @Car, @Days, @Price, @Start, @End)", connection.connect());
                    command.Parameters.AddWithValue("@Packet", PacketCombo.SelectedValue);
                    command.Parameters.AddWithValue("@Rental", RentalCombo.SelectedValue);
                    command.Parameters.AddWithValue("@Client", ClientCombo.SelectedValue);
                    command.Parameters.AddWithValue("@Employee", EmployeeCombo.SelectedValue);
                    command.Parameters.AddWithValue("@Car", CarCombo.SelectedValue);
                    command.Parameters.AddWithValue("@Days", diff);
                    command.Parameters.AddWithValue("@Price", PriceNumeric.Value);
                    command.Parameters.AddWithValue("@Start", StartDatePicker.Value);
                    command.Parameters.AddWithValue("@End", endDate);
                    try
                    {
                        connection.open();
                        command.ExecuteNonQuery();
                        MessageBox.Show(OrderOrderForm.idInt.ToString() + " Done 1!");
                        OrderOrderForm.idInt = OrderOrderForm.idInt + 1;
                        command.CommandText = "INSERT INTO HISTORIA_ZAMOWIENIA (ID_PRAC, ID_ZAMOWIENIE, ID_KLIENT, DATA_WYDANIE, DATA_PRZYJECIE, TANKOWANIE, ILOSC_TANKOWANIE, KOSZT_TANKOWANIE, KOLIZJA) VALUES (@Employee, " + OrderOrderForm.idInt + ", @Client, @Start, @End, 0, 0, 0, 0)";
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
            }
        }

        private void sumDays()
        {
            int length = (int)DaysNumeric.Value;
            sum = (dayPrice * length) + packetPrice + depositPrice;
            PriceNumeric.Value = sum;
        }

        private void sumWeeks()
        {
            if (weekPrice == 0)
            {
                MessageBox.Show("Nie można wypożyczyć tego pojazdu na tygodnie!");
                DayRadio.Checked = true;
            }
            else
            {
                int length = (int)DaysNumeric.Value;
                sum = (weekPrice * length) + packetPrice + depositPrice;
                PriceNumeric.Value = sum;
            }
        }

        private void sumMonths()
        {
            if (monthPrice == 0)
            {
                MessageBox.Show("Nie można wypożyczyć tego pojazdu na tygodnie!");
                DayRadio.Checked= true;
            }
            else
            {
                int length = (int)DaysNumeric.Value;
                sum = (monthPrice * length) + packetPrice + depositPrice;
                PriceNumeric.Value = sum;
            }
        }

        private void DayRadio_CheckedChanged(object sender, EventArgs e)
        {
            sumDays();
        }

        private void WeekRadio_CheckedChanged(object sender, EventArgs e)
        {
            sumWeeks();
        }

        private void MonthRadio_CheckedChanged(object sender, EventArgs e)
        {
            sumMonths();
        }

        private void DaysNumeric_ValueChanged(object sender, EventArgs e)
        {
            if(DayRadio.Checked)
            {
                sumDays();
            }
            else if(WeekRadio.Checked)
            {
                sumWeeks();
            }
            else if(MonthRadio.Checked)
            {
                sumMonths();
            }
        }

        private void CarCombo_SelectedValueChanged(object sender, EventArgs e)
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

        private void PacketCombo_SelectedValueChanged(object sender, EventArgs e)
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
