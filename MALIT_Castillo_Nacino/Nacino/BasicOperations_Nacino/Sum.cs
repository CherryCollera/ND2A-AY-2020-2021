using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Nacino
{
	class Sum
	{
		public void ComputeSum()
		{
			DeclareVar.sum = DeclareVar.num1 + DeclareVar.num2;
			Console.WriteLine("Sum = {0}", DeclareVar.sum);
		}
	}
}
