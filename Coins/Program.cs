using System;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resto = double.Parse(Console.ReadLine());
            double remain = Math.Floor(resto * 100);
            int sumCoins = 0;

            while (remain > 0)
            {
                if (remain >= 200) 
                {
                    sumCoins++;
                    remain -= 200;
                }
                else if (remain >= 100)
                {
                    sumCoins++;
                    remain -= 100;
                }
                else if (remain >= 50)
                {
                    sumCoins++;
                    remain -= 50;
                }
                else if (remain >= 20)
                {
                    sumCoins++;
                    remain -= 20;
                }
                else if (remain >= 10)
                {
                    sumCoins++;
                    remain -= 10;
                }
                else if (remain >= 5)
                {
                    sumCoins++;
                    remain -= 5;
                }
                else if (remain >= 2)
                {
                    sumCoins++;
                    remain -= 2;
                }
                else if (remain >= 1)
                {
                    sumCoins++;
                    remain -= 1;
                }
            }
            Console.WriteLine(sumCoins);
        }
    }
}
