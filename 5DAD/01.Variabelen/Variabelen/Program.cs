using System;

namespace Voorbeeld_Controlestructuren
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * variabelen aanmaken
             * -------------------
             * Je maakt een variabele aan door het type van de variabele aan te geven gevolgd door de naam van de variabele.
             * Vanaf het moment dat een variabele aangemaakt wordt kan ze gebruikt worden doorheen de applicatie.
             * Een variabele dient ook een waarde mee te krijgen, Dit noemen we dan instantiëren. 
             */

            /*
             * hieronder wordt een variabele aangemaakt van type 'int'.
             * int is kort voor 'integer' en kan een geheel getal bevatten (vb: 0, 1, -3 ,....)
             * in dit geval wordt de variabele aangemaakt met als naam 'geheelGetal' en wordt er onmiddelijk een waarde aan gekoppeld (5)
             * na deze lijn kan de variabele geheelgetal gebruikt worden doorheen het programma.
             */
            int geheelGetal = 5;

            /*
             * hieronder wordt een variabele aangemaakt van type 'double'.
             * double is een datatype dat kommagetallen kan bevatten zoals 0.5, 0.66668, 3.14, ... 
             * LET OP: kommagetallen worden in C# weergegeven en ingegeven met punt notatie en niet met comma-notatie
             * in dit geval wordt de variabele aangemaakt met als naam 'kommaGetal' en wordt er onmiddelijk een waarde van 7.6 aangekoppeld
             */
            double kommaGetal = 7.6;

            /*
             * hieronder wordt een variabele aangemaakt van type 'String'.
             * een string kan een stuk tekst bevatten.
             * LETOP: je kan zowel het datatype 'string' gebruiken alsook het type 'String', String met een hoofdletter is een .net klasse met meer mogelijkheden
             * in de oefeningen gebruiken we String (met hoofdletter)
             * in dit geval wordt de variabele aangemaakt met als naam stukjeTekst en wordt er onmiddelijk de waarde 'tekst' aangekoppeld.
             */
            String stukjeTekst = "tekst";

            /*
             *  een speciale vorm van variabele is een constante. 
             *  Dit is een variabele die je op dezelfde manier aanmaakt maar het keyword 'const'.
             *  Je gebruikt dit om een variabele aan te maken waarvan je niet verwacht dat de waarde zal veranderen.
             */
            const String stukjeTekstDatNooitVeranderd = "altijd hetzelfde";




            
        }
    }
}