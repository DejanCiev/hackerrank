using System;

namespace Staircase
{
    class Program
    {
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j >= n - 1)
                    {
                        Console.Write("*");
                    }
                    if (i + j < n - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
            Console.ReadLine();
        }
    }
}
