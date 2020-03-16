using System;
using System.Linq;

namespace DayOfTheProgrammer
{
    class Program
    {
        static string dayOfProgrammer(int year)
        {
            int[] eightMonths = new int[]
               {
                   31, 28, 31, 30, 31, 30, 31, 31
               };
            if (year >= 1700 && year <= 1917)
            {
                if (year % 4 == 0)
                {
                    eightMonths[1] = 29;
                }
            }
            else
            {
                if (year == 1918)
                {
                    eightMonths[1] -= 13;
                }
                else
                {
                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                    {
                        eightMonths[1] = 29;
                    }
                }
            }

            var day = 256 - eightMonths.Sum();
            return $"{day}.09.{year}";
        }

        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = dayOfProgrammer(year);

            Console.ReadKey();
        }
    }
}
