using System;


namespace ClassExample2_Nacino
{
    class Car
    {
        private string color;
        public Car(string color)
        {
            this.color = color;
        }
        public string Describe()
        {
            return "this car is " + color;
        }
    }
}
