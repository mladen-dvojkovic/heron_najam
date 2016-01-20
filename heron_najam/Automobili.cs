using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heron_najam
{
    public partial class Automobili : Form
    {
        public Automobili()
        {
            InitializeComponent();
        }

        private void Automobili_Load(object sender, EventArgs e)
        {
            
            this.automobiliTableAdapter.Fill(this.autoDataSet.automobili);

        }

    }
}
