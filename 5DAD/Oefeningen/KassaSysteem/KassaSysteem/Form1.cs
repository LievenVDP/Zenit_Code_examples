using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassaSysteem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            txtLijst.Text = txtAantal.Text = txtPrijs.Text = txtTotaal.Text = String.Empty;

        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            double prijs = Convert.ToDouble(txtPrijs.Text);
            int aantal = Convert.ToInt32(txtAantal.Text);

            double prijsLijn = prijs * aantal;
            if (txtLijst.Text != String.Empty)
            {
                txtLijst.Text += Environment.NewLine;
            }
            txtLijst.Text += prijsLijn;

            txtTotaal.Text = (Convert.ToDouble(txtTotaal.Text) + prijsLijn).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTotaal.Text = "0";
        }
    }
}
