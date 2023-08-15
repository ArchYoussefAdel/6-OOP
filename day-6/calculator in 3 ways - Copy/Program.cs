using System;

namespace indexers
{
    internal class Program
    {
        public class Calculater
        {
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

                switch (operationName)
                {
                    case Operation.ADD:
                        objectDelegate = Sum;
                        break;
                    case Operation.SUBTRACT:
                        objectDelegate = Subtract;
                        break;
                    case Operation.MULTIPLY:
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
                            objectDelegate = (a, b) => a * b;
                        }
                        else if (choice == 3)
                        {
                            objectDelegate = delegate (int a, int b) { return a * b; };
                        }
                        else
                        {
                            throw new ArgumentException("Invalid choice");
                        }
                        break;

                    case Operation.DIVIDE:
                        objectDelegate = Divide;
                        break;
                    default:
                        throw new ArgumentException("Invalid operation name");
                }

                return objectDelegate;
            }
        }

        static void Main(string[] args)
        {
            Calculater object1 = new Calculater();

            Console.Write("Enter the first integer: ");
            int firstInt = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation from the list:");
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. SUBTRACT");
            Console.WriteLine("3. MULTIPLY");
            Console.WriteLine("4. DIVIDE");

            Calculater.Operation operation = (Calculater.Operation)(int.Parse(Console.ReadLine()) - 1);

            Console.Write("Enter the second integer: ");
            int secondInt = int.Parse(Console.ReadLine());

            int result = object1.Solve(operation).Invoke(firstInt, secondInt);

            Console.WriteLine($"Result: {result}");
        }
    }
}
