using System;


namespace CompareNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the greatest numbo;~>

           
                //find the greatest numbo;~>

                int TAC_num1, TAC_num2, TAC_num3;
                Console.Write("Enter first number: ");
                TAC_num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                TAC_num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter third number: ");
                TAC_num3 = Convert.ToInt32(Console.ReadLine());


                if ((TAC_num1 == TAC_num2) && TAC_num1 > TAC_num3)
                {
                    Console.Write("{0} and {1} are greater than {2} {0} and {1} are equal {2} is less than {0} and {1} ", TAC_num1, TAC_num2, TAC_num3);
                }

                else if ((TAC_num1 == TAC_num3) && TAC_num1 > TAC_num2)
                {
                    Console.Write("{0} and {2} are greater than {1} {0} and {2} are equal {1} is less than {0} {2} ", TAC_num1, TAC_num2, TAC_num3);
                }

                else if ((TAC_num2 == TAC_num3) && TAC_num2 > TAC_num1)
                {
                    Console.Write("{1} and {2} are greater than {0n{2}and {1} are equal {0} is less than {1}  and {2} ", TAC_num1, TAC_num2, TAC_num3);
                }

                else if ((TAC_num3 > TAC_num2) && TAC_num3 > TAC_num1)
                {
                    Console.Write("{2} are greater than {0} and {1} {0} is less than {1} {0} is less than {2} ", TAC_num1, TAC_num2, TAC_num3);
                }

                else if ((TAC_num2 > TAC_num1) && TAC_num2 > TAC_num3)
                {
                    Console.Write("{1} are greater than {0} and {2} {0} is less than {1} {2} is less than {1} ", TAC_num1, TAC_num2, TAC_num3);
                }

                else if ((TAC_num1 > TAC_num2) && TAC_num1 > TAC_num3)
                {
                    Console.Write("|{1} is less than {0} {2} is less than {0}", TAC_num1, TAC_num2, TAC_num3);
                }

                else
                {
                    Console.Write("{0}, {1} and {2} are equal", TAC_num1, TAC_num2, TAC_num3);
                } Console.ReadKey();








            
        }
        }
    }
