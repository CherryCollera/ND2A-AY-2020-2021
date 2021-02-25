/* Malit,JeanReyKimZ:19-08006
 * Castillo,Trisha Ann:19-05256
 * Nacino,Shrine:19-06798
 * ND2A
 * February 16,2021
 * Displaying Declared String
 */
using System;



namespace Sample2_MyProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name = "Castillo, Trisha Ann"; //name of the student
            String Dbirth = "November 15,2001";   //birthdate of the student
            String Year = "2nd Year";             //Year level of the student
            String Course = "BS Computer Science";//Course taken of the student
            String Section = "ND2A";              //Section of the student

            System.Console.WriteLine("Name: "+Name+"\n"+ "Birthdate: " + Dbirth + "\n" + "Year Level: " + Year + "\n" + "Course: " + Course + "\n" + "Section: " + Section);
            System.Console.ReadKey();
        }
    }
}
