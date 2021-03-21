using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Nacino
{

	class Input
	{
		public void InputData()
		{
			Console.WriteLine("Enter first number:");
			DeclareVar.num1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter second number:");
			DeclareVar.num2 = Convert.ToDouble(Console.ReadLine());
		}
	}
}
