using System;

namespace AppleAndOrange
{
    class Program
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int countApples = 0;
            int countOrange = 0;


            foreach (var apple in apples)
            {
                int position = a + apple;
                if (position >= s && t >= position)
                {
                    countApples++;
                }
            }
            foreach (var orange in oranges)
            {
                int position = b + orange;
                if (position >= s && t >= position)
                {
                    countOrange++;
                }
            }

            Console.WriteLine(countApples);
            Console.WriteLine(countOrange);
        }
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));
            countApplesAndOranges(s, t, a, b, apples, oranges);

            Console.ReadKey();
        }
    }
}
