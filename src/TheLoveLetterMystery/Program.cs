using System;
using System.Text;

namespace TheLoveLetterMystery
{
    class Program
    {
        static int theLoveLetterMystery(String s)
        {
            StringBuilder sb = new StringBuilder(s);
            int sum = 0;
            for (int i = 0; i < sb.Length / 2; i++)
            {
                if (sb[i] != sb[sb.Length - 1 - i])
                {
                    sum += Math.Abs(sb[i] - sb[sb.Length - 1 - i]);
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int result = theLoveLetterMystery("cba");
            Console.ReadKey();
        }
    }
}
