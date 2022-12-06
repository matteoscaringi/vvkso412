using System;

namespace _4122
{
    class Program
    {
        static void Main(string[] args)
        {
            int aantal, keuze;

            Console.Write("Hoeveel cijfers wil je ingeven: ");
            aantal = Convert.ToInt32(Console.ReadLine());

            int[] cijfers = new int[aantal];

            for (int i = 1; i <= aantal; i++)
            {
                Console.Write("Geef cijfer {0}: ", i);
                cijfers[i-1] = Convert.ToInt32(Console.ReadLine());
            }

            while (true)
            {
                Console.Write("Welk getal wil je uit de array zien: ");
                keuze = Convert.ToInt32(Console.ReadLine());

                if (keuze <= aantal)
                {
                    Console.WriteLine("Het getal is: " + cijfers[keuze - 1]);
                }
                else
                {
                    Console.WriteLine("Dit getal is niet in de array!");
                }
            }
        }
    }
}