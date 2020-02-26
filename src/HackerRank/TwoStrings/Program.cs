using System.Linq;

namespace TwoStrings
{
    class Program
    {
        static string twoStrings(string s1, string s2)
        {

            var result = s1.Intersect(s2);
            if (result.Count() > 0)
            {
                return "YES";

            }
            return "NO";
        }
        static void Main(string[] args)
        {
        }
    }
}
