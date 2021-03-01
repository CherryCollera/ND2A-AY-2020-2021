/*19-04625
 *19-05660
 * Joanna Ruffe Manalac
 * Crystal Ann Lee
 * ND2A
 * March 1, 2020
 * This program will display "Hello Member1/Member2 name"
 */


using System;


namespace Sample3_InputMyName
{
    public static class Program
    {
        public static void Main()
        {

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            string name2 = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!!!");
            Console.WriteLine("Hello " + name2 + "!!!");
            Console.WriteLine(" WELCOME TO OOP environment");

            Console.ReadKey();

        }
    }
}
