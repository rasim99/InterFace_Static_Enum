using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseExtensionTask
{
    internal static class ReverseString
    {
        public static string MakeReverseString(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new Exception("word or phrase cannot be nul or empty");
            }
            string reverseWord = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseWord += str[i];
            }
            return reverseWord;
        }
    }
}
