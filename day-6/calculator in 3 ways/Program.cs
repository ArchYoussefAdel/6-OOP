using System;

namespace indexers
{
    internal class Program
    {
        public class Calculater
        {
            // Declare Delegate 
            public delegate int Calculator(int p, int q);

            public int Sum(int a, int b)
            {
                return a + b;
            }

            public int Subtract(int a, int b)
            {
                return a - b;
            }

            public int Multiply(int a, int b)
            {
                return a * b;
            }

            public int Divide(int a, int b)
            {
                return a / b;
            }

            // Use an enum to represent the different operations
            public enum Operation
            {
                ADD,
                SUBTRACT,
                MULTIPLY,
                DIVIDE
            }

            public Calculator Solve(Operation operationName)
            {
                Calculator objectDelegate = null;

                // Use a switch statement instead of multiple if statements
                switch (operationName)
                {
                    case Operation.ADD:
                        objectDelegate = Sum;
                        break;
                    case Operation.SUBTRACT:
                        objectDelegate = Subtract;
                        break;
                    case Operation.MULTIPLY:
                        // Prompt the user to choose between using a delegate, lambda expression, or anonymous method
                        Console.WriteLine("Choose how to perform the multiply operation:");
                        Console.WriteLine("1. Delegate");
                        Console.WriteLine("2. Lambda expression");
                        Console.WriteLine("3. Anonymous method");
                        int choice = int.Parse(Console.ReadLine());

                        if (choice == 1)
                        {
                            objectDelegate = Multiply;
                        }
                        else if (choice == 2)
                        {
                            // Use a lambda expression to perform the multiply operation
                            objectDelegate = (a, b) => a * b;
                        }
                        else if (choice == 3)
                        {
                            // Use an anonymous method to perform the multiply operation
                            objectDelegate = delegate (int a, int b) { return a * b; };
                        }
                        else
                        {
                            // Add error handling for invalid choices
                            throw new ArgumentException("Invalid choice");
                        }
                        break;

                    case Operation.DIVIDE:
                        objectDelegate = Divide;
                        break;
                    default:
                        // Add error handling for invalid operation names
                        throw new ArgumentException("Invalid operation name");
                }

                return objectDelegate;
            }
        }

        static void Main(string[] args)
        {
            Calculater object1 = new Calculater();

            // Prompt the user to enter the first integer
            Console.Write("Enter the first integer: ");
            int firstInt = int.Parse(Console.ReadLine());

            // Prompt the user to choose an operation from the list of operations
            Console.WriteLine("Choose an operation from the list:");
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. SUBTRACT");
            Console.WriteLine("3. MULTIPLY");
            Console.WriteLine("4. DIVIDE");

            Calculater.Operation operation = (Calculater.Operation)(int.Parse(Console.ReadLine()) - 1);

            // Prompt the user to enter the second integer
            Console.Write("Enter the second integer: ");
            int secondInt = int.Parse(Console.ReadLine());

            // Use the enum to specify the operation name and invoke the delegate with the entered integers
            int result = object1.Solve(operation).Invoke(firstInt, secondInt);

            // Display the result
            Console.WriteLine($"Result: {result}");
        }
    }
}
