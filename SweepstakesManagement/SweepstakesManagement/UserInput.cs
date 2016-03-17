using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManagement
{
    class UserInput
    {
        public UserInput()
        {
            
        }

        public string CollectUserName()
        {
            string name;
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            return name;
        }

        public string CollectUserPhoneNumber()
        {
            string phonenumber;
            Console.WriteLine("Please enter your phone number 'XXX-XXX-XXXX':");
            phonenumber = Console.ReadLine();
            return phonenumber;
        }
    }
}
