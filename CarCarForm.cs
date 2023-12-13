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
    public partial class CarCarForm : Form
    {
        private int rowNumber;
        private string id = "";
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        public CarCarForm()
        {
            InitializeComponent();
        }

        private void CarCarForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalCWDataSet.SAMOCHODY' table. You can move, or remove it, as needed.
            this.sAMOCHODYTableAdapter.Fill(this.carRentalCWDataSet.SAMOCHODY);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("DELETE FROM Samochody WHERE ID_SAMOCHOD LIKE'" + rowNumber + "'", connection.connect());
            connection.open();
            command.ExecuteNonQuery();
            connection.close();
            this.sAMOCHODYTableAdapter.Update(this.carRentalCWDataSet.SAMOCHODY);
            this.sAMOCHODYTableAdapter.Fill(this.carRentalCWDataSet.SAMOCHODY);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber = Int32.Parse(id);
        }
    }
}
