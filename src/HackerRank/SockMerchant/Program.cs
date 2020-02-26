using System;
using System.Collections.Generic;

namespace SockMerchant
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            int count = 0;
            List<int> list = new List<int>(ar);
            for (int i = 0; i < n; i++)
            {
                if (ar[i] != 0)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (ar[j] != 0)
                        {
                            if (ar[i] == ar[j])
                            {
                                ar[i] = 0;
                                ar[j] = 0;
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);
            Console.ReadKey();
        }
    }
}
