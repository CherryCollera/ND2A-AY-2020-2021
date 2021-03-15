/* Malit,JeanReyKimZ:19-08006
 * ND2A
 * March 11,2021
 * Using Compare To and Equal To Method
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample11_CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int JRKZM__uno, JRKZM__dos, JRKZM__tres;
            Console.Write("Enter first number: ");
            JRKZM__uno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            JRKZM__dos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            JRKZM__tres = Convert.ToInt32(Console.ReadLine());


            if ((JRKZM__uno == JRKZM__tres) && (JRKZM__uno > JRKZM__dos))
            {
                Console.WriteLine("{0} and {2} are greater than {1}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
                Console.WriteLine("{1} is less than {0} and {2}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
                Console.WriteLine("{0} and {2} are equal", JRKZM__uno, JRKZM__dos, JRKZM__tres);
            }

            else if ((JRKZM__uno == JRKZM__dos) && (JRKZM__uno > JRKZM__tres))
            {
                Console.WriteLine("{0} and {1} are greater than {2}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
                Console.WriteLine("{2} is less than {0} and {1}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
                Console.WriteLine("{0} and {1} are equal", JRKZM__uno, JRKZM__dos, JRKZM__tres);
            }

            else if ((JRKZM__dos == JRKZM__tres) && (JRKZM__dos > JRKZM__uno))
            {
                Console.WriteLine("{1} and {2} are greater than {0}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
                Console.WriteLine("{0} is less than {1} and {2}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
                Console.WriteLine("{1} and {2} are equal", JRKZM__uno, JRKZM__dos, JRKZM__tres);
            }

            else if ((JRKZM__tres > JRKZM__dos) && (JRKZM__tres > JRKZM__uno))
            {
                Console.WriteLine("{2} are greater than {0} and {1}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
                Console.WriteLine("{0} is less than {2}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
                Console.WriteLine("{1} is less than {2}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
            }

            else if ((JRKZM__dos > JRKZM__uno) && (JRKZM__dos > JRKZM__tres))
            {
                Console.WriteLine("{1} are greater than {0} and {2}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
                Console.WriteLine("{0} is less than {1}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
                Console.WriteLine("{2} is less than {1}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
            }

            else if ((JRKZM__uno > JRKZM__dos) && (JRKZM__uno > JRKZM__tres))
            {
                Console.WriteLine("{0} are greater than {1} and {2}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
                Console.WriteLine("{1} is less than {0}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
                Console.WriteLine("{2} is less than {0}", JRKZM__uno, JRKZM__dos, JRKZM__tres);
            }
            else
            {
                Console.WriteLine("{0}, {1} and {2} are equal", JRKZM__uno, JRKZM__dos, JRKZM__tres);
                Console.WriteLine("{0}, {1} and {2} are same number", JRKZM__uno, JRKZM__dos, JRKZM__tres);
            }
            Console.ReadKey();
        }
    }
}
