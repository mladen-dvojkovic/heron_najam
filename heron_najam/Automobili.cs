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
            automobilVMBindingSource.DataSource = a;
        }

        private void btn_Spremi_Click(object sender, EventArgs e)
        {
            string naziv = inputNaziv.Text.Trim();
            decimal cijena_sat = Convert.ToDecimal(numCijenaPoSatu.Value);

            if (String.IsNullOrWhiteSpace(naziv))
            {
                MessageBox.Show("Naziv automobila je obavezno polje.");
                return;
            }

            var unesiAuto = new AutomobilDAL();
            //var unesiAuto = auto.KreirajAuto(AutomobilVM) { AutomobilVM naziv, cijena_sat };
            //AutomobilDAL.KreirajAuto(naziv, cijena_sat);
            //var VM = new ViewModel.AutomobilVM() { naziv, cijena_sat };
            unesiAuto.KreirajAuto(naziv, cijena_sat);
        }

        private void btn_Odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
