using System;

namespace SeparateTheNumbers
{
    class Program
    {
        static void separateNumbers(string s)
        {


        }
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                separateNumbers(s);
            }

            Console.ReadKey();
        }
    }
}
