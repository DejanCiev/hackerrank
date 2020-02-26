using System;

namespace AppendAndDelete
{
    class Program
    {
        static string appendAndDelete(string s, string t, int k)
        {
            int sLength = s.Length;
            int tLenght = t.Length;
            int minLength = sLength > tLenght ? tLenght : sLength;
            int commonLength = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (s[i] == t[i])
                {
                    commonLength++;
                }
                else
                {
                    break;
                }
            }

            if ((s.Length + t.Length - 2 * commonLength) > k)
            {
                return "No";
            }
            //CASE B
            else if ((s.Length + t.Length - 2 * commonLength) % 2 == k % 2)
            {
                return "Yes";
            }
            //CASE C
            else if ((s.Length + t.Length - k) < 0)
            {
                return "Yes";
            }
            //CASE D
            else
            {
                return "No";
            }

        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = appendAndDelete(s, t, k);

            Console.ReadKey();
        }
    }
}
