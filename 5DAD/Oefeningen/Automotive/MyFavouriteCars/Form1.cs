using Automotive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFavouriteCars
{
    public partial class MyForm : Form
    {
        Auto myCar;
        public MyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCar = new Auto();
            try
            {
                myCar.Merk = cmbMerk.Text;
                myCar.Kleur = txtKleur.Text;
                myCar.Type = cmbType.Text;
                myCar.ConstructieDatum = dtConstruction.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToon_Click(object sender, EventArgs e)
        {
            string msg;

            msg = "Merk: " + myCar.Merk + "\n";
            msg += "Kleur: " + myCar.Kleur + "\n";
            msg += "Type: " + myCar.Type + "\n";
            msg += "Constructiiedatum: ";
            msg += Convert.ToString(myCar.ConstructieDatum.Date);

            MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
