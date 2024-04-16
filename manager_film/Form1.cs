using MySql.Data.MySqlClient;
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

namespace manager_film
{
    public partial class Form1 : Form
    {
        static string connectionString = "Server=localhost;Database=film;Uid=root;Pwd=;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        public Form1()
        {
            InitializeComponent();
            UpdateListTable();

        }

        private void UpdateListTable()
        {
            try {
                connection.Open();
                string query = "SELECT * FROM film";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void thunderGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel4_Click(object sender, EventArgs e)
        {

        }

        private void foxLabel1_Click(object sender, EventArgs e)
        {

        }

        private void foxLabel2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_genere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void input_mDurata_Click(object sender, EventArgs e)
        {

        }

        private void input_hDurata_Click(object sender, EventArgs e)
        {

        }

        private void date_dataUscita_ValueChanged(object sender, EventArgs e)
        {

        }

        private void input_trama_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_annulla_Click(object sender, EventArgs e)
        {

        }

        private void btn_salva_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel6_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel5_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel3_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel2_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            input_id.Text = string.Empty;
            input_nome.Text = string.Empty;
            input_trama.Text = string.Empty;

            if (dataGridView1.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int id = int.Parse(selectedRow.Cells["id_film"].Value.ToString());
                string nome = selectedRow.Cells["nome"].Value.ToString();
                string trama = selectedRow.Cells["trama"].Value.ToString();
                TimeSpan durata = TimeSpan.Parse(selectedRow.Cells["durata"].Value.ToString());
                DateTime datauscita = DateTime.Parse(selectedRow.Cells["data_uscita"].Value.ToString());
                int idgenere = int.Parse(selectedRow.Cells["id_genere"].Value.ToString());

                Film filmSelected = new Film(id, nome, trama, durata, datauscita, idgenere);

                input_id.Text = filmSelected.id.ToString();
                input_nome.Text = filmSelected.nome.ToString();
                input_trama.Text = filmSelected.trama.ToString();
                input_hDurata.Value = filmSelected.durata.Hours.ToString();
                input_mDurata.Value = filmSelected.durata.Minutes.ToString();
                date_dataUscita_nuovo.Value = filmSelected.uscita.ToString();
            }
            else {
                MessageBox.Show("Multiple selected", "Error");
                return;
            }
        }
    }
}
