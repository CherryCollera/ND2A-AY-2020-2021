using System;


namespace BasicOperation_Malit
{
    class Input
    {


        public void input()
        {



            Console.Write("\tAddition\n\tSubtraction\n\tMultiplication\n\tDivision\n");
            Console.Write("Enter your First Number: ");
             DeclareVar.num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your Second Number: ");
             DeclareVar.num2 = Convert.ToDouble(Console.ReadLine());
            


        } 
    }
}
