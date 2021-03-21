using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Nacino
{
    class Product
    {
        

            public void ComputeProd()
            {

                DeclareVar.prod = DeclareVar.num1 * DeclareVar.num2;
                Console.WriteLine("Product = {0}", DeclareVar.prod);
            }
        
    }
}
