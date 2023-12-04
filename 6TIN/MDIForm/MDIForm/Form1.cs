using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm2 = new Form2();
            frm2.TopLevel = false;
            frm2.Dock= DockStyle.Fill;
            panel1.Controls.Add(frm2);
            frm2.Show();
        }
    }
}
