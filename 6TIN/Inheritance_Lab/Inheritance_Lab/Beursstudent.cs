using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab
{
    public class Beursstudent : Student
    {
        public Double BedragOntvangen { get; set; }

        public Beursstudent(double bedragOntvangen, String[] vakken, string naam, Geslacht geslacht) : base(vakken, naam, geslacht)
        {
            BedragOntvangen = bedragOntvangen;
        }

        public override string ToString()
        {
            var res =  base.ToString();

            res += Environment.NewLine +  "Reeds Ontvangen: " + BedragOntvangen;
            return res;
        }
    }
}
