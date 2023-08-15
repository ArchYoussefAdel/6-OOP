using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Test
    {
        static int I;
        private static void Welcome()
        { Console.WriteLine("Welcome to Our Test Class"); }
        private static void GoodBye()
        { Console.WriteLine("This is the end of our Class"); }
        public static void PrintMessage()
        {
            Console.WriteLine("This Message from Test Class");
            Welcome();
        }
        public static void DivideNumbers()
        {
            try
            {
                Console.WriteLine("Enter first Number");
                int I = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int j = int.Parse(Console.ReadLine());
                int k = I / j;
                Console.WriteLine($"The result of dividing {I} by {j} is {k}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
        }
        public static void Main()
        {
            try
            {
                Console.Write("Enter an integer: ");
                I = int.Parse(Console.ReadLine());
                PrintMessage();
            }
            catch (FormatException FE)
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                Console.WriteLine(FE);
            }
            finally
            {
                GoodBye();
            }

            DivideNumbers();

        }
    }

}
