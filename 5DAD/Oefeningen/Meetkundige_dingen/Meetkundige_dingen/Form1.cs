using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meetkundige_dingen
{
    public partial class Form1 : Form
    {
        Image imgRechthoek = Image.FromFile("rechthoek.png");
        Image imgVierkant = Image.FromFile("vierkant.png");
        Image imgDriehoek = Image.FromFile("driehoek.png");
        Image imgCirkel = Image.FromFile("cirkel.png");
        public Form1()
        {
            InitializeComponent();
            imgBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CheckRadioButtons(object sender, EventArgs e)
        {
            //alles invisible zetten
            pnlBasisHoogte.Visible = pnlStraal.Visible = pnlZIjde.Visible = false;

            if(rbtCirkel.Checked) {

                pnlStraal.Visible = true;
                pnlStraal.BringToFront();
                imgBox.Image= imgCirkel;
            }
            if(rbtGelijkzijdigeDriehoek.Checked)
            {
                pnlZIjde.Visible = true;
                pnlZIjde.BringToFront();
                imgBox.Image = imgDriehoek;
            }
            if(rbtRechthoek.Checked)
            {
                pnlBasisHoogte.Visible= true;
                pnlBasisHoogte.BringToFront();
                imgBox.Image = imgRechthoek;
            }
            if(rbtVierkant.Checked)
            {
                pnlZIjde.Visible= true;
                pnlZIjde.BringToFront();
                imgBox.Image = imgVierkant; 
            }
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            if (rbtVierkant.Checked) {
                if (String.IsNullOrEmpty(txtZijde.Text)) return;
                int zijde = Convert.ToInt32(txtZijde.Text);
                txtResultaat.Text = (zijde * 4).ToString();
            }
            if (rbtGelijkzijdigeDriehoek.Checked)
            {
                if (String.IsNullOrEmpty(txtZijde.Text)) return;
                int zijde = Convert.ToInt32(txtZijde.Text);
                txtResultaat.Text = (zijde * 3).ToString();
            }
            if (rbtRechthoek.Checked)
            {
                if (String.IsNullOrEmpty(txtBasis.Text) || String.IsNullOrEmpty(txtHoogte.Text)) return;
                int basis = Convert.ToInt32(txtBasis.Text);
                int hoogte = Convert.ToInt32(txtHoogte.Text);
                txtResultaat.Text = (2*basis + 2*hoogte).ToString();
            }
            if (rbtCirkel.Checked)
            {
                if (String.IsNullOrEmpty(txtStraal.Text)) return;
                int straal = Convert.ToInt32(txtStraal.Text);
                txtResultaat.Text = (2* straal * Math.PI).ToString();
            }
        }
    }
}
