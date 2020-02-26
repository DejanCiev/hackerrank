using System;

namespace BreakingTheRecords
{
    class Program
    {
        static int[] breakingRecords(int[] scores)
        {
            int minScore = scores[0], maxScore = scores[0];
            int countMinScore = 0, countMaxScore = 0;
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > maxScore)
                {
                    countMaxScore++;
                    maxScore = scores[i];
                }
                if (scores[i] < minScore)
                {
                    countMinScore++;
                    minScore = scores[i];
                }
            }
            return new int[] { countMaxScore, countMinScore };
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            int[] result = breakingRecords(scores);
            Console.ReadKey();
        }
    }
}
