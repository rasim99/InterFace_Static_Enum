namespace AvarageMetodForIntArrTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array =null;
            //int[] array = { };
            int[] array = { 140, 654 };
            try
            {
                Console.WriteLine(array.CalculateAvarageOfArr());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
