using System;

namespace Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int value = length * width * height;
            string input = Console.ReadLine();

            while (input != "Done")
            {
                int boxes = int.Parse(input);
                value -= boxes;
                if (value <= 0) { break; }
                input = Console.ReadLine();
            }

            if (value > 0) { Console.WriteLine($"{value} Cubic meters left."); }
            else { Console.WriteLine($"No more free space! You need {Math.Abs(value)} Cubic meters more."); }
        }
    }
}
