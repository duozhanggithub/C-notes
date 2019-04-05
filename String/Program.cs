using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Duo";
            var lastName = "Zhang";

            var fullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);

            var text = @"Hi, John
look into the following paths
c:\folder";
            Console.WriteLine(text);
 
        }
    }
}
