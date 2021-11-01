using System;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace BankrollBuddy
{
    public class SessionInfo
    {
        public static string location { get; set; }

        public static string date { get; set; }

        public static int buyIn { get; set; }

        public static int cashOut { get; set; }

        public static void GetSession()
        {
            Console.WriteLine("\r\nWhere did you play?");
            location = Console.ReadLine();
            Console.WriteLine("\r\nWhat date did you play? *mm/dd/yyyy format*");
            date = Console.ReadLine();
            Console.WriteLine("\r\nHow much did you buy in for?");
            var sBuyIn = Console.ReadLine();
            buyIn = Convert.ToInt32(sBuyIn);
            Console.WriteLine("\r\nHow much did you cash out with?");
            var sCashOut = Console.ReadLine();
            cashOut = Convert.ToInt32(sCashOut);
            Program.MainMenu();
        }
    }
}


