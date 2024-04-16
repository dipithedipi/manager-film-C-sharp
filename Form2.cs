using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager_film
{
    public partial class Form2 : Form
    {
        static string connectionString = "Server=localhost;Database=film;Uid=root;Pwd=;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        Form1 Form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            UpdateGenders();
            Form1 = form1;
        }

        private void UpdateGenders()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM generi";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                List<Generi> generiList = new List<Generi>();

                while (reader.Read())
                {
                    Generi generi = new Generi
                    {
                        Id = reader.GetInt32("id_genere"),
                        Name = reader.GetString("nome"),
                        Description = reader.GetString("descrizione")
                    };

                    generiList.Add(generi);
                }

                cmb_genere_nuovo.DataSource = generiList;
                cmb_genere_nuovo.DisplayMember = "Name"; // This is the property of the Generi class to display
                cmb_genere_nuovo.ValueMember = "Id"; // This is the property of the Generi class to use as the value
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void input_id_nuovo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_annulla_nuovo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salva_nuovo_Click(object sender, EventArgs e)
        {
            string nome = input_nome_nuovo.Text;
            string trama = input_trama_nuovo.Text;
            TimeSpan durata = new TimeSpan((int)input_hDurata_nuovo.Value, (int)input_mDurata_nuovo.Value, 0);
            DateTime dataUscita = date_dataUscita_nuovo.Value;
            int idGenere = Form1.GenderId(cmb_genere_nuovo.Text); // Assumendo che l'ID del genere sia inserito dall'utente

            // Crea un nuovo oggetto Film con i dati recuperati
            Film nuovoFilm = new Film(0, nome, trama, durata, dataUscita, idGenere); // L'ID del film sarà impostato a 0, poiché sarà generato automaticamente dal database

            // Esegui un'operazione di inserimento nel database
            string insertQuery = "INSERT INTO film (nome, trama, durata, data_uscita, id_genere) VALUES (@nome, @trama, @durata, @data_uscita, @id_genere)";


            using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@nome", nuovoFilm.nome);
                cmd.Parameters.AddWithValue("@trama", nuovoFilm.trama);
                cmd.Parameters.AddWithValue("@durata", nuovoFilm.durata);
                cmd.Parameters.AddWithValue("@data_uscita", nuovoFilm.uscita);
                cmd.Parameters.AddWithValue("@id_genere", nuovoFilm.genere);
                connection.Open();
                cmd.ExecuteNonQuery();
            }


            MessageBox.Show("Il film è stato aggiunto con successo.", "Nuovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            Form1.UpdateListTable();

            input_nome_nuovo.Text="";
            input_trama_nuovo.Text="";
            input_hDurata_nuovo.Value=0; 
            input_mDurata_nuovo.Value= 0;
            date_dataUscita_nuovo.Value = DateTime.Now;
            cmb_genere_nuovo.Text = "";
            this.Close();
        }

    }
}
