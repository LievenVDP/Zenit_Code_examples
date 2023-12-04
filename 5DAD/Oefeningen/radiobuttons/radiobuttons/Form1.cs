using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobuttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtRood_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void rbtGeel_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor= Color.Yellow;
        }

        private void rbtBlauw_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void chkKeuze1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKeuze1.Checked && chkKeuze2.Checked)
            {
                this.Text = "Keuze1 en keuze2";
            }
            else if (!chkKeuze1.Checked && chkKeuze2.Checked)
            {
                this.Text = "Keuze2";
            }
            else if (chkKeuze1.Checked && !chkKeuze2.Checked)
            {
                this.Text = "Keuze1";
            }
            else
            {
                this.Text = "Kiezen";
            }

        }

    }
}
