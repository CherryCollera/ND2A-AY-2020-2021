using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample12_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string JRKZname;
            char JRKZgender;
            Console.Write("Enter your name: ");
            JRKZname = Console.ReadLine();
            Console.Write("Enter your gender[F]/[M]: ");
            JRKZgender = Convert.ToChar(Console.ReadLine());
            Console.ReadKey();
            switch (JRKZgender)
            {
                case 'M':
                case 'm':
                    Console.WriteLine("Hi " + JRKZname + "! your gender is Male.");
                    break;
                case 'F':
                case 'f':
                    Console.WriteLine("Hi " + JRKZname + "! your gender is Female.");
                    break;
                default:
                    Console.WriteLine(" Invalid Input. . . . try again");
                    break;

            }
            Console.ReadKey();

        }
    }
}
