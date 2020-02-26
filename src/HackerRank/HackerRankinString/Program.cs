namespace HackerRankinString
{
    class Program
    {
        static string hackerrankInString(string s)
        {
            var pivotString = "hackerrank";

            var counterPivot = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (counterPivot < pivotString.Length && s[i] == pivotString[counterPivot])
                {
                    counterPivot++;
                }
            }
            if (counterPivot == pivotString.Length)
            {
                return "YES";
            }
            return "NO";
        }
        static void Main(string[] args)
        {
            string result = hackerrankInString("rhbaasdndfsdskgbfefdbrsdfhuyatrjtcrtyytktjjt");
            var test = "";
        }
    }
}
