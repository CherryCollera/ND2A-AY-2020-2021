
/* NAcino, Shrine :19-06798
 * ND2A
 * March 11,2021
 * Using Compare To and Equal To Method
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareName
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Shrin";
            string string2 = "Shrin";
            string string3 = "Shrine";
            string string4 = "Shrine";
            string string5 = "SHRINE";

            Console.WriteLine("using Equals() Method");
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string2, String.Equals(string1, string2));
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string3, String.Equals(string1, string3));
            Console.WriteLine(" lenght of {0} is {1}", string1, string1.Length);
            Console.WriteLine(" string {0} Substring(0,3) will return {1}", string5, string5.Substring(0, 3));

            Console.WriteLine("using Compare () Method");
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string2, String.Compare(string1, string2));
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string3, String.Compare(string1, string3));
            Console.WriteLine(" compare {0} to {1}: {2}", string3, string1, String.Compare(string3, string1));
            Console.WriteLine(" compare {0} to {1}: {2}", string4, string5, String.Equals(string4, string5));

            Console.WriteLine("Using CompareTo() Method");
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string2, string1.CompareTo(string2));
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string3, string1.CompareTo(string3));
            Console.WriteLine(" compare {0} to {1}: {2}", string3, string1, string2.CompareTo(string1));
            Console.ReadKey();
        }
    }
}
