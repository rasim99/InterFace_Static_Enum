using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace UserTask
{
    internal class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
       public RegistrationMonth RegistrationMonth { get; set; }
        private string pin;
        public string PIN { get { 
                return pin; 
            } 
            set
            {
                if (ExtensionPIN.CheckUserPin(value))
                {
                    pin = value;
                }
                else
                {
                    Console.WriteLine("wrong pin format");
                }
            }
        }
        public User(RegistrationMonth registrationMonth ,string name,string surName,string pin)
        {
            RegistrationMonth = registrationMonth;
            Name = name;
            SurName = surName;
            PIN= pin;
         
        }

        public void GetDetails()
        {
            if (PIN!=null &&ExtensionPIN.CheckUserPin(PIN))
            {
                Console.WriteLine($"User Name : {Name}  User Surname : {SurName} Registrated Month : {RegistrationMonth}");
            }
            else
            {
               throw new Exception ("pin is not correct format User cannot creatable ");

            }
        }
    }
}
