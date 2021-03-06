/* Malit,JeanReyKimZ:19-08006
 * Castillo,Trisha Ann:19-05256
 * Nacino,Shrine:19-06798
 * ND2A
 * March 04,2021
 * Addtion in Integers
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample4_AdditionInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Addition");
            Console.Write("Enter the First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the First number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int total = num1 + num2;
            Console.WriteLine("The total is: {0}", total);
            Console.ReadKey();
        }
    }
}
