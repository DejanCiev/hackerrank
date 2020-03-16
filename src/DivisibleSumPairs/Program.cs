using System;

namespace DivisibleSumPairs
{
    class Program
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            string[] nk = "5 2".Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll("5 9 10 7 4".Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = divisibleSumPairs(n, k, ar);

            Console.ReadKey();
        }
    }
}
