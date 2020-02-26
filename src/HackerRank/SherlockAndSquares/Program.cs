using System;

namespace SherlockAndSquares
{
    internal class Program
    {
        private static int Squares(int a, int b)
        {
            int countSquares = 0;
            for (int i = a; i <= b; i++)
            {
                int temp = (int)Math.Sqrt(i);

                if (temp * temp == i)

                {
                    countSquares++;
                    i += temp * 2;
                }
            }
            return countSquares;
        }

        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] ab = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(ab[0]);

                int b = Convert.ToInt32(ab[1]);
                _ = Squares(a, b);
            }
        }
    }
}