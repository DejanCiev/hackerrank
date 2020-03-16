using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayChocolate
{
    class Program
    {
        static int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            //d sum
            //m numer of squares
            for (int i = 0; i < s.Count; i++)
            {
                int countSquares = 1;
                int sum = 0;
                for (int j = i; j < s.Count && countSquares <= m; j++)
                {
                    sum += s[j];
                    countSquares++;
                }
                if (sum == d) count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

            Console.ReadKey();
        }
    }
}
