using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForEveruthing
{
    class ToBinary
    {

        private string code;
        public uint number
        {
            set
            {
                uint num = value;
                code = "";

                do
                {
                    code = (num % 2) + code;
                    num >>= 1;
                } while (num != 0);
            }
        }

        public ToBinary(uint n)
        {
            this.number = n;
        }

        public override string ToString()
        {
            return this.code;
        }

    }
}
