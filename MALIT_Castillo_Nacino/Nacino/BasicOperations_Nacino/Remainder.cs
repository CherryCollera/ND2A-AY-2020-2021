using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Nacino
{
    class Remainder
    {

        public void ComputeRem()
        {

            DeclareVar.rem = DeclareVar.num1 % DeclareVar.num2;
            Console.WriteLine("Remainder = {0}", DeclareVar.rem);

        }
    }
}
