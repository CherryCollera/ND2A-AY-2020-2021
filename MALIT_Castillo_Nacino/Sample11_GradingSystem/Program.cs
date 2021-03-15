/* Malit,JeanReyKimZ:19-08006
 * ND2A
 * March 11,2021
 * Grading System
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample11_GradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            String marks = "Remarks:";
            String GEqui = "Grade Equivalent:";
            Console.WriteLine("Grading System");
            Console.Write("Enter your Grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            
            if ((grade >= 98) && (grade <= 100))
            {
                Console.WriteLine(GEqui+" 1"+ "\n" +marks + " Excelent");
                Console.ReadKey();
            }

            else if ((grade >= 95) && (grade <= 97))
            {
                Console.WriteLine(GEqui + " 1.25" + "\n" + marks + " Superior");
                Console.ReadKey();
            }

            else if ((grade >= 92) && (grade <= 94))
            {
                Console.WriteLine(GEqui + " 1.50" + "\n" + marks + " Very Good");
                Console.ReadKey();
            }

            else if((grade >= 91) && (grade <= 89))
            {
                Console.WriteLine(GEqui + " 1.75" + "\n" + marks + " Very Good");
                Console.ReadKey();
            }

            else if ((grade >= 86) && (grade <= 88))
            {
                Console.WriteLine(GEqui + " 2" + "\n" + marks + " Good");
                Console.ReadKey();
            }

            else if ((grade >=83 ) && (grade <= 85))
            {
                Console.WriteLine(GEqui + " 2.25" + "\n" + marks + " Good");
                Console.ReadKey();
            }

            else if ((grade >= 80) && (grade <= 82))
            {
                Console.WriteLine(GEqui + " 2.50" + "\n" + marks + " Fair");
                Console.ReadKey();
            }

            else if ((grade >= 77) && (grade <= 79))
            {
                Console.WriteLine(GEqui + " 2.75" + "\n" + marks + " Passed");
                Console.ReadKey();
            }

            else if ((grade >= 75) && (grade <= 76))
            {
                Console.WriteLine(GEqui + " 3" + "\n" + marks + " Passed");
                Console.ReadKey();
            }
            else if ((grade >= 72)&& (grade <= 74))
            {
                Console.WriteLine(GEqui + " 4" + "\n" + marks + " Conditional (MT only)");
                Console.ReadKey();
            }

            else if ((grade >= 60) && (grade <= 71))
            {
                Console.WriteLine(GEqui + " 5" + "\n" + marks + " Failed");
                Console.ReadKey();
            }
           

        }
    }
}
