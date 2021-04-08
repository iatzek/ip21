using System;

namespace ip2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = 2, c = -1;
            double x1, x2;

            double delta = b * b - 4 * a * c;

            if (delta >= 0)
            {

                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / 2 / a;

                Console.WriteLine("dwa pierwiastki: {0} {1}", x1, x2);
            } else
            {
                Console.WriteLine("brak pierwiastków");
            }

        }
    }
}
