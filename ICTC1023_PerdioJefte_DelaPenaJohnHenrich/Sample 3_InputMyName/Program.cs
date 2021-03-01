/* 
  19-01923
  Jefte R.Perdio
  19-00359
  John Henrich Dela Pena
  BSCS ND2A
  23/02/21
  The Program inteded to get a input from the user which is their Firstname and Lastname at the same time
  and displaying it in the console
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_3_InputMyName
{
    class InputMyName
    {
        static void Main(string[] args)


        {
            Console.Write("Enter(Firstname/Lastname)  :  ");
            String Name = Console.ReadLine();

            Console.WriteLine("Hello  " + Name + "!!!!");
            Console.WriteLine("Welcome to OOP Environment");

            Console.ReadLine();
        }
    }
}
