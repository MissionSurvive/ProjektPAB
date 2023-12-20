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

namespace CarRental
{
    public partial class OrderHistoryForm : Form
    {
        public static int rowNumber;
        public static int nextRow;
        public static int idInt;
        private string id = "";

        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        OrderHistoryOptionsForm orderHistoryOptionsForm = new OrderHistoryOptionsForm() { TopLevel = true, TopMost = true };
        public OrderHistoryForm()
        {
            InitializeComponent();
        }

        private void getId()
        {
            idInt = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells[0].Value));
            Console.WriteLine(idInt.ToString());
        }

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.HISTORIA_ZAMOWIENIA' table. You can move, or remove it, as needed.
            this.hISTORIA_ZAMOWIENIATableAdapter.Fill(this.allDataSet.HISTORIA_ZAMOWIENIA);
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
            getId();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            orderHistoryOptionsForm.ShowDialog();
            getId();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber = Int32.Parse(id);
            orderHistoryOptionsForm.EmployeeCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            orderHistoryOptionsForm.StartDatePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            orderHistoryOptionsForm.EndDatePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            orderHistoryOptionsForm.CountNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            orderHistoryOptionsForm.PriceNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            orderHistoryOptionsForm.CollisionDatePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            orderHistoryOptionsForm.PenaltyNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            this.hISTORIA_ZAMOWIENIATableAdapter.Update(this.allDataSet.HISTORIA_ZAMOWIENIA);
            this.hISTORIA_ZAMOWIENIATableAdapter.Fill(this.allDataSet.HISTORIA_ZAMOWIENIA);
            nextRow = dataGridView1.Rows.Count;
            getId();
        }
    }
}
