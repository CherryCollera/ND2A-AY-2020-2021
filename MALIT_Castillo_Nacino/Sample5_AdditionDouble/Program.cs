/* Malit,JeanReyKimZ:19-08006
 * Castillo,Trisha Ann:19-05256
 * Nacino,Shrine:19-06798
 * ND2A
 * March 04,2021
 * Addition in Double
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample5_AdditionDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Double num1, num2;
            Console.WriteLine("Addition");
            Console.Write("Enter the First number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the First number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Double total = num1 + num2;
            Console.WriteLine("The total is: {0}", total);
            Console.ReadKey();
        }
    }
}
