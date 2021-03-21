/* Malit,JeanReyKimZ:19-08006
 * ND2A
 * March 20,2021
 * Implementing Classes in Basic Operation
 */
using System;

namespace BasicOperation_Malit
{
    class Program
    {
        static void Main()
        {
          
            char opt;
            do
            {
                Console.WriteLine("\t\t\tBasic Operation");
                Input i = new Input();
                i.input();
                Sum s = new Sum();
                s.Add();
                Difference d = new Difference();
                d.Sub();
                Product m = new Product();
                m.Multiply();
                Quotient q = new Quotient();
                q.Divide();
                Remainder rem = new Remainder();
                rem.remainder();
                Console.Write("\t\t\tWant to try again[Y/N]: ");
                opt = Convert.ToChar(Console.ReadLine());
            } while (opt != ('N'));    //i added loop for the user can reuse the program.
        }
    }
}
