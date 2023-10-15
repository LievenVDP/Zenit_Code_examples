using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_WetGroteGetallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool inwerking = true;
            Random rand = new Random();


            Console.WriteLine("Wet van de grote getallen");
            Console.WriteLine("-------------------------");


            while (inwerking)
            {
                int aantalKeer = 0;
                int aantalkeerMunt = 0;
                Console.WriteLine("Geef een aantal in, ons programma zal dit aantal worpen simuleren.");
                string input = Console.ReadLine().ToUpper();
                if (input == "X")
                {
                    break;
                }

                aantalKeer = Convert.ToInt32(input);
                for (int i = 0; i < aantalKeer; i++)
                {
                    //1 is munt, 2 is kop

                    int worp = rand.Next(1, 3);
                    if (worp == 1)
                    { 
                    aantalkeerMunt++;
                    }
                }

                double percentage = Convert.ToDouble(aantalkeerMunt)/ Convert.ToDouble(aantalKeer) *100;
                Console.WriteLine("Aantal keer geworpen: " + aantalKeer);
                Console.WriteLine("Aantal keer Munt geworpen: " + aantalkeerMunt);
                Console.WriteLine("percentage munt geworpen: " + percentage + "% \r\n");

            }
            Console.WriteLine("Het programma wordt afgesloten");
            Console.ReadLine();
        }
    }
}
