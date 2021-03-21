/* Nacino,Shrine:19-06798
 * ND2A
 * March 21,2021
 * implementingclasses
 */
using System;


namespace ClassExample2_Nacino
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;
            car = new Car("Red");
            Console.WriteLine(car.Describe());
            car = new Car("Green");
            Console.WriteLine(car.Describe());
            Console.ReadLine();
        }
    }
}
