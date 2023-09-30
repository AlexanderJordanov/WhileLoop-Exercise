using System;
using System.ComponentModel.Design;

namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();

            string lastProblemName = "";
            int totalProblems = 0;
            int totalBadGrades = 0;
            int sumGrades = 0;
            bool hasFailed = false;
         
            while (problemName != "Enough")
            {
                int problemGrade = int.Parse(Console.ReadLine());

                if (problemGrade <= 4)
                {
                    totalBadGrades++;
                    if (totalBadGrades == badGrades) { hasFailed = true; break; }
                }

                totalProblems++;
                sumGrades += problemGrade;
            
                lastProblemName = problemName;
                problemName = Console.ReadLine();
                

            }

            if (hasFailed)
            {
                Console.WriteLine($"You need a break, {totalBadGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {1.0 * sumGrades / totalProblems:f2}");
                Console.WriteLine($"Number of problems: {totalProblems}");
                Console.WriteLine($"Last problem: {lastProblemName}");
            }
        }
    }
}
