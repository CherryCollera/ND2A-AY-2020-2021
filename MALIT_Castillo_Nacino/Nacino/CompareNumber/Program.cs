/* Nacino,Shrine:19-06798
 * ND2A
 * March 11,2021
 * Using Compare To and Equal To Method
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int SAN_num1, SAN_num2, SAN_num3;
            Console.Write("Enter first number: ");
            SAN_num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            SAN_num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            SAN_num3 = Convert.ToInt32(Console.ReadLine());


            if ((SAN_num1 == SAN_num3) && (SAN_num1 > SAN_num2))
            {
                Console.WriteLine("{0} and {2} are greater than {1}", SAN_num1, SAN_num2, SAN_num3);
                Console.WriteLine("{1} is less than {0} and {2}", SAN_num1, SAN_num2, SAN_num3);
                Console.WriteLine("{0} and {2} are equal", SAN_num1, SAN_num2, SAN_num3);
            }

            else if ((SAN_num1 == SAN_num2) && (SAN_num1 > SAN_num3))
            {
                Console.WriteLine("{0} and {1} are greater than {2}", SAN_num1, SAN_num2, SAN_num3);
                Console.WriteLine("{2} is less than {0} and {1}", SAN_num1, SAN_num2, SAN_num3);
                Console.WriteLine("{0} and {1} are equal", SAN_num1, SAN_num2, SAN_num3);
            }

            else if ((SAN_num2 == SAN_num3) && (SAN_num2 > SAN_num1))
            {
                Console.WriteLine("{1} and {2} are greater than {0}", SAN_num1, SAN_num2, SAN_num3);
                Console.WriteLine("{0} is less than {1} and {2}", SAN_num1, SAN_num2, SAN_num3);
                Console.WriteLine("{1} and {2} are equal", SAN_num1, SAN_num2, SAN_num3);
            }

            else if ((SAN_num3 > SAN_num2) && (SAN_num3 > SAN_num1))
                {
                    Console.WriteLine("{2} are greater than {0} and {1}", SAN_num1, SAN_num2, SAN_num3);
                    Console.WriteLine("{0} is less than {2}", SAN_num1, SAN_num2, SAN_num3);
                    Console.WriteLine("{1} is less than {2}", SAN_num1, SAN_num2, SAN_num3);
                }

                else if ((SAN_num2 > SAN_num1) && (SAN_num2 > SAN_num3))
                {
                    Console.WriteLine("{1} are greater than {0} and {2}", SAN_num1, SAN_num2, SAN_num3);
                    Console.WriteLine("{0} is less than {1}", SAN_num1, SAN_num2, SAN_num3);
                    Console.WriteLine("{2} is less than {1}", SAN_num1, SAN_num2, SAN_num3);
                }

                else if ((SAN_num1 > SAN_num2) && (SAN_num1 > SAN_num3))
                {
                    Console.WriteLine("{0} are greater than {1} and {2}", SAN_num1, SAN_num2, SAN_num3);
                    Console.WriteLine("{1} is less than {0}", SAN_num1, SAN_num2, SAN_num3);
                    Console.WriteLine("{2} is less than {0}", SAN_num1, SAN_num2, SAN_num3);
                }
                else
                {
                    Console.WriteLine("{0}, {1} and {2} are equal", SAN_num1, SAN_num2, SAN_num3);
                    Console.WriteLine("{0}, {1} and {2} are same number", SAN_num1, SAN_num2, SAN_num3);
                }
            Console.ReadKey();
        }
    }
}
