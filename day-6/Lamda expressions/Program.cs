using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            IEnumerable<int> squaredNumbers = numbers.Select(x => x * x);

            var divisibleByThree = squaredNumbers.Where(x => (x % 3) == 0);

            // Display the result
            Console.WriteLine("Numbers divisible by three: ");
            foreach (int number in divisibleByThree)
            {
                Console.WriteLine(number);
            }
        }
    }
}
