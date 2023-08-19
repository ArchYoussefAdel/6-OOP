using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7OOP
{

    #region task 1 (reversed number using extention method)
    static class Myclass
    {
        public static int Swap(this int number)
        {
            int reversed_number = 0, reminder = 0;
            while (number > 0)
            {
                reminder = number % 10;
                reversed_number = (reversed_number * 10) + reminder;
                number = number / 10;
            }
            return reversed_number;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" enter the number you want to reverse:  ");
            int number = int.Parse(Console.ReadLine());
            Myclass.Swap(number);
            Console.WriteLine($"the reversed number is " + Myclass.Swap(number));
            Console.ReadLine();

        }
    }
}
#endregion

