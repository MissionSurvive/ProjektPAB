using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class OrderOrderForm : Form
    {
        public static int rowNumber;
        public static int nextRow;
        public static int idInt;
        private string id = "";

        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        OrderOrderOptionsForm orderOrderOptionsForm = new OrderOrderOptionsForm() { TopLevel = true, TopMost = true };
        public OrderOrderForm()
        {
            InitializeComponent();
        }

        private void getId()
        {
            idInt = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells[0].Value));
            Console.WriteLine(idInt.ToString());
        }

        private void OrderOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.HISTORIA_ZAMOWIENIA' table. You can move, or remove it, as needed.
            this.hISTORIA_ZAMOWIENIATableAdapter.Fill(this.allDataSet.HISTORIA_ZAMOWIENIA);
            // TODO: This line of code loads data into the 'allDataSet.ZAMOWIENIA' table. You can move, or remove it, as needed.
            this.zAMOWIENIATableAdapter.Fill(this.allDataSet.ZAMOWIENIA);
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
            // TODO: This line of code loads data into the 'allDataSet.HISTORIA_ZAMOWIENIA' table. You can move, or remove it, as needed.
            this.hISTORIA_ZAMOWIENIATableAdapter.Fill(this.allDataSet.HISTORIA_ZAMOWIENIA);
            this.dataGridView2.Sort(this.dataGridView2.Columns[0], ListSortDirection.Ascending);
            nextRow = dataGridView1.Rows.Count;
            getId();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            orderOrderOptionsForm.ShowDialog();
            getId();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowNumber = Int32.Parse(id);
                orderOrderOptionsForm.DaysNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                orderOrderOptionsForm.PriceNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                orderOrderOptionsForm.StartDatePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                orderOrderOptionsForm.StartDatePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                orderOrderOptionsForm.PacketCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                orderOrderOptionsForm.RentalCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                orderOrderOptionsForm.ClientCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                orderOrderOptionsForm.CarCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.zAMOWIENIATableAdapter.Update(this.allDataSet.ZAMOWIENIA);
                this.zAMOWIENIATableAdapter.Fill(this.allDataSet.ZAMOWIENIA);
                this.hISTORIA_ZAMOWIENIATableAdapter.Update(this.allDataSet.HISTORIA_ZAMOWIENIA);
                this.hISTORIA_ZAMOWIENIATableAdapter.Fill(this.allDataSet.HISTORIA_ZAMOWIENIA);
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
            command = new SqlCommand("UPDATE ZAMOWIENIA SET ID_HISTORIA = NULL WHERE ID_ZAMOWIENIE LIKE'" + rowNumber + "'", connection.connect());
            try
            {
                connection.open();
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM HISTORIA_ZAMOWIENIA WHERE ID_HISTORIA LIKE'" + rowNumber + "'";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM ZAMOWIENIA WHERE ID_ZAMOWIENIE LIKE '" + rowNumber + "'";
                command.ExecuteNonQuery();
                command.CommandText = "DBCC CHECKIDENT (HISTORIA_ZAMOWIENIA, RESEED, 0)";
                command.ExecuteNonQuery();
                command.CommandText = "DBCC CHECKIDENT (ZAMOWIENIA, RESEED, 0)";
                command.ExecuteNonQuery();
                command.CommandText = "DBCC CHECKIDENT (HISTORIA_ZAMOWIENIA, RESEED)";
                command.ExecuteNonQuery();
                command.CommandText = "DBCC CHECKIDENT (ZAMOWIENIA, RESEED)";
                command.ExecuteNonQuery();
                connection.close();
                MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
                this.hISTORIA_ZAMOWIENIATableAdapter.Update(this.allDataSet.HISTORIA_ZAMOWIENIA);
                this.hISTORIA_ZAMOWIENIATableAdapter.Fill(this.allDataSet.HISTORIA_ZAMOWIENIA);
                this.zAMOWIENIATableAdapter.Update(this.allDataSet.ZAMOWIENIA);
                this.zAMOWIENIATableAdapter.Fill(this.allDataSet.ZAMOWIENIA);
                getId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
