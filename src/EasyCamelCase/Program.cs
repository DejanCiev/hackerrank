using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyCamelCase
{
    class Program
    {
        static int Camelcase(string s)
        {
            List<string> words = new List<string>();
            StringBuilder word = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    words.Add(word.ToString());
                    word = new StringBuilder();
                    word.Append(s[i]);
                }
                else
                {
                    word.Append(s[i]);
                }
            }
            words.Add(word.ToString());

            return words.Count();
        }
        static void Main(string[] args)
        {
            string s = "saveChangesInTheEditor";

            int result = Camelcase(s);
        }
    }
}
