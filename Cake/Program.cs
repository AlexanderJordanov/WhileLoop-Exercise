using System;
using System.Xml.Schema;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int totalPeaces = length * width;
            string input = Console.ReadLine();

            while (input != "STOP") 
            {
                int peaces = int.Parse(input);
                totalPeaces -= peaces;
                if (totalPeaces <= 0) { break; }
                input = Console.ReadLine();
            }
            if (totalPeaces > 0)
            {
                Console.WriteLine($"{totalPeaces} pieces are left.");
            }
            else { Console.WriteLine($"No more cake left! You need {Math.Abs(totalPeaces)} pieces more."); }
            

        }
    }
}
