/*
19-01923
Jefte R.Perdio
19-00359
John Henrich Dela Pena
BSCS ND2A
23/02/21
The Program inteded to display personal identification of the students
 */
namespace Sample2_MyProfile
{
    class MyProfile
    {
        static void Main(string[] args)
        {
            string name1 = "Jefte R. Perdio", name2 = "John Henrich Dela Pena";
            string bday1 = "08/19/2000", bday2 = "11/28/2000";
            string course = "BS in Computer Science";
            string yearsection = "2nd Year - ND2A";

            System.Console.WriteLine("Name : "+ name1);
            System.Console.WriteLine("BirthDate : "+ bday1);
            System.Console.WriteLine("Course : " + course);
            System.Console.WriteLine("Year : " + yearsection);
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine("Name : "+ name2);
            System.Console.WriteLine("BirthDate : "+ bday2);
            System.Console.WriteLine("Course : " + course);
            System.Console.WriteLine("Year : " + yearsection);
            System.Console.ReadKey();
        }
    }
}
