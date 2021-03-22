/* Castillo, Trisha Ann:19-05256
 * ND2A
 * March 19,2021
 * Implementing Classes in Basic Operation
 */
using System;


namespace BasicOperation_Castillo
{
    class Program
    {
		public static void Main()
		{
			Input i = new Input();
			i.InputData();
			Addition a = new Addition();
			a.ComputeSum();
			Subtraction s = new Subtraction();
			s.ComputeDiff();
			Product p = new Product();
			p.ComputeProduct();
			Division d = new Division();
			d.ComputeDiv();
			Remainder r = new Remainder();
			r.ComputeRem();
			Console.ReadKey();
		}
	}
}
