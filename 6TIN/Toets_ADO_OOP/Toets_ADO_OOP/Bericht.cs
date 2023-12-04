using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toets_ADO_OOP
{
    internal class Bericht
    {
        public int Id { get; set; }
        public String Inhoud { get; set; }
        public DateTime MomentVanBericht { get; set; }
        public Kanaal Kanaal { get; set; }
        public Gebruiker Gebruiker { get; set; }
    }
}
