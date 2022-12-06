using System;

namespace _4121
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0, aantal, afwisselend = 0;

            Console.Write("Hoeveel cijfers wil je ingeven: ");
            aantal = Convert.ToInt32(Console.ReadLine());

            int[] cijfers = new int[aantal];

            for (int i = 1; i <= aantal; i++)
            {
                Console.Write("Geef getal {0}: ", i);
                cijfers[i-1] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i <= aantal; i++)
            {
                som = som + cijfers[i-1];

                if (i == 1)
                {
                    afwisselend = cijfers[0];
                }
                else if (i % 2 == 0)

                {
                    afwisselend = afwisselend + cijfers[i-1];
                }
                else
                {
                    afwisselend = afwisselend - cijfers[i-1];
                }
            }

            Console.WriteLine("Som: {0}", cijfers.Sum());
            Console.WriteLine("Alternerend: {0}", afwisselend);
        }
    }
}