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
using heron_najam.DAL;

namespace heron_najam
{
    public partial class Automobili : Form
    {
        public Automobili()
        {
            InitializeComponent();
        }

        private async void Automobili_Load(object sender, EventArgs e)
        {
            // Ovo je primjer kako dohvatit podatke iz baze... 
            var auto = new AutomobilDAL();
            var a = await auto.GetAutomobili();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cAutomobil.KreirajAuto(inputNaziv.Text);
        }
    }
}
