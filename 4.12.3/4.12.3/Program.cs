using System;

namespace _4._12._3
{
    class Program
    {
        static void Main()
        {
            int aantal = 0;

            Console.Write("Hoeveel getallen wil je ingeven: ");
            aantal = Convert.ToInt32(Console.ReadLine());

            int[] getallen = new int[aantal];

            for (int i = 0; i < aantal; i++)
            {
                Console.Write("Geef getal {0}: ", i + 1);
                getallen[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(getallen);

            foreach (int i in getallen)
            {
                Console.WriteLine(i);
            }
        }
    }
}

