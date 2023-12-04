using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoorbeeldMethodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string naam = "Lieven";
            ToonNaamRef(ref naam);
            MessageBox.Show(naam);
            
        }

        private int LievenZijnMethode(int getal1, int getal2, ref int product)
        {
            product = getal1 * getal2;
            return getal1 + getal2;
        }

        void ToonNaam(string naam) {
            naam = "anderenaam";
        }
        void ToonNaamRef( ref string naam)
        {
            naam = "anderenaam";
        }

        private void btnBerekenen_Click(object sender, EventArgs e)
        {
            int getal1 = Convert.ToInt32(txtGetal1.Text);
            int getal2 = Convert.ToInt32(txtGetal2.Text);

            int product = 0;

            int resultaat = LievenZijnMethode(getal1, getal2, ref product);
            

            txtResultaat.Text = resultaat.ToString();
            MessageBox.Show(product.ToString());


        }
    }
}
