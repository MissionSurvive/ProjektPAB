using System;
using System.Data.SqlClient;
using System.Linq;
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
        public CarModelForm()
        {
            InitializeComponent();
            updateGrid();
        }

        private void updateGrid()
        {
            using (CarRentalCWEntities db = new CarRentalCWEntities())
            {
                dataGridView1.DataSource = db.MODELE
                    .Join(db.MARKI,
                    a => a.ID_MARKA,
                    b => b.ID_MARKA,
                    (a, b) => new
                    {
                        a,
                        b
                    })
                    .Join(db.RODZAJE_NADWOZIA,
                    c => c.a.ID_NADWOZIE,
                    d => d.ID_NADWOZIE,
                    (c, d) => new
                    {
                        c,
                        d
                    })
                    .Select(result => new
                    {
                        result.c.a.ID_MODEL,
                        result.c.b.NAZWA_MARKA,
                        result.d.NAZWA_NADWOZIE,
                        result.c.a.NAZWA_MODEL,
                        result.c.a.ROCZNIK,
                        result.c.a.GENERACJA,
                        result.c.a.SEGMENT,
                        result.c.a.ID_MARKA,
                        result.c.a.ID_NADWOZIE,
                    })
                    .OrderBy(a => a.ID_MODEL)
                    .ToList();
            }
        }

        private void CarModelForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.MODELE' table. You can move, or remove it, as needed.
            //this.mODELETableAdapter.Fill(this.allDataSet.MODELE);
        }

        public void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                updateGrid();
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowNumber = Int32.Parse(id);
                carModelOptionsForm.BrandCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[7].Value;
                carModelOptionsForm.ChassisCombo.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[8].Value;
                carModelOptionsForm.ModelTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                carModelOptionsForm.YearTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                carModelOptionsForm.GenerationTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                carModelOptionsForm.SegmentTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                carModelOptionsForm.ShowDialog();
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.userRoleLogged == "Administrator" || LoginForm.userRoleLogged == "Mechanik")
            {
                command = new SqlCommand("DELETE FROM MODELE WHERE ID_MODEL LIKE'" + rowNumber + "'", connection.connect());
                try
                {
                    connection.open();
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
                    updateGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Odmowa dostępu! Brak wymaganych uprawnień!");
        }

        private void FilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FilterCheck.Checked == true)
            {
                AddButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            else
            {
                AddButton.Enabled = true;
                DeleteButton.Enabled = true;
                updateGrid();
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterCheck.Checked == true)
            {
                using (CarRentalCWEntities db = new CarRentalCWEntities())
                {
                    dataGridView1.DataSource = db.MODELE
                        .Join(db.MARKI,
                        a => a.ID_MARKA,
                        b => b.ID_MARKA,
                        (a, b) => new
                        {
                            model = a.NAZWA_MODEL,
                            a,
                            b
                        })
                        .Where(a => a.model.StartsWith(ModelTextBox.Text))
                        .Join(db.RODZAJE_NADWOZIA,
                        c => c.a.ID_NADWOZIE,
                        d => d.ID_NADWOZIE,
                        (c, d) => new
                        {
                            c,
                            d
                        })
                        .Select(result => new
                        {
                            result.c.a.ID_MODEL,
                            result.c.b.NAZWA_MARKA,
                            result.d.NAZWA_NADWOZIE,
                            result.c.a.NAZWA_MODEL,
                            result.c.a.ROCZNIK,
                            result.c.a.GENERACJA,
                            result.c.a.SEGMENT,
                        })
                        .OrderBy(a => a.ID_MODEL)
                        .ToList();
                }
            }
        }
    }
}
