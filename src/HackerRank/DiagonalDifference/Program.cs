using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int diag1 = 0;
            int diag2 = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    if (i == j)
                    {
                        diag1 += arr[i][j];
                    }

                    if (i + j == arr.Count - 1)
                    {
                        diag1 += arr[i][j];
                    }
                }
            }
            return Math.Abs(diag1 - diag2);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr);
        }
    }
}
