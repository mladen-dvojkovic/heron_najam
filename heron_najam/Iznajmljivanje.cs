using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace heron_najam
{
    public partial class Iznajmljivanje : Form
    {
        SqlConnection connection;
        string connectionString;

        public Iznajmljivanje()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["heron_najam.Properties.Settings.autoConnectionString"].ConnectionString;
        }
        
        private void Iznajmljivanje_Load(object sender, EventArgs e)
        {
            Izlistaj();
        }

        private void Izlistaj()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM osobe", connection))
            {

                DataTable pregled = new DataTable();
                adapter.Fill(pregled);

                listaIznajmljivanja.DisplayMember = "ime_prezime";
                listaIznajmljivanja.ValueMember = "Id";
                listaIznajmljivanja.DataSource = pregled;
            }
        }

        private void listaIznajmljivanja_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listaIznajmljivanja.SelectedValue.ToString());
        }
    }
}
