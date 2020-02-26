using System.Linq;

namespace StrongPassword
{
    class Program
    {
        static int minimumNumber(int n, string password)
        {
            var numbers = "0123456789";
            var lowerCase = "abcdefghijklmnopqrstuvwxyz";
            var upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var specialCharacters = "!@#$%^&*()-+";

            int countNumbers = 0;
            int countLowerCase = 0;
            int countUpperCase = 0;
            int countSpecialCharacters = 0;

            foreach (var p in password)
            {
                if (numbers.Contains(p)) countNumbers++;
                if (lowerCase.Contains(p)) countLowerCase++;
                if (upperCase.Contains(p)) countUpperCase++;
                if (specialCharacters.Contains(p)) countSpecialCharacters++;
            }

            int countMissingCharachters = 0;
            if (countNumbers == 0) countMissingCharachters++;
            if (countLowerCase == 0) countMissingCharachters++;
            if (countUpperCase == 0) countMissingCharachters++;
            if (countSpecialCharacters == 0) countMissingCharachters++;

            if (n < 6)
            {
                n += countMissingCharachters;
                if (n < 6)
                {
                    return 6 - n + countMissingCharachters;
                }
            }

            return countMissingCharachters;

        }
        static void Main(string[] args)
        {
            int n = 3;

            string password = "Ab1";

            int answer = minimumNumber(n, password);
        }
    }
}
