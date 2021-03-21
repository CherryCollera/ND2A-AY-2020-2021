/* Malit,JeanReyKimZ:19-08006
 * ND2A
 * March 20,2021
 * Implementing Classes
 */
using System;

namespace CLassExample2_Malit
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
