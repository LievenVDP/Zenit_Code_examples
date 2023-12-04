using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoorbeeldListView
{
    public partial class Form1 : Form
    {
        List<Auto> autoLijst = new List<Auto>{
            new Auto { Bouwjaar = new DateTime(2000, 1, 1), Merk = "Opel" },
            new Auto { Bouwjaar = new DateTime(1968, 1, 1), Merk = "Volvo" },
            new Auto { Bouwjaar = new DateTime(1980, 1, 1), Merk = "BMW" },
            new Auto { Bouwjaar = new DateTime(2010, 1, 1), Merk = "Ford" }
        };
        List<Student> studentList = new List<Student> {
        new Student{ Naam= "Pieters", Voornaam = "Piet"},
        new Student{ Naam = "Smolders", Voornaam = "Smol"},
        new Student{ Naam = "Jansens", Voornaam = "Jan"}
        };

        public Form1()
        {
            InitializeComponent();
            lstLijstAuto.DataSource = autoLijst;
            lstLijstAuto.DisplayMember = "Beschrijving";
            lstLijstStudent.DataSource = studentList;
            lstLijstStudent.DisplayMember = "VolledigeNaam";

        }

        private void lstLijstStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student geselecteerd = lstLijstStudent.SelectedItem as Student;

            lblSelected.Text = "U selecteerde student: " + geselecteerd.VolledigeNaam;
        }

        private void lstLijstAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Auto geselecteerd = (Auto)lstLijstAuto.SelectedItem;

            lblSelected.Text = "U selecteerde auto: " + geselecteerd.Beschrijving;
        }
    }
}
