using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation_Castillo
{
    class Remainder
    {
        public void ComputeRem()
        {
            Declarevar.rem = Declarevar.num1 % Declarevar.num2;
            System.Console.WriteLine("Remainder is " + Declarevar.rem);
        }
    }
}
