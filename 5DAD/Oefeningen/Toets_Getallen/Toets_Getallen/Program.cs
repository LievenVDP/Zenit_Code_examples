using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toets_Getallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoogste = 0;
            int laagste = 10;
            int totaal  = 0;
            double gemiddelde = 0;


            Console.WriteLine("Getallen Oefeningen");
            Console.WriteLine("-------------------\r\n");
            Console.WriteLine("Geef 5 verschillende getallen in, we tonen nadien het hooste getal, laagste getal en het gemiddelde.\r\n");

            for (int teller = 0; teller < 5; teller++)
            {
                Console.WriteLine("Geef een getal in:");
                int getal = Convert.ToInt32(Console.ReadLine());
                totaal += getal;
                if(getal>hoogste)
                {
                    hoogste = getal;
                }
                if (getal <laagste)
                {
                    laagste = getal;
                }
            }
            Console.WriteLine("\r\n");
            Console.WriteLine("Hoogste getal: " + hoogste);
            Console.WriteLine("Laagste getal: " + laagste);
            gemiddelde = totaal / 5;
            Console.WriteLine("Gemiddelde: " + gemiddelde);
            Console.ReadLine();


        }
    }
}
