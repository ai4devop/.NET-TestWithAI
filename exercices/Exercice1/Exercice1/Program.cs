using System.Text;
using System.Text.RegularExpressions;

namespace Exercice1
{
    public class StringHelper
    {
        public static void Main()
        {
        }

        public static bool IsPalindrome(string? str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length == 1)
            {
                return true;
            }
            if (str[0] != str[^1])
            {
                return false;
            }

            return IsPalindrome(str.Substring(1, str.Length - 2));
        }

        public static bool IsAnagram(string? str1, string? str2)
        {
            if (string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2))
            {
                return false;
            }
            char[] a1 = str1.ToLower().ToArray();
            char[] a2 = str2.ToLower().ToArray();
            Array.Sort(a1);
            Array.Sort(a2);
            return a1.SequenceEqual(a2);
        }

        public static string? ToCamelCase(string? input)
        {
            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            string wordsBeforeSplit = input.Trim().ToLower();
            string[] words = Regex.Split(wordsBeforeSplit, "\\s+");
            StringBuilder camelCase = new StringBuilder();

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    camelCase.Append(char.ToUpper(word[0]))
                        .Append(word.Substring(1));
                }
            }

            return camelCase.ToString();
        }


    }
}


