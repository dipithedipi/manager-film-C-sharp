using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace manager_film
{
    public partial class Form1 : Form
    {
        static string connectionString = "Server=localhost;Database=film;Uid=root;Pwd=;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        List<Generi> generiList = new List<Generi>();
        List<Attori> attoriList = new List<Attori>();
        List<Film> filmList = new List<Film>();



        public Form1()
        {
            InitializeComponent();
            UpdateListTable();
            getFilmGenders();
            UpdateAttoriCmb();
        }

        private void getFilmGenders()
        {
            try
            {
                if (connection.State != ConnectionState.Open) connection.Open();
                string query = "SELECT * FROM generi";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

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

                cmb_genere.DataSource = generiList;
                cmb_genere.DisplayMember = "Name"; // This is the property of the Generi class to display
                cmb_genere.ValueMember = "Id"; // This is the property of the Generi class to use as the value
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                connection.Close();
            }

        }

        public string GenderText(int id)
        {
            return generiList[id-1].Name;
        }

        public int GenderId(string name)
        {
            return generiList.Find(x => x.Name == name).Id;
        }

        public void UpdateListTable()
        {
            try
            {
                if (connection.State != ConnectionState.Open) connection.Open();
                string query = "SELECT * FROM film";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();

            }

            try {
                if (connection.State != ConnectionState.Open) connection.Open();
                string query = "SELECT * FROM film";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Film film = new Film(
                        reader.GetInt32("id_film"),
                        reader.GetString("nome"),
                        reader.GetString("trama"),
                        reader.GetTimeSpan("durata"),
                        reader.GetDateTime("data_uscita"),
                        reader.GetInt32("id_genere")
                    );

                    filmList.Add(film);
                }
                cmb_id_film_relazione.DataSource = filmList;
                cmb_id_film_relazione.DisplayMember = "nome"; // This is the property of the Generi class to display
                cmb_id_film_relazione.ValueMember = "id"; // This is the property of the Generi class to use as the value

            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                connection.Close();
            }

            try
            {
                if (connection.State != ConnectionState.Open) connection.Open();
                string query = "SELECT * FROM generi";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dataGridViewGeneri.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            try
            {
                if (connection.State != ConnectionState.Open) connection.Open();
                string query = "SELECT * FROM attori";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dataGridViewAttori.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            try
            {
                if (connection.State != ConnectionState.Open) connection.Open();
                string query = "SELECT * FROM recitare";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dataGridViewRelazioni.DataSource = dataTable;

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
            infoGroupBox.Enabled = false;
        }

        private void btn_salva_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int id = int.Parse(input_id.Text);
                string nome = input_nome.Text;
                string trama = input_trama.Text;
                TimeSpan durata = new TimeSpan((int)input_hDurata.Value, (int)input_mDurata.Value, 0); 
                DateTime datauscita = date_dataUscita.Value;
                int idgenere = GenderId(cmb_genere.Text);

                selectedRow.Cells["id_film"].Value = id;
                selectedRow.Cells["nome"].Value = nome;
                selectedRow.Cells["trama"].Value = trama;
                selectedRow.Cells["durata"].Value = durata.ToString(); 
                selectedRow.Cells["data_uscita"].Value = datauscita;
                selectedRow.Cells["id_genere"].Value = idgenere;

                string updateQuery = "UPDATE film SET nome = @nome, trama = @trama, durata = @durata, data_uscita = @data_uscita, id_genere = @id_genere WHERE id_film = @id_film";


                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@trama", trama);
                    cmd.Parameters.AddWithValue("@durata", durata);
                    cmd.Parameters.AddWithValue("@data_uscita", datauscita);
                    cmd.Parameters.AddWithValue("@id_genere", idgenere);
                    cmd.Parameters.AddWithValue("@id_film", id);
                    if (connection.State != ConnectionState.Open) 
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Complete", "Update");
                connection.Clone();
            }

            infoGroupBox.Enabled = false;
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
                input_hDurata.Value = filmSelected.durata.Hours;
                input_mDurata.Value = filmSelected.durata.Minutes;
                date_dataUscita.Value = filmSelected.uscita;
                cmb_genere.Text = GenderText(filmSelected.genere);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_modifica_Click(object sender, EventArgs e)
        {
            infoGroupBox.Enabled = true;
        }

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idFilmToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_film"].Value);
                
                DialogResult result = MessageBox.Show($"Sei sicuro di voler eliminare il film {idFilmToDelete}?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM recitare WHERE id_film = @id_film";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id_film", idFilmToDelete);
                        if (connection.State != ConnectionState.Open) connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    deleteQuery = "DELETE FROM film WHERE id_film = @id_film";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id_film", idFilmToDelete);
                        if(connection.State != ConnectionState.Open)  connection.Open();
                        cmd.ExecuteNonQuery();
                    }


                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    MessageBox.Show("Il film è stato eliminato con successo.", "Eliminazione Completata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            else
            {
                // Nessuna riga selezionata, mostra un messaggio all'utente
                MessageBox.Show("Seleziona un film da eliminare.", "Nessuna Selezione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_esci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_nuovoFilm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void dataGridViewGeneri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewGeneri_SelectionChanged(object sender, EventArgs e)
        {
            input_id_genere_modifica.Text = string.Empty;
            input_nome_genere_modifica.Text = string.Empty;
            input_descrizione_genere_modifica.Text = string.Empty;

            if (dataGridViewGeneri.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewGeneri.SelectedRows[0];

                int id = int.Parse(selectedRow.Cells["id_genere"].Value.ToString());
                string nome = selectedRow.Cells["nome"].Value.ToString();
                string descrizione = selectedRow.Cells["descrizione"].Value.ToString();

                input_id_genere_modifica.Text = id.ToString();
                input_nome_genere_modifica.Text = nome.ToString();
                input_descrizione_genere_modifica.Text = descrizione.ToString();
            }
        }

        private void airButton1_Click(object sender, EventArgs e)
        {
            thunderGroupBox2.Enabled = false;
        }

        private void airButton2_Click(object sender, EventArgs e)
        {
            if (dataGridViewGeneri.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewGeneri.SelectedRows[0];

                string id = input_id_genere_modifica.Text;
                string nome = input_nome_genere_modifica.Text;
                string descrizione = input_descrizione_genere_modifica.Text;

                selectedRow.Cells["id_genere"].Value = id;
                selectedRow.Cells["nome"].Value = nome;
                selectedRow.Cells["descrizione"].Value = descrizione;

                string updateQuery = "UPDATE generi SET nome = @nome, descrizione = @descrizione WHERE id_genere = @id_genere";


                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@descrizione", descrizione);
                    cmd.Parameters.AddWithValue("@id_genere", id);
                    if (connection.State != ConnectionState.Open) connection.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Complete", "Update");
                connection.Clone();
            }

            thunderGroupBox2.Enabled = false;
        }

        private void airButton6_Click(object sender, EventArgs e)
        {
            thunderGroupBox2.Enabled=true;
        }

        private void airButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void airButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void airButton5_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewGeneri.SelectedRows.Count > 0)
            {
                int idToDelete = Convert.ToInt32(dataGridViewGeneri.SelectedRows[0].Cells["id_genere"].Value);

                DialogResult result = MessageBox.Show($"Sei sicuro di voler eliminare il genere {idToDelete}?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE recitare FROM recitare INNER JOIN film ON recitare.id_film = film.id_film WHERE film.id_genere = @id_genere;";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id_genere", idToDelete);
                        if (connection.State != ConnectionState.Open) connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                     deleteQuery = "DELETE FROM film WHERE id_genere = @id_genere";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id_genere", idToDelete);
                        if (connection.State != ConnectionState.Open)  connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    deleteQuery = "DELETE FROM generi WHERE id_genere = @id_genere";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id_genere", idToDelete);
                        if (connection.State != ConnectionState.Open)  connection.Open();
                        cmd.ExecuteNonQuery();
                    }


                    dataGridViewGeneri.Rows.RemoveAt(dataGridViewGeneri.SelectedRows[0].Index);

                    MessageBox.Show("Il genere è stato eliminato con successo.", "Eliminazione Completata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            else
            {
                // Nessuna riga selezionata, mostra un messaggio all'utente
                MessageBox.Show("Seleziona un genere da eliminare.", "Nessuna Selezione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void headerLabel24_Click(object sender, EventArgs e)
        {

        }

        private void airButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void airButton15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewAttori_SelectionChanged(object sender, EventArgs e)
        {
            aloneTextBox6.Text = string.Empty;
            aloneTextBox5.Text = string.Empty;
            aloneTextBox4.Text = string.Empty;
            poisonDateTime1.Value = DateTime.Now;

            if (dataGridViewAttori.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewAttori.SelectedRows[0];

                int id = int.Parse(selectedRow.Cells["id_attore"].Value.ToString());
                string nome = selectedRow.Cells["nome"].Value.ToString();
                string cognome = selectedRow.Cells["cognome"].Value.ToString();
                string nascita = selectedRow.Cells["data_nascita"].Value.ToString();

                aloneTextBox6.Text = id.ToString();
                aloneTextBox5.Text = nome.ToString();
                aloneTextBox4.Text = cognome.ToString();
                poisonDateTime1.Value = DateTime.Parse(nascita);
            }
        }

        private string AttoreText(int id)
        {
            return attoriList[id].Nome;
        }


        private int AttoreId(string nome)
        {
            return attoriList.Find(x => x.Nome == nome).IdAttore;
        }

        private void UpdateAttoriCmb()
        {
            try
            {
                if (connection.State != ConnectionState.Open) connection.Open();
                string query = "SELECT * FROM attori";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Attori attore = new Attori
                    {
                        IdAttore = reader.GetInt32("id_attore"),
                        Nome = reader.GetString("nome"),
                        Cognome = reader.GetString("cognome"),
                        DataNascita = reader.GetDateTime("data_nascita")
                    };

                    attoriList.Add(attore);
                }

                cmb_id_attore_relazione.DataSource = attoriList;
                cmb_id_attore_relazione.DisplayMember = "Nome"; // This is the property of the Generi class to display
                cmb_id_attore_relazione.ValueMember = "IdAttore"; // This is the property of the Generi class to use as the value
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

        private string FilmText(int id)
        {
            return filmList.Find(x => x.id == id).nome;
        }

        private int FilmId(string name)
        {
            return filmList.Find(x => x.nome == name).id;
        }   

        private void dataGridViewRelazioni_SelectionChanged(object sender, EventArgs e)
        {
            cmb_id_attore_relazione.Text = string.Empty;
            cmb_id_film_relazione.Text = string.Empty;
            input_ruolo_relazione.Text = string.Empty;

            if (dataGridViewRelazioni.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewRelazioni.SelectedRows[0];

                string id_attore = selectedRow.Cells["id_attore"].Value.ToString();
                string id_film = selectedRow.Cells["id_film"].Value.ToString();
                string ruolo = selectedRow.Cells["ruolo"].Value.ToString();

                cmb_id_attore_relazione.Text = AttoreText(int.Parse(id_attore));
                //MessageBox.Show(FilmText(int.Parse(id_film)));
                cmb_id_film_relazione.Text = FilmText(int.Parse(id_film));
                input_ruolo_relazione.Text = ruolo.ToString();
            }
        }

        private void airButton12_Click(object sender, EventArgs e)
        {
            thunderGroupBox4.Enabled = true;
        }

        private void airButton7_Click(object sender, EventArgs e)
        {
            thunderGroupBox4.Enabled=false;
        }

        private void airButton18_Click(object sender, EventArgs e)
        {
            thunderGroupBox6.Enabled = true;
        }

        private void airButton13_Click(object sender, EventArgs e)
        {
            thunderGroupBox6.Enabled=false;
        }

        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void airButton14_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO recitare (id_attore, id_film, ruolo) VALUES (@id_attore, @id_film, @ruolo)",
                    connection
                ))
                {
                    cmd.Parameters.AddWithValue("@id_attore", AttoreId(cmb_id_attore_relazione.Text));
                    cmd.Parameters.AddWithValue("@id_film", FilmId(cmb_id_film_relazione.Text));
                    cmd.Parameters.AddWithValue("@ruolo", input_ruolo_relazione.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                UpdateListTable();
            }
            catch(Exception ex) { 
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridViewRelazioni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
