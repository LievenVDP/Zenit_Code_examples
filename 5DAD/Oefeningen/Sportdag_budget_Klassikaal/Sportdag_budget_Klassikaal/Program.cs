using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportdag_budget_Klassikaal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double richtbedrag = 40;
            double totaalbedrag = 0;
            string activiteiten = "";


            Console.WriteLine("Sportdag Inschrijving");
            Console.WriteLine("----------------------\r\n");

            Console.WriteLine("Geef uw activiteiten op die u graag op de sportdag zou willen doen.");
            Console.WriteLine("Elke activiteit heeft een kost, er is een richtbedrag voorzien\r\n");

            Console.WriteLine("Gebruik de keuzecode om uw keuzes in te geven:");
            Console.WriteLine("VB \t Voetbal \t 12,00 euro");
            Console.WriteLine("TE \t Tennis \t 15,00 euro");
            Console.WriteLine("BS \t Boogschieten \t 21,60 euro");
            Console.WriteLine("ZW \t Zwemmen \t 10,50 euro");
            Console.WriteLine("DA \t Darts \t\t 8,90 euro");
            Console.WriteLine("FIT \t Fitness \t 16,20 euro");

            Console.WriteLine("\r\n Het richtbedrag is: " + richtbedrag + " euro");


            while (richtbedrag >= 0)
            {
                Console.WriteLine("U zit nog " + richtbedrag + " euro van uw richtbedrag af");

                Console.WriteLine("Maak uw keuze: ");
                string input = Console.ReadLine().ToUpper();
                string gekozenActiviteit = "";

                switch (input)
                {
                    case "VB":
                        richtbedrag = richtbedrag - 12;
                        gekozenActiviteit = "Voetbal";
                        break;
                    case "TE":
                        richtbedrag -= 15;
                        gekozenActiviteit = "Tennis";
                        break;
                    case "BS":
                        richtbedrag -= 21.60;
                        gekozenActiviteit = "Boogschieten";
                        break;
                    case "ZW":
                        richtbedrag -= 10.5;
                        gekozenActiviteit = "Zwemmen";
                        break;
                    case "DA":
                        richtbedrag -= 8.9;
                        gekozenActiviteit = "Darts";
                        break;
                    case "FIT":
                        richtbedrag -= 16.2;
                        gekozenActiviteit = "Fitness";
                        break;
                    default:
                        Console.WriteLine("kan keuze niet bepalen");
                        break;
                }
                Console.WriteLine("U heeft " + gekozenActiviteit + " gekozen");
                activiteiten =  activiteiten + " " + gekozenActiviteit;

            }

            Console.WriteLine("Gekozen activiteiten: " + activiteiten);
            Console.Read();
        }
    }
}
