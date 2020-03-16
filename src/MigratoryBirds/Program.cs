using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    class Program
    {
        static int migratoryBirds(List<int> arr)
        {
            SortedDictionary<int, int> types = new SortedDictionary<int, int>();
            foreach (var a in arr)
            {
                if (types.ContainsKey(a))
                {
                    types[a] += 1;
                }
                else
                {
                    types.Add(a, 1);
                }
            }
            var maxValue = 0;
            int type = 0;

            foreach (KeyValuePair<int, int> pair in types)
            {
                if (pair.Value > maxValue)
                {
                    maxValue = pair.Value;
                    type = pair.Key;
                }
            }

            return type;
        }

        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.ReadKey();
        }
    }
}
