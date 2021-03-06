/* Malit,JeanReyKimZ:19-08006
 * Castillo,Trisha Ann:19-05256
 * Nacino,Shrine:19-06798
 * ND2A
 * March 04,2021
 * Condition If Else Statement
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample10_NumberIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("{0} is greater than {1} and {2}", num1, num2, num3);

                }
                else
                {
                    Console.Write("{0} is greater than {1} and {2}", num3, num2, num1);
                }
            }
            else if(num2 > num3)
            {
                Console.Write("{0} is greater than {1} and {2}", num2, num1, num3);
            }
            else if((num2 == num3) && (num3 == num1))
            {
                Console.Write("{0}, {1} and {2} are equal", num1, num2, num3);
            }
            else
            {
                Console.Write("{0} is greater than {1} and {2}", num3, num2, num1);
            }

            Console.ReadKey();
        }
        }
        }
    






