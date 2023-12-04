using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoon Bren = new Persoon("Bren", Persoon.Geslacht.Mannelijk);
            Persoon Thomas = new Persoon("Thomas", Persoon.Geslacht.Mannelijk);

            Ouder mama = new Ouder("Leen", Persoon.Geslacht.Vrouwelijk, Bren, Thomas);

            Console.WriteLine(mama.ToString());

            Console.WriteLine(Environment.NewLine);

            var beursStudent = new Beursstudent(100, new String[]{ "wiskunde", "frans" }, "Fritz", Persoon.Geslacht.Mannelijk);

            Console.WriteLine(beursStudent.ToString());
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
