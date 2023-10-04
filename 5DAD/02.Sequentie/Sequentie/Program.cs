using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequentie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * De eerste basis controlestructuur is de sequentie
             * een sequentie is  een opeenvolging van statements. 
             * Hieronder tonen we een simpele sequentie waarbij:
             * -we een veriabele aanmaken genaamd 'input' en als waarde 0 geven;
             * -we een variabele aanmaken genaamd 'uitkomst' en geen waarde geven (dus niet instantiëren)
             * -we een 2e variabele aanmaken als constante genaamd 'constantGetal' en als waarde 5 meegeven;
             * -aan de hand van Console.ReadLine() een waarde uitlezen van de console
             * -deze waarde converteren naar een integer en die in de variabele 'input' opslaan
             * -een bewerking doen door 'input' en 'constantGetal' bij elkaar op te tellen en de uitkomst in 'uitkomst' op te slaan.
             */

            int input = 0;
            int uitkomst;
            const int constantGetal = 5;

            Console.Write("Geef een getal op");
            String waardeVanConsole = Console.ReadLine();
            input = Convert.ToInt32(waardeVanConsole);
            uitkomst = input + constantGetal;

            Console.WriteLine( constantGetal+ " + " + input + " = " + uitkomst);
            Console.ReadLine();



        }
    }
}
