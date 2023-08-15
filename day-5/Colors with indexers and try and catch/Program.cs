using System;

namespace ColorArray
{
    class ColorArray
    {
        private string[] colors;

        public ColorArray()
        {
            colors = new string[5] { "Red", "Blue", "Green", "Yellow", "Orange" };
        }

        public string this[int index]
        {
            get
            {
                return colors[index];
            }
            set
            {
                colors[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ColorArray colorArray = new ColorArray();
            Console.WriteLine("Enter a color index (1-5): ");
            try
            {
                int index = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine($"The color at index {index + 1} is {colorArray[index]}");
            }
            catch (IndexOutOfRangeException ioore)
            {
                Console.WriteLine("Invalid index. Please enter a number between 1 and 5.");
                Console.WriteLine(ioore.Message);
            }
            catch (FormatException FE)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5 because there is only 5 numbers.");
                Console.WriteLine(FE.Message);
            }
        }
    }
}
