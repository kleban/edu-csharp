using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsPalindrome2
{
    public static class StringExtension
    {
        public static bool IsPalindrome(this string text) 
        {
            char[] chars = text.Reverse().ToArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (text[i] != chars[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static string RemoveSpaces(this string text)
        {
            var newText = text.Replace(" ", string.Empty);
            return newText;
        }

    }
}
