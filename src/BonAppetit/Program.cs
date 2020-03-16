using System;
using System.Collections.Generic;
using System.Linq;

namespace BonAppetit
{
    class Program
    {
        static void bonAppetit(List<int> bill, int k, int b)
        {
            int ba = 0, sum = 0;

            for (int i = 0; i < bill.Count; i++)
            {
                if (i != k)
                {
                    sum += bill[i];
                }
            }
            ba = sum / 2;
            if (b > ba)
            {
                Console.WriteLine(b - ba);
            }
            if (b == ba)
            {
                Console.WriteLine("Bon Appetit");
            }
        }
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
            Console.ReadKey();
        }
    }
}
