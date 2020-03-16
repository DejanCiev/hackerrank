using System;

namespace MarsExploration
{
    class Program
    {
        static int marsExploration(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 3 == 0)
                {
                    if (s[i] != 'S') count++;
                }
                if (i % 3 == 1)
                {
                    if (s[i] != 'O') count++;
                }
                if (i % 3 == 2)
                {
                    if (s[i] != 'S') count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int result = marsExploration(s);
            Console.ReadKey();
        }
    }
}
