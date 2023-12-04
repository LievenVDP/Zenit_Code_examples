using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorbeeldListView
{
    internal class Student
    {

        public string Naam { get; set; }

        public string Voornaam { get; set; }

        public string VolledigeNaam { get { return this.Naam + " " + this.Voornaam; } }
    }
}
