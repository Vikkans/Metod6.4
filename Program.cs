using System;

namespace forre
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double y = 3;

            Console.WriteLine(Potens(x, y));

        }

        static double Potens(double x, double y)
        {
            double svar = 1;
            for (double i = 0; i < y; i++)
            {
                svar = x * svar;
            }

            return svar;
        }
    }
}