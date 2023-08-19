using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7oopAnonymous_Types
{
    // task 2 (Anonymous Types)
    class Anonymous
    {
        static void Main(string[] args)
        {
            var person1 = new { Name = "jo", ID = 25 };
            var person2 = new { Name = "adam", ID = "20" };
            Console.WriteLine("name of first employee is: " + person1.Name);
            Console.WriteLine("ID of first employee is: " + person1.ID);
            Console.WriteLine("name of Second employee is: " + person2.Name);
            Console.WriteLine("ID of Second employee is: " + person2.ID);
            Console.ReadLine();
        }
    }
}
