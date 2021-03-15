/* Castillo,Trisha Ann:19-05256
 * ND2A
 * March 11,2021
 * Using Do While
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
			
				int[] TAC_num = new int[] { 6, 7, 8, 10 };
				int TAC_sum = 0;
				int i = 0;

				do
				{
					TAC_sum += TAC_num[i];
					i++;
				} while (i < 4);

				Console.WriteLine("Sum is {0}", TAC_sum);
				Console.ReadKey();
			
		}
    }
}
