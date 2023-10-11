using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_OntmantelingsDienst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int aantaldradenOmTeWinnen = 3;
            bool nogSpelen = true;

            Random rand = new Random();

            Console.WriteLine("Welkom bij het spel - de ontmantelingsdienst -");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("\r\nIn dit spel is het de bedoeling dat u de gekleurde draden van een bom doorknipt om de bom te ontmantelen.");
            Console.WriteLine("Indien u er 3 kan doorknippen is de bom onschadelijk gemaakt en bent u gewonnen. " +
                "Maar opgelet: bij het knippen van de verkeerde draad kan de bom afgaan!");

            while (nogSpelen)
            {
                int aantalDradenDoorgeknipt = 0;
                int triggerDraad = rand.Next(1, 7);
                bool rondegewonnen = false;

                Console.WriteLine("\r\nEr is een bom met gekleurde draden uitstekend: rood, geel, blauw, zwart, groen, grijs");

                while (aantalDradenDoorgeknipt < aantaldradenOmTeWinnen)
                {
                    Console.WriteLine("\r\nWelke draad knipt u door?");
                    String keuze = Console.ReadLine().ToLower();
                    int keuzeDraad = 0;
                    switch (keuze)
                    {
                        case "rood":
                            keuzeDraad = 1;
                            break;
                        case "geel":
                            keuzeDraad = 2;
                            break;
                        case "blauw":
                            keuzeDraad = 3;
                            break;
                        case "zwart":
                            keuzeDraad = 4;
                            break;
                        case "groen":
                            keuzeDraad = 5;
                            break;
                        case "grijs":
                            keuzeDraad = 6;
                            break;
                        default:
                            Console.WriteLine("Kon uw keuze niet bepalen, probeer opnieuw");
                            break;
                    }

                    if (keuzeDraad == 0)
                    {
                        continue;
                    }

                    if (keuzeDraad == triggerDraad)
                    {
                        Console.WriteLine("BOOM! De Bom is ontploft, u verloor deze ronde");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("de draad is succesvol doorgeknipt");
                        aantalDradenDoorgeknipt++;
                        if (aantalDradenDoorgeknipt >= aantaldradenOmTeWinnen)
                        {
                            rondegewonnen = true;
                        }
                    }

                }
                if (rondegewonnen)
                {
                    Console.WriteLine("\r\nProficiat U heeft deze ronde gewonnen");
                }
                else
                {
                    Console.WriteLine("\r\nJammer! U verloor deze ronde");
                }
                Console.WriteLine("Wilt u stoppen met spelen? Typ 'JA' om te stoppen");
                if (Console.ReadLine() == "JA")
                {
                    nogSpelen = false;
                }

            }
            Console.ReadLine();



        }
    }
}
