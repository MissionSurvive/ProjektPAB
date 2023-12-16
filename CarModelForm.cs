using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarModelForm : Form
    {
        public static int rowNumber;
        private string id = "";
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        CarModelOptionsForm carModelOptionsForm = new CarModelOptionsForm() { TopLevel = true, TopMost = true };
        FormCollection collection = Application.OpenForms;
        public CarModelForm()
        {
            InitializeComponent();
        }

        private void CarModelForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalCWDataSet.MODELE' table. You can move, or remove it, as needed.
            this.mODELETableAdapter.Fill(this.carRentalCWDataSet.MODELE);

        }

        public void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber = Int32.Parse(id);
            //carModelOptionsForm.BrandCombo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //carModelOptionsForm.ChassisCombo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            carModelOptionsForm.ModelTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            carModelOptionsForm.YearTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            carModelOptionsForm.GenerationTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            carModelOptionsForm.SegmentTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            this.mODELETableAdapter.Update(this.carRentalCWDataSet.MODELE);
            this.mODELETableAdapter.Fill(this.carRentalCWDataSet.MODELE);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            carModelOptionsForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("DELETE FROM MODELE WHERE ID_MODEL LIKE'" + rowNumber + "'", connection.connect());
            connection.open();
            command.ExecuteNonQuery();
            connection.close();
            MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
            this.mODELETableAdapter.Update(this.carRentalCWDataSet.MODELE);
            this.mODELETableAdapter.Fill(this.carRentalCWDataSet.MODELE);
        }

        private void CarModelForm_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
