using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab
{
    public class Student : Persoon
    {
        public String[] Vakken { get; set; }

        public Student(String[] vakken, string naam, Geslacht geslacht) : base(naam, geslacht)
        {
            Vakken = vakken;
        }

        public override string ToString()
        {
            var res =  base.ToString();

            foreach (string item in Vakken)
            {
                res += Environment.NewLine + item;
            }
            return res;
        }
    }
}
