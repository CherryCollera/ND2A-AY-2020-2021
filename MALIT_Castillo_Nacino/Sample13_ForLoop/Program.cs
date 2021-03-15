using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample13_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10 - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
