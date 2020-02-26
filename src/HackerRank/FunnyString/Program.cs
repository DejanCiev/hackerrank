using System;
using System.Collections.Generic;
using System.Linq;

namespace FunnyString
{
    internal class Program
    {
        private static string FunnyString(string s)
        {
            List<int> asciiOriginal = new List<int>();
            List<int> asciiReverse = new List<int>();
            asciiOriginal = s.Select(x => (int)x).ToList();
            asciiReverse = s.Select(x => (int)x).ToList();
            asciiReverse.Reverse();

            for (int i = 0; i < asciiOriginal.Count; i++)
            {
                if ((i + 1 < asciiOriginal.Count) && Math.Abs(asciiOriginal[i] - asciiOriginal[i + 1]) != Math.Abs(asciiReverse[i] - asciiReverse[i + 1]))
                {
                    return "Not Funny";
                }
            }

            return "Funny";
        }

        private static void Main(string[] args)
        {
            _ = FunnyString("acxz");

            Console.ReadKey();
        }
    }
}