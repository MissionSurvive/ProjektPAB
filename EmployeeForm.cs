using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class EmployeeForm : Form
    {
        public static int rowNumber;
        public static int nextRow;
        public static int idInt;
        private string id = "";

        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        EmployeeOptionsForm employeeOptionsForm = new EmployeeOptionsForm() { TopLevel = true, TopMost = true };
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void getId()
        {
            idInt = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells[0].Value));
            Console.WriteLine(idInt.ToString());
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.KONTA_PRACOWNIKOW' table. You can move, or remove it, as needed.
            this.kONTA_PRACOWNIKOWTableAdapter.Fill(this.allDataSet.KONTA_PRACOWNIKOW);
            // TODO: This line of code loads data into the 'allDataSet.PRACOWNICY' table. You can move, or remove it, as needed.
            this.pRACOWNICYTableAdapter.Fill(this.allDataSet.PRACOWNICY);
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
            this.dataGridView2.Sort(this.dataGridView2.Columns[0], ListSortDirection.Ascending);
            nextRow = dataGridView1.Rows.Count;
            getId();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //jakiś dziwny exception
            try
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowNumber = Int32.Parse(id);
                employeeOptionsForm.NameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                employeeOptionsForm.SurnameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                employeeOptionsForm.PeselTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                employeeOptionsForm.PhoneTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                employeeOptionsForm.RankTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                employeeOptionsForm.DateEmployedPicker.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                employeeOptionsForm.SalaryNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                employeeOptionsForm.ExtraNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                employeeOptionsForm.UsernameTextBox.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                employeeOptionsForm.PasswordTextBox.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.kONTA_PRACOWNIKOWTableAdapter.Update(this.allDataSet.KONTA_PRACOWNIKOW);
                this.kONTA_PRACOWNIKOWTableAdapter.Fill(this.allDataSet.KONTA_PRACOWNIKOW);
                this.pRACOWNICYTableAdapter.Update(this.allDataSet.PRACOWNICY);
                this.pRACOWNICYTableAdapter.Fill(this.allDataSet.PRACOWNICY);
                nextRow = dataGridView1.Rows.Count;
                getId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE PRACOWNICY SET ID_KON_PRACOWNIK = NULL WHERE ID_PRAC LIKE'" + rowNumber + "'", connection.connect());
            try
            {
                connection.open();
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM KONTA_PRACOWNIKOW WHERE ID_KON_PRACOWNIK LIKE'" + rowNumber + "'";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM PRACOWNICY WHERE ID_PRAC LIKE '" + rowNumber + "'";
                command.ExecuteNonQuery();
                command.CommandText = "DBCC CHECKIDENT (KONTA_PRACOWNIKOW, RESEED, 0)";
                command.ExecuteNonQuery();
                command.CommandText = "DBCC CHECKIDENT (PRACOWNICY, RESEED, 0)";
                command.ExecuteNonQuery();
                command.CommandText = "DBCC CHECKIDENT (KONTA_PRACOWNIKOW, RESEED)";
                command.ExecuteNonQuery();
                command.CommandText = "DBCC CHECKIDENT (PRACOWNICY, RESEED)";
                command.ExecuteNonQuery();
                connection.close();
                MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
                this.kONTA_PRACOWNIKOWTableAdapter.Update(this.allDataSet.KONTA_PRACOWNIKOW);
                this.kONTA_PRACOWNIKOWTableAdapter.Fill(this.allDataSet.KONTA_PRACOWNIKOW);
                this.pRACOWNICYTableAdapter.Update(this.allDataSet.PRACOWNICY);
                this.pRACOWNICYTableAdapter.Fill(this.allDataSet.PRACOWNICY);
                getId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            employeeOptionsForm.ShowDialog();
            getId();
        }

        private void FilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FilterCheck.Checked == true)
            {
                UpdateButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            else
            {
                UpdateButton.Enabled = true;
                DeleteButton.Enabled = true;
                this.pRACOWNICYTableAdapter.Fill(this.allDataSet.PRACOWNICY);
                dataGridView1.DataSource = this.allDataSet.PRACOWNICY;
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterCheck.Checked == true)
            {
                using (CarRentalCWEntities db = new CarRentalCWEntities())
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = db.PRACOWNICY
                        .Where(
                        x => x.IMIE_PRACOWNIK.StartsWith(NameTextBox.Text)
                        && x.NAZWISKO_PRACOWNIK.StartsWith(SurnameTextBox.Text)
                        )
                        .ToList();
                }
            }
        }
    }
}
