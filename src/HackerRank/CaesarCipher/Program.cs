using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static string caesarCipher(string s, int k)
        {
            StringBuilder sb = new StringBuilder();
            int newValue = 0;
            k = k % 26;
            foreach (var c in s)
            {
                if (char.IsLetter(c))
                {
                    newValue = c + k;
                    if (char.IsUpper(c))
                    {
                        //upper
                        if (!('Z' >= newValue && newValue >= 'A'))
                        {
                            int difference = newValue - 'Z';
                            newValue = 'A' + difference - 1;
                        }
                    }
                    else
                    {
                        //lower
                        if (!('z' >= newValue && newValue >= 'a'))
                        {
                            int difference = newValue - 'z';
                            newValue = 'a' + difference - 1;
                        }
                    }
                    sb.Append((char)newValue);
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = caesarCipher(s, k);

            Console.ReadKey();
        }
    }
}
