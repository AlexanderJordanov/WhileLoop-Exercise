using System;

namespace Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            string input = Console.ReadLine();

            while (input != "Going home")
            {
                int currentSteps = int.Parse(input);
                totalSteps += currentSteps;
                if (totalSteps > 10000) { break; }
                input = Console.ReadLine();
            }
            if (totalSteps < 10000)
            {
                int lastSteps = int.Parse(Console.ReadLine());
                totalSteps += lastSteps;
            }
            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000-totalSteps} more steps to reach goal.");
            }
        }
    }
}
