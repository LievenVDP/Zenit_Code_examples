using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_SportdagRichtbedrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double richtBedrag = 40.0;
            double huidigBedrag = 0.0;
            String gekozenActiviteiten = "";

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

            Console.WriteLine("\r\n Het richtbedrag is: " + richtBedrag + " euro");


            while (huidigBedrag < richtBedrag)
            {
                Console.WriteLine("\r\nU zit nog " + (richtBedrag - huidigBedrag) + " euro van het richtbedrag af. Geef uw keuze op:");
                String keuze = Console.ReadLine();

                String gekozenactiviteit = "";
                switch (keuze)
                {
                    case "VB":
                        huidigBedrag += 12.0;
                        gekozenactiviteit = "Voetbal";
                        break;
                    case "TE":
                        huidigBedrag += 15.0;
                        gekozenactiviteit = "Tennis";
                        break;
                    case "BS":
                        huidigBedrag += 21.6;
                        gekozenactiviteit = "Boogschieten";
                        break;
                    case "ZW":
                        huidigBedrag += 10.5;
                        gekozenactiviteit = "Zwemmen";
                        break;
                    case "DA":
                        huidigBedrag += 8.9;
                        gekozenactiviteit = "Darts";
                        break;
                    case "FIT":
                        huidigBedrag += 16.2;
                        gekozenactiviteit = "Fitness";
                        break;
                    default:
                        Console.WriteLine("Kon keuze niet bepalen, probeer opnieuw");
                        break;
                }
                if (gekozenactiviteit == "")
                {
                    continue;
                }
                else
                {
                    if (gekozenActiviteiten != "")
                    {
                        gekozenActiviteiten += ", ";

                    }
                    gekozenActiviteiten += gekozenactiviteit;
                }
            }

            Console.WriteLine("\r\nUw gekozen activiteiten zijn: " + gekozenActiviteiten);
            Console.ReadLine();

        }
    }
}
