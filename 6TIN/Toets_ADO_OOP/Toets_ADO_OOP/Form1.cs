using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toets_ADO_OOP
{
    public partial class Form1 : Form
    {

        List<Kanaal> Kanalen = new List<Kanaal>();
        List<Gebruiker> Gebruikers = new List<Gebruiker>();
        public Form1()
        {
            InitializeComponent();




            cmbKanalen.DataSource = Kanalen;
            cmbKanalen.DisplayMember = "Naam";

        }

        private void cmbKanalen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kanaal gekozenKanaal = cmbKanalen.SelectedItem as Kanaal;

            Debug.WriteLine(gekozenKanaal.ChannelName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Connectionstring");
            con.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM Channels", con);
            SqlDataReader lezer = com.ExecuteReader();

            while (lezer.Read())
            {
                var channel = new Kanaal
                {
                    ChannelId = lezer.GetInt32(0),
                    ChannelName = lezer.GetString(1),
                    CategoryName = lezer.GetString(2)
                };
                Kanalen.Add(channel);   
            }
            con.Close();
            con.Open();
            SqlCommand com2 = new SqlCommand("SELECT * FROM Users", con);
            SqlDataReader lezer2 = com2.ExecuteReader();

            while (lezer.Read())
            {
                var user = new Gebruiker 
                {
                    UserId = lezer.GetInt32(0),
                    UserName = lezer.GetString(1),
                    IsAdmin = lezer.GetBoolean(2)
                };
                Gebruikers.Add(user);
            }

      
            con.Close();

            cmbKanalen.DataSource = Kanalen;
            cmbKanalen.DisplayMember= "ChannelName";

            cmbUsers.DataSource = Gebruikers;
            cmbUsers.DisplayMember = "UserName";
        }
    }
}
