using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTasksSolver
{
    class PulnaPovurhnina
    {

        public static void CalculateS1(double S, double B)
        {
            double S1 = S + 2 * B;
            Console.WriteLine(S1);
        }

        public static void CalculateB(double a)
        {
            double B = 2 * a * a * Math.Sqrt(3) / 2;
            Console.WriteLine(B);
        }

    }
}
