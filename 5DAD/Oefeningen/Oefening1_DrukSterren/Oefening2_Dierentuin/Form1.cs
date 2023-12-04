using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2_Dierentuin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
           
        }

        private double BerekenTotaal(int aantalVolwassenen, int aantalKinderen) {
            double prijsVolwassenen = 16.0;
            double prijsKinderen = 7.5;

            return (aantalKinderen * prijsKinderen) + (aantalVolwassenen * prijsVolwassenen);
        }
    }
}
