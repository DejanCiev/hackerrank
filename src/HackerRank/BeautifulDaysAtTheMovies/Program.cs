using System;
using System.Text;

namespace BeautifulDaysAtTheMovies
{
    internal class Program
    {
        private static int BeautifulDays(int i, int j, int k)
        {
            int count = 0;
            for (int r = i; r <= j; r++)
            {
                var origin = r;

                var reverse = Reverse(r.ToString());
                var differnce = Math.Abs(origin - reverse);
                if (differnce % k == 0)
                {
                    count++;
                }
            }
            return count;
        }

        private static int Reverse(string number)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                sb.Append(number[i]);
            }
            return Convert.ToInt32(sb.ToString());
        }

        private static void Main(string[] args)
        {
            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);
            _ = BeautifulDays(i, j, k);

            Console.ReadKey();
        }
    }
}