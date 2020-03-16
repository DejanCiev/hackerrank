using System;
using System.Collections.Generic;

namespace GameOfThronesFirst
{
    class Program
    {
        static string gameOfThrones(string s)
        {
            Dictionary<char, int> keyValues = new Dictionary<char, int>();

            foreach (var c in s)
            {
                if (keyValues.ContainsKey(c))
                {
                    keyValues[c]++;
                }
                else
                {
                    keyValues.Add(c, 1);
                }
            }
            if (keyValues.Count % 2 == 0)
            {
                return "YES";
            }

            return null;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = gameOfThrones(s);

            Console.ReadKey();
        }
    }
}
