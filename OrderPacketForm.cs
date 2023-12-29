using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class OrderPacketForm : Form
    {
        private int rowNumber;
        private string id = "";
        SqlCommand command = new SqlCommand();
        dbConnect connection = new dbConnect();
        public OrderPacketForm()
        {
            InitializeComponent();
        }

        private void OrderPacketForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.PAKIETY' table. You can move, or remove it, as needed.
            this.pAKIETYTableAdapter.Fill(this.allDataSet.PAKIETY);
            // TODO: This line of code loads data into the 'carRentalCWDataSet.PAKIETY' table. You can move, or remove it, as needed.
            this.pAKIETYTableAdapter.Fill(this.allDataSet.PAKIETY);

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowNumber = Int32.Parse(id);
            PacketTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ContentTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            PriceNumeric.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("DELETE FROM PAKIETY WHERE ID_PAKIET LIKE'" + rowNumber + "'", connection.connect());
            connection.open();
            command.ExecuteNonQuery();
            connection.close();
            MessageBox.Show("Usunięto rekord z ID: " + rowNumber + " !");
            this.pAKIETYTableAdapter.Update(this.allDataSet.PAKIETY);
            this.pAKIETYTableAdapter.Fill(this.allDataSet.PAKIETY);
            PacketTextBox.Text = "";
            ContentTextBox.Text = "";
            PriceNumeric.Value = 0;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE PAKIETY SET NAZWA = @PacketName, ZAWARTOSC = @Content, CENA = @Price WHERE ID_PAKIET LIKE'" + rowNumber + "'", connection.connect());
            command.Parameters.AddWithValue("@PacketName", PacketTextBox.Text);
            command.Parameters.AddWithValue("@Content", ContentTextBox.Text);
            command.Parameters.AddWithValue("@Price", PriceNumeric.Value);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(PacketTextBox.Text))
                {
                    MessageBox.Show("Nazwa pakietu nie może być pusta!");
                } 
                else if (string.IsNullOrEmpty(ContentTextBox.Text))
                {
                    MessageBox.Show("Zawartość nie może być pusta!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Zaktualizowano rekord z ID: " + rowNumber + " !");
                    this.pAKIETYTableAdapter.Update(this.allDataSet.PAKIETY);
                    this.pAKIETYTableAdapter.Fill(this.allDataSet.PAKIETY);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("INSERT INTO PAKIETY (NAZWA, ZAWARTOSC, CENA) VALUES (@PacketName, @Content, @Price)", connection.connect());
            command.Parameters.AddWithValue("@PacketName", PacketTextBox.Text);
            command.Parameters.AddWithValue("@Content", ContentTextBox.Text);
            command.Parameters.AddWithValue("@Price", PriceNumeric.Value);
            try
            {
                connection.open();
                if (string.IsNullOrEmpty(PacketTextBox.Text))
                {
                    MessageBox.Show("Nazwa pakietu nie może być pusta!");
                }
                else if (string.IsNullOrEmpty(ContentTextBox.Text))
                {
                    MessageBox.Show("Zawartość nie może być pusta!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.close();
                    MessageBox.Show("Dodano rekord pomyślnie!");
                    this.pAKIETYTableAdapter.Update(this.allDataSet.PAKIETY);
                    this.pAKIETYTableAdapter.Fill(this.allDataSet.PAKIETY);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterCheck.Checked == true)
            {
                AddButton.Enabled = false;
                UpdateButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            else
            {
                AddButton.Enabled = true;
                UpdateButton.Enabled = true;
                DeleteButton.Enabled = true;
                this.pAKIETYTableAdapter.Fill(this.allDataSet.PAKIETY);
                dataGridView1.DataSource = this.allDataSet.PAKIETY;
            }
        }

        private void FilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FilterCheck.Checked == true)
            {
                using (CarRentalCWEntities db = new CarRentalCWEntities())
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = db.PAKIETY
                        .Where(
                        x => x.NAZWA.StartsWith(PacketTextBox.Text)
                        )
                        .ToList();
                }
            }
        }
    }
}
