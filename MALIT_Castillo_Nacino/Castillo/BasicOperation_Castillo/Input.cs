using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation_Castillo
{
    class Input
    {
        public void InputData()
        {
            System.Console.Write("Enter first number: ");
            Declarevar.num1 = System.Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Enter second number: ");
            Declarevar.num2 = System.Convert.ToDouble(Console.ReadLine());
        }
    }
}