using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening1_DrukSterren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoe_Click(object sender, EventArgs e)
        {
            string result = String.Empty;
            int aantal = Convert.ToInt32(txtAantalSterren.Text);
            DrukSterren(aantal, ref result);
            txtResultaat.Text = result;
        }

        private void DrukSterren(int aantal, ref string resultaat) {
            for (int i = 0; i < aantal; i++)
            {
                resultaat += "*";
            }
        }
    }
}
