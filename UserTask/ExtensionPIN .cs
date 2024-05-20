using System;

namespace UserTask
{
    internal static class ExtensionPIN
    {
        public static bool CheckUserPin(string pin)
        {
            if (pin.Length > 6 &&!pin.Any(char.IsLower) && (pin.Any(char.IsUpper)||!pin.Any(char.IsDigit)))
            {
                return true;
            }
                //Console.WriteLine(" PIN doesnot correct entered ");
                return false;
            
        }
    }
}
