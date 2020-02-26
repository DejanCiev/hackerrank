using System;

namespace Kangaroo
{
    class Program
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v2 - v1 != 0)
            {
                var x = (x1 - x2) / (v2 - v1);

                if (x > 0)
                {
                    var kangaroo1 = x1 + x * v1;
                    var kangaroo2 = x2 + x * v2;

                    if (kangaroo1 == kangaroo2)
                    {
                        return "YES";
                    }
                }
            }

            return "NO";
        }

        static void Main(string[] args)
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = kangaroo(x1, v1, x2, v2);

            Console.ReadKey();

        }
    }
}
