/* Malit,JeanReyKimZ:19-08006
 * Castillo,Trisha Ann:19-05256
 * Nacino,Shrine:19-06798
 * ND2A
 * March 04,2021
 * Basic Opration(Add,Minus,Multiply,Divide)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample7_BasicOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Basic Operation");
            Console.Write("Enter the First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int total = num1 + num2;
            Console.WriteLine("The total is: {0}", total);
            int difference = num1 - num2;
            Console.WriteLine("The difference is: {0}", difference);
            int Product = num1 * num2;
            Console.WriteLine("The Product is: {0}", Product);
            int Quotient = num1 / num2;
            Console.WriteLine("The Quotient is: {0}", Quotient);
            int Remainder = num1 % num2;
            Console.WriteLine("The Remainder is: {0}", Remainder);
            Console.ReadKey();
        }
    }
}
