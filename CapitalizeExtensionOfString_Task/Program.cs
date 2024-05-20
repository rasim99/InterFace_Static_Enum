using System.Text;

namespace CapitalizeExtensionOfString_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string word = "      ";
            //string word = "";
            //string word = null;
            string word = "salam         dunya     2024";
            try
            {
                Console.WriteLine(word.CapitalizedString());

            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);

            }
        }
    }
}
