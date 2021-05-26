using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTasksSolver
{
    class OkolnaPovurhninaTriugulna
    {

        public static void CalculateS(double P, double h)
        {
            double S = P * h;
            Console.WriteLine(S);
        }

        public static void CalculateP(double a)
        {
            double P = 3 * a;
            Console.WriteLine(P);
        }

        public static void CalculateH(double V, double B)
        {
            double h = V / B;
            Console.WriteLine(h);
        }

    }
}
