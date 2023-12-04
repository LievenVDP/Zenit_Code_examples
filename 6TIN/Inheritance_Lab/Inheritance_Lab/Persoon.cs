using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab
{
    public class Persoon
    {
        public enum Geslacht { Mannelijk, Vrouwelijk}

        protected string naam;
        protected Geslacht geslacht;

        public Persoon(string nm, Geslacht ges)
        {
            this.naam = nm;
            this.geslacht = ges;
        }

        public override string ToString()
        {
            return naam + " " + geslacht;
        }

    }
}
