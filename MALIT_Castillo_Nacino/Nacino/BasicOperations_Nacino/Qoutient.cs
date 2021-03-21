using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Nacino
{
    class Qoutient
    {

        public void ComputeQuotient()
        {

            DeclareVar.quo = DeclareVar.num1 / DeclareVar.num2;
            Console.WriteLine("Quotient = {0}", DeclareVar.quo);
        }
    }
}
