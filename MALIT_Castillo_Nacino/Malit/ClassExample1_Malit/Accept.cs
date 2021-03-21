using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample1_Malit
{
    class Accept
    {       public string fname, lname;
            public void AcceptDetails()
        {
            Console.Write("Enter your First Name: ");
            fname = Console.ReadLine();
            Console.Write("Enter your Last Name: ");
            lname = Console.ReadLine();
        }
    }
}
