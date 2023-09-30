using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacationCost = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            string motion = Console.ReadLine();

            int daysSpend = 0; int daysTotal = 0;
            bool failed = false;
            while (budget < vacationCost)
            {
                double amount = double.Parse(Console.ReadLine());
                daysTotal++;
                if (motion == "spend")
                {
                    budget -=amount;
                    daysSpend++;
                    if (budget < 0) { budget = 0; }
                    if (daysSpend == 5) { failed = true; break; }
                }
                else if (motion == "save")
                {
                    budget += amount;
                    daysSpend = 0;
                }
               
                motion = Console.ReadLine();
            }
            if (failed)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysTotal);
            }
            else { Console.WriteLine($"You saved the money for {daysTotal} days."); }
        }
    }
}
