using System;


namespace ClassExample1_Castillo
{
    class Accept
    {
        public string TACfname, TAClname;
        public void AcceptDetails()
        {
            Console.Write("Enter your First Name: ");
            TACfname = Console.ReadLine();
            Console.Write("Enter your Last Name: ");
            TAClname = Console.ReadLine();
        }
    }
}
