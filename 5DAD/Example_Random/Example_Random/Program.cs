using System;

namespace Example_Random
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int getalTussen0En101 = rand.Next(102);
            int getalTussen0En21 = rand.Next(22);
            
            Console.WriteLine(getalTussen0En21 + getalTussen0En101);
            
        }
    }
}