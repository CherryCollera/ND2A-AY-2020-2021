/* Nacino,Shrine:19-06798
 * ND2A
 * March 11,2021
 * Do While
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
			
				int[] SAN_num = new int[] { 6, 7, 8, 10 };
				int SAN_sum = 0;
				int i = 0;

				do
				{
					SAN_sum += SAN_num[i];
					i++;
				} while (i < 4);

				Console.WriteLine("Kabuuan ay {0}", SAN_sum);
				Console.ReadKey();
			
		}
    }
}
