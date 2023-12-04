using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorbeeldListView
{
    internal class Auto
    {

        public string Merk { get; set; }

        public DateTime Bouwjaar { get; set; }

        public string Beschrijving { get { return Merk + ", bouwjaar: " + Bouwjaar.Year; } }
    }
}
