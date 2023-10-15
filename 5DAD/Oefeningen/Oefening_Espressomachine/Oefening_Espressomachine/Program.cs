using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Espressomachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxAantalbonen = 200;
            int aantalBonen = 200;
            bool inWerking = true;

            int bonenPerMild = 20;
            int bonenPerNormaal = 30;
            int bonenPerSterk = 50;

            Console.WriteLine("Espressomachine");
            Console.WriteLine("Deze machine heeft 3 standen: mild, normaal en sterk. Geef X in om het programma te stoppen");
            Console.WriteLine("Code\t\tsterkte");
            Console.WriteLine("M\t\tMild\r\nN\t\tNormaal\r\nS\t\tSterk");

            while (inWerking)
            {
                bool vulModus = false;
                Console.WriteLine("Aantal bonen in de machine: " + aantalBonen);

                Console.Write("Geef uw keuze voor de sterkte van uw kopje koffie in:");
                string code = Console.ReadLine().ToUpper();

                switch (code)
                {
                    case "M":
                        if (aantalBonen >= bonenPerMild)
                        {
                            aantalBonen = aantalBonen - bonenPerMild;
                        }
                        else
                        {
                            vulModus = true;
                        }
                        break;
                    case "N":
                        if (aantalBonen >= bonenPerNormaal)
                        {
                            aantalBonen = aantalBonen - bonenPerNormaal;
                        }
                        else
                        {
                            vulModus = true;
                        }
                        break;
                    case "S":
                        if (aantalBonen >= bonenPerSterk)
                        {
                            aantalBonen = aantalBonen - bonenPerSterk;
                        }
                        else
                        {
                            vulModus = true;
                        }
                        break;
                    case "X":
                        Console.WriteLine("We sluiten de machine af");
                        inWerking = false;
                        break;
                    default:
                        Console.WriteLine("Kon sterkte niet bepalen");
                        continue;
                        break;
                }
                if (vulModus)
                {
                    Console.WriteLine("De bonen zijn op, U dient de machine aan te vullen");

                }
                while (vulModus)
                {
                    Console.WriteLine("wilt u bijvullen, typ 'JA' om de machine volledig bij te vullen");
                    string input = Console.ReadLine().ToUpper();
                    if (input == "JA")
                    {
                        aantalBonen = maxAantalbonen;
                        vulModus = false;
                        Console.WriteLine("De bonen werden aangevuld");
                    }
                }

            }

            Console.ReadLine();
        }
    }
}
