namespace StringExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string word = null;
            //string word = "       ";
            string word = "";
            string word2 = "salam";
            string word3 = "ey melek Kelem Ye";
            try
            {
                Console.WriteLine($"{word3}  is Palidrome? : " + word3.IsPalidromeString());
                Console.WriteLine($"{word2} string is Palidrome? : " + word2.IsPalidromeString());

                Console.WriteLine($"{word}  is Palidrome? : " +word.IsPalidromeString());

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
