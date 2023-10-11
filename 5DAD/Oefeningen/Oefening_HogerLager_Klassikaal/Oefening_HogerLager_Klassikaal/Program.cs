using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_HogerLager_Klassikaal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bereik = 0;
            int aantalKansen = 0;
            bool nogSpelen = true;

            Random rand = new Random();

            Console.WriteLine("blablabla. dit is een spel, kies de moeilijkheidsgraad.");
            Console.WriteLine("makkelijk");
            Console.WriteLine("normaal");
            Console.WriteLine("moeilijk");
            Console.WriteLine("extreem");
            Console.Write("Maak uw keuze: ");
            String keuze = Console.ReadLine().ToLower();

            switch (keuze)
            {
                case "makkelijk":
                    bereik = 11;
                    aantalKansen = 4;
                    break;
                case "normaal":
                    bereik = 21;
                    aantalKansen = 3;
                    break;
                case "moeilijk":
                    bereik = 51;
                    aantalKansen = 4;
                    break;
                case "extreem":
                    bereik = 101;
                    aantalKansen = 5;
                    break;
                default:
                    Console.WriteLine("Kon moeilijkheidsgraad niet bepalen");
                    break;
            }
            Console.WriteLine(" u heeft de moeilijkheidsgraad " + keuze + " gekozen");
            Console.WriteLine("het bereik: " + bereik + ", aantal kansen = " + aantalKansen);

            while (nogSpelen)
            {
                int willekeurigGetal = rand.Next(bereik + 1);
                bool gewonnen = false;
                Console.BackgroundColor = ConsoleColor.Green;
               
                Console.WriteLine("Nieuw spel gestart");
                Console.BackgroundColor = ConsoleColor.Black;

                for (
                    int huidigebeurt = 1;
                    huidigebeurt <= aantalKansen;
                    huidigebeurt++
                    )
                {
                    Console.WriteLine("\r\nGelieve uw gok in te geven. Aantal kansen over: " + (aantalKansen - huidigebeurt + 1));
                    String gokAlsString = Console.ReadLine();
                    int gok = Convert.ToInt32(gokAlsString);

                    if (gok == willekeurigGetal)
                    {
                        gewonnen = true;
                        break;
                    }
                    else
                    {
                        if (gok > willekeurigGetal)
                        {
                            Console.WriteLine("Lager!");
                        }
                        else
                        {
                            Console.WriteLine("Hoger!");
                        }
                    }
                }

                if (gewonnen)
                {
                    Console.WriteLine("Proficiat, U heeft het geraden");
                }
                else
                {
                    Console.WriteLine("Jammer!, Niet gewonnen");
                }

                Console.WriteLine("Wilt u stoppen, typ dan 'JA'");
                if (Console.ReadLine() == "JA")
                {
                    nogSpelen = false;
                }

            }

            Console.ReadLine();
        }
    }
}
