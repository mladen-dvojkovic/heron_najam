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
            
            this.najamTableAdapter.Fill(this.autoDataSet.najam);
            //IzlistajNajam();
        }

        /*private void IzlistajNajam()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM najam", connection))
            {

                DataTable pregledNajam = new DataTable();
                adapter.Fill(pregledNajam);

                listaNajam.DisplayMember = "IdAutomobil";
                listaNajam.ValueMember = "Id";
                listaNajam.DataSource = pregledNajam;
            }
        }*/

        private void NoviNajam(object sender, EventArgs e)
        {
            Najam frm = new Najam();
            frm.Show();
        }

        private void PregledAuto(object sender, EventArgs e)
        {
            Automobili Auti = new Automobili();
            Auti.Show();
        }




    }
}
