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
            // TODO: This line of code loads data into the 'carRentalCWDataSet.PAKIETY' table. You can move, or remove it, as needed.
            this.pAKIETYTableAdapter.Fill(this.carRentalCWDataSet.PAKIETY);

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
            this.pAKIETYTableAdapter.Update(this.carRentalCWDataSet.PAKIETY);
            this.pAKIETYTableAdapter.Fill(this.carRentalCWDataSet.PAKIETY);
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
                    this.pAKIETYTableAdapter.Update(this.carRentalCWDataSet.PAKIETY);
                    this.pAKIETYTableAdapter.Fill(this.carRentalCWDataSet.PAKIETY);
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
                    this.pAKIETYTableAdapter.Update(this.carRentalCWDataSet.PAKIETY);
                    this.pAKIETYTableAdapter.Fill(this.carRentalCWDataSet.PAKIETY);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
