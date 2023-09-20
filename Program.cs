using System;

namespace uppgift2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" skriv ett mening med tre ord och meningen ska avslutas med en punkt");
            string mening = Console.ReadLine();
            int mellanslagsindex = mening.IndexOf(" ");
            int punktindex = mening.IndexOf(".");
            string ord1 = mening[..mellanslagsindex];
            string ord2 = mening[(mellanslagsindex + 1)..punktindex];
            string ord3 = mening[(punktindex + 1)..];

            Console.WriteLine(ord3 + " " + ord2 + " " + ord1 + ".");

        }
    }
}