using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForEveruthing
{
    class SquareRoot
    {

        public static double number;

        public SquareRoot(double num)
        {
            number = num;
        }

        public override string ToString()
        {
            return $"Square root {Math.Sqrt(number)}";
        }

    }
}
