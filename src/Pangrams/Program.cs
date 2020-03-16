using System;
using System.Linq;

namespace Pangrams
{
    class Program
    {
        static string pangrams(string s)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();

            foreach (var alpha in alphabet)
            {
                if (!s.ToLower().Contains(alpha))
                {
                    return "not pangram";
                }
            }

            return "pangram";
        }
        static void Main(string[] args)
        {
            string result = pangrams("We promptly judged antique ivory buckles for the prize");

            Console.ReadKey();
        }
    }
}
