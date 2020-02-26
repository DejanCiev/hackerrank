using System;
using System.Text;

namespace SuperReducedString
{
    class Program
    {
        static String superReducedString(String s)
        {
            bool flagReduced = false;
            StringBuilder sb = new StringBuilder(s);
            while (!flagReduced)
            {
                flagReduced = true;
                for (int i = 0; i < sb.Length; i++)
                {
                    if (i + 1 < sb.Length && sb[i] == sb[i + 1])
                    {
                        sb.Remove(i, 2);
                        flagReduced = false;
                    }
                }
            }

            if (sb.Length > 0)
            {
                return sb.ToString();
            }
            return "Empty String";
        }

        static void Main(string[] args)
        {
            String result = superReducedString("baab");
            Console.ReadKey();
        }
    }
}
