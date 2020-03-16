using System;

namespace FindDigits
{
    internal class Program
    {
        private static int FindDigits(int n)
        {
            int pom = n;
            int count = 0;
            while (pom > 0)
            {
                int digit = pom % 10;
                if (digit > 0 && n % digit == 0)
                {
                    count++;
                }

                pom /= 10;
            }
            return count;
        }

        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                _ = FindDigits(n);
            }
            Console.ReadKey();
        }
    }
}