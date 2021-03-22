/* Castillo, Trisha Ann:19-05256
 * ND2A
 * March 19,2021
 * Implementing Classes
 */
using System;


namespace ClassExample2_Castillo
{
    class Program
    {
        public static void Main()
        {
            Car car;
            car = new Car("Red");
            Console.WriteLine(car.Describe());
            car = new Car("Green");
            Console.WriteLine(car.Describe());
            Console.ReadKey();
        }
    }
}
