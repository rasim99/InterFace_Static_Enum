namespace UserTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                User user = new User(RegistrationMonth.May, "Lorem", "Ipsum", "34REc56164OP@");
                user.GetDetails();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("--------------------------------------------------------------------------------");

            try
            {
                User user2 = new User(RegistrationMonth.May, "Lorem2", "Ipsum2", "RT231554POU");
                user2.GetDetails();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("--------------------------------------------------------------------------------");

            try
            {
                User user3 = new User(RegistrationMonth.Dekabr, "Lorem3", "Ipsum3", "123WEQR756%");
                user3.GetDetails();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            } 
              Console.WriteLine("--------------------------------------------------------------------------------");

            try
            {
                User user4 = new User(RegistrationMonth.Sentyabr, "Lorem4", "Ipsum4", "ACLP12KDFBV09!");
                user4.GetDetails();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
              Console.WriteLine("--------------------------------------------------------------------------------");

            try
            {
                User user5 = new User(RegistrationMonth.Aprel, "Lorem5", "Ipsum5", "RGUHT859FF598#");
                user5.GetDetails();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
