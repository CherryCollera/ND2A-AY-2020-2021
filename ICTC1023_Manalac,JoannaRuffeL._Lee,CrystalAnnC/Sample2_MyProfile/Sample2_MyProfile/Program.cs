/*19-04625
 *19-05660
*Joanna Ruffe Manalac
*Crystal Ann Lee
*ND2A
*March 1, 2020
*This program will display the profile of student
*/

using System;


namespace Sample2_MyProfile
{ 
 public static class Program
{
    public static void Main()
    {
        string name = "Joanna Ruffe Manalac";
        string birthdate = "July 30, 2000";
        string course = "Bachelor of Science Major in Network and Data Communication";
        int year = 2;
        string section = "A";

        Console.WriteLine("Member 1");
        Console.WriteLine("Name : ");
        Console.WriteLine(name);
        Console.WriteLine("Date of Birth : ");
        Console.WriteLine(birthdate);
        Console.WriteLine("Course : ");
        Console.WriteLine(course);
        Console.WriteLine("Year : ");
        Console.WriteLine(year);
        Console.WriteLine("Section : ");
        Console.WriteLine(section);

        string name2 = "Crystal Ann Lee";
        string birthdate2 = "December 14, 2000";
        string course2 = "Bachelor of Science Major in Network and Data Communication";
        int year2 = 2;
        string section2 = "A";

        Console.WriteLine("Member 2");
        Console.WriteLine("Name : ");
        Console.WriteLine(name2);
        Console.WriteLine("Date of Birth : ");
        Console.WriteLine(birthdate2);
        Console.WriteLine("Course : ");
        Console.WriteLine(course2);
        Console.WriteLine("Year : ");
        Console.WriteLine(year2);
        Console.WriteLine("Section : ");
        Console.WriteLine(section2);

        Console.ReadKey();
        Console.ReadKey();

    }
}
}
