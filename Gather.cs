using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankrollBuddy
{
    class Gather
    {
        public static void getInfo()
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your starting bankroll?");
            string starting = Console.ReadLine();
            try
            {
            int bankroll = Convert.ToInt32(starting);
            }
            catch (FormatException)
            {
                Console.WriteLine("Amount that you entered is not valid.  Please try again.");
                getInfo();
            }
        }
    }
}
