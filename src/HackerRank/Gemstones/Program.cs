using System;
using System.Linq;

namespace Gemstones
{
    class Program
    {
        static int gemstones(string[] arr)
        {
            var pivot = arr[0].ToCharArray().Distinct();
            int countGemstones = 0;

            foreach (var c in pivot)
            {
                int counter = 1;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i].Contains(c))
                    {
                        counter++;
                    }
                }

                if (counter == arr.Length)
                {
                    countGemstones++;
                }
            }

            return countGemstones;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string arrItem = Console.ReadLine();
                arr[i] = arrItem;
            }

            int result = gemstones(arr);


            Console.ReadKey();
        }
    }
}
