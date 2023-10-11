using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_HogerLager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Onze variabelen die over heel het programma nodig zijn
            int toegelatenbeurten = 0;
            int maximumbereik = 0;
            bool nogspelen = true;

            //Onze Randomgenerator
            Random rand = new Random();

            //Intro voor het spel en oplijsting van de moeilijkheidsgraden als keuzes
            Console.WriteLine("Welkom Bij Hoger - Lager");
            Console.WriteLine("--------------------------\r\n");
            Console.WriteLine("Alvorens we beginnen, gelieve uw moeilijkheidsgraad op te geven.\r\n");
            Console.WriteLine("Makkelijk");
            Console.WriteLine("Normaal");
            Console.WriteLine("Moeilijk");
            Console.WriteLine("Extreem");

            //inlezen van de moeilijkheidsgraad
            Console.Write("Uw gekozen moeilijkheidsgraad: ");
            String moeilijkheidsgraad = Console.ReadLine().ToLower();

            //aan de hand van de gekozen moeilijkheidsgraad zetten we het aantal toegelaten beurten en het maximumbereik van het willekeurig getal
            switch (moeilijkheidsgraad)
            {
                case "makkelijk":
                    maximumbereik = 11;
                    toegelatenbeurten = 4;
                    break;
                case "normaal":
                    maximumbereik = 21;
                    toegelatenbeurten = 3;
                    break;
                case "moeilijk":
                    maximumbereik = 51;
                    toegelatenbeurten = 4;
                    break;
                case "extreem":
                    maximumbereik = 101;
                    toegelatenbeurten = 5;
                    break;
                default:
                    Console.WriteLine("kon de moeilijkheidgraad niet bepalen aan de hand van uw keuze, we stoppen het programma");
                    nogspelen = false;
                    break;
            }

            //Onze main game loop
            while (nogspelen)
            {
                //we maken ons willekeurig getal aan
                int willekeurigGetal = rand.Next(maximumbereik + 1);
                bool gewonnen = false;

                //intro voor deze ronde
                Console.WriteLine("\r\nWe zoeken een getal van 0 tot en met " + maximumbereik);
                Console.WriteLine("U mag " + toegelatenbeurten + " maal raden");

                //We starten onze for loop voor het toegelaten aantal beurten.
                for (int huidigebeurt = 1; huidigebeurt <= toegelatenbeurten; huidigebeurt++)
                {

                    //We lezen de keuze in van de speler
                    int beurtenOver = toegelatenbeurten - huidigebeurt + 1;
                    Console.WriteLine("U heeft nog " + beurtenOver + " kansen over. Geef uw keuze op: ");
                    String keuzeAlsString = Console.ReadLine();
                    int keuzeAlsInt = Convert.ToInt32(keuzeAlsString);

                    //indien de keuze klopt, is de speler gewonnen en stoppen we de for loop
                    if (keuzeAlsInt == willekeurigGetal)
                    {
                        Console.WriteLine("Proficiat, U heeft juist geraden! Het willekeurige getal was inderdaad " + keuzeAlsInt);
                        gewonnen = true;
                        break;
                    }

                    //als de keuze niet klopt tonen we of het willekeurig getal hoger of lager ligt 
                    if (willekeurigGetal > keuzeAlsInt)
                    {
                        Console.WriteLine("Hoger");
                    }
                    else
                    {
                        Console.WriteLine("Lager");
                    }

                }

                //na het toegelaten aantal beurten gaan we na of de speler het getal had geraden,
                //indien dit niet het geval was tonen we nog een boodschap 
                if (!gewonnen)
                {
                    Console.WriteLine("Jammer! U heeft het getal niet kunnen raden");
                }

                //we vragen of de speler wil stoppen met het spel.
                Console.WriteLine("Wilt u stoppen met Spelen? typ 'JA' om te stoppen met spelen");
                String antwoord = Console.ReadLine();
                if (antwoord == "JA") { nogspelen = false; }

            }

            Console.ReadLine();
        }
    }
}
