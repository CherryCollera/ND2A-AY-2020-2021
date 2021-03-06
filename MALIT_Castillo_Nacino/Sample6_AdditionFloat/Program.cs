/* Malit,JeanReyKimZ:19-08006
 * Castillo,Trisha Ann:19-05256
 * Nacino,Shrine:19-06798
 * ND2A
 * March 04,2021
 *Addition in Double
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample6_AdditionFloat
{
    class Program
    {
        static void Main(string[] args)
        {
             float num1, num2;
            Console.WriteLine("Addition");
            Console.Write("Enter the First number: ");
            num1 =float.Parse(Console.ReadLine());
            Console.Write("Enter the First number: ");
            num2 = float.Parse(Console.ReadLine());
            float total = num1 + num2;
            Console.WriteLine("The total is: {0}", total);
            Console.ReadKey();
        }
    }
}
