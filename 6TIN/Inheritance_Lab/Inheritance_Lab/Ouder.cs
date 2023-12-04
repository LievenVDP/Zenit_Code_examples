using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab
{
    public class Ouder : Persoon
    {
        protected Persoon[] kinderen;

        public Ouder(string naam, Geslacht geslacht,params Persoon[] kinderen ): base(naam, geslacht)
        {
            this.kinderen = kinderen;
        }

        public Persoon GetKind(int i) { 
            return this.kinderen[i];
        }

        public override string ToString()
        {
            string res = base.ToString();

            foreach(Persoon kind in kinderen)
            {
                res = res + "\n" + kind.ToString();
            }

            return res;
        }
    }
}
