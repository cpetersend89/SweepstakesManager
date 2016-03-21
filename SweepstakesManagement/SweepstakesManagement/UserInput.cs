using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManagement
{
    public class UserInput
    {
        public UserInput()
        {
            
        }

        public static string CollectUserName()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            return name;
        }

        public static string CollectUserPhoneNumber()
        {
            Console.WriteLine("Please enter your phone number 'XXX-XXX-XXXX':");
            string phonenumber = Console.ReadLine();
            return phonenumber;
        }
    }
}
