/* Malit,JeanReyKimZ:19-08006
 * Castillo,Trisha Ann:19-05256
 * Nacino,Shrine:19-06798
 * ND2A
 * March 04,2021
 * Average of grades
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample8_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Ave, total, first, second, third, fourth, fifth;
            Console.WriteLine("Grade Average Calculator");
            Console.Write("Enter the first Grade: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second Grade: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third Grade: ");
            third = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the fourth Grade: ");
            fourth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the fifth Grade: ");
            fifth = Convert.ToDouble(Console.ReadLine());
            total = first + second + third + fourth + fifth;
            Ave= total/ 5;
            Console.WriteLine("The Average is: {0:0.000}",Ave);
            Console.ReadKey();
        }
    }
}
