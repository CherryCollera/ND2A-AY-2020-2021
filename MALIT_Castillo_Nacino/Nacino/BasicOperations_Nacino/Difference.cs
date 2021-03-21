using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Nacino
{
    class Difference
    {
        public void ComputeDiff()
        {

            DeclareVar.diff = DeclareVar.num1 - DeclareVar.num2;
            Console.WriteLine("Difference = {0}", DeclareVar.diff);
        }
    }
}
