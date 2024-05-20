namespace StringReverseExtensionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string word = null;
            //string word = "   ";
            string word = "bu qala dasli qala";


            try
            {
                Console.WriteLine(word.MakeReverseString());
            }
            catch (Exception x)
            {

                Console.WriteLine(x.Message); ;
            }
        }
    }
}
