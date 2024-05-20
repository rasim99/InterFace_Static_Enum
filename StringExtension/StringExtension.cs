using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    internal  static class StringExtension
    {
        public static bool IsPalidromeString(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new Exception("Wrong! any word or phrase should have been entered");
            }
            string reverseStr = new string(str.Reverse().ToArray());
                if (str.ToLower().Trim() == reverseStr.ToLower().Trim())
                {
                    return true;
                }
                return false;
        }
    }
}
