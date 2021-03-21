/* Nacino,Shrine:19-06798
 * ND2A
 * March 21,2021
 * implementingclasses
 */
using System;

namespace BasicOperations_Nacino
{
	class Program
	{
		static void Main(string[] args)
		{
			Input i = new Input();
			i.InputData();
			
			Sum s = new Sum();
			s.ComputeSum();
			Difference d = new Difference();
			d.ComputeDiff();
			Product p = new Product();
			p.ComputeProd();
			Qoutient q = new Qoutient();
			q.ComputeQuotient();
			Remainder r = new Remainder();
			r.ComputeRem();



			Console.ReadKey();
		}
	}
}