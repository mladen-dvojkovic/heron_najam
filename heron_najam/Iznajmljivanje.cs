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

        public Iznajmljivanje()
        {
            InitializeComponent();
        }
        
        private void Iznajmljivanje_Load(object sender, EventArgs e)
        {
                       
        }

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
