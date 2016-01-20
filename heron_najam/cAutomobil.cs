using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace heron_najam
{
    public class cAutomobil
    {
        
        /* Dodaj automobil */
        public void KreirajAuto(string Naziv)
        {
            //spoji se na bazu
            using (SqlConnection conn = new SqlConnection("heron_najam.Properties.Settings.autoConnectionString"))
            {
                // otvori konekciju
                conn.Open();

                // kreiraj naredbu na konekciji
                using (SqlCommand cmd = new SqlCommand("INSERT INTO automobili (naziv) VALUES (@inputNaziv)", conn))
                {
                    // dodaj vrijednost parametra @Naziv
                    cmd.Parameters.AddWithValue("@inputNaziv", Naziv);

                    // izvrši query
                    cmd.ExecuteNonQuery();

                }
            }
        }

        /* Izbriši automobil */
        public void IzbrisiAuto(int Id)
        {
            //spoji se na bazu
            using (SqlConnection conn = new SqlConnection("heron_najam.Properties.Settings.autoConnectionString"))
            {
                // otvori konekciju
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM automobili WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /* Izlistaj automobile */
        public void GetAutomobili()
        {
            //spoji se na bazu
            using (SqlConnection conn = new SqlConnection("heron_najam.Properties.Settings.autoConnectionString"))
            {
                // otvori konekciju
                conn.Open();

                using (SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM automobili", conn))
                {
                    DataTable t = new DataTable();
                    cmd.Fill(t);

                    dgAutomobil.DataSource = t;
                }
            }
        }
    }
}
