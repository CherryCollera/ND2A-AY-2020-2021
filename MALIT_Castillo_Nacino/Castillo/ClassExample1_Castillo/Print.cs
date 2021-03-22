using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample1_Castillo
{
    class Print
    {
        public void PrintDetails()
        {
            Accept a = new Accept();
            a.AcceptDetails();
            Console.Write("Hello! " + a.TACfname + " " + a.TAClname + "!!!\n You have created classes in OOP.");
            MyProfile mp = new MyProfile();
            mp.DisplayProfile();
        }
    }
}
