using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string input = Console.ReadLine();
            int booksCount = 0;
            while (input != "No More Books")
            {
                
                if (input == book) { break; }

                booksCount++;
                input = Console.ReadLine();
            }
            if (input == book) 
            {
                Console.WriteLine($"You checked {booksCount} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {booksCount} books.");
            }
        }
    }
}
