using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Collections.Generic;
using CsvHelper.Configuration;
using System.Linq;

namespace BankrollBuddy
{
    public class SessionInfo
    {
        public static string location { get; set; }
        public static string date { get; set; }
        public static double buyIn { get; set; }
        public static double cashOut { get; set; }
        public static string answer { get; set; }

        public static void GetSession()
        {
            Console.Write("\r\nWhere did you play? ");
            location = Console.ReadLine();
            Console.Write("\r\nWhat date did you play (mm/dd/yyyy format)? ");
            date = Console.ReadLine();
            DateTime newDate;
            try
            {
                newDate = DateTime.Parse(date);
            }
            catch (FormatException)
            {
                Console.WriteLine("Valid date/format not entered.  Please try again.");
                return;
            }
            
            Console.Write("\r\nHow much did you buy in for? $");
            double buyIn = Convert.ToDouble(Console.ReadLine());
            Console.Write("\r\nHow much did you cash out with? $");
            double cashOut = Convert.ToDouble(Console.ReadLine());

            var sessions = new List<Session>()
                {
                    new Session() {Location = location, Date = date, BuyIn = buyIn, CashOut = cashOut, Profit = (cashOut-buyIn) },
                };

            bool fileExist = File.Exists("Sessions.csv");
            if (!fileExist)
            {
                var csvPath = Path.Combine(Environment.CurrentDirectory, $"Sessions.csv");
                using (var streamWriter = new StreamWriter(csvPath))
                {
                    using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                    {
                        csvWriter.WriteRecords(sessions);
                    }
                }
            }
            else
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    // Don't write the header again.
                    HasHeaderRecord = false,
                };
                using (var stream = File.Open("Sessions.csv", FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(sessions);
                }
            }

            Console.Write("\r\nWould you like to add another entry (Y or N)? ");
            answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "Y")
            {
                GetSession();
            }
            else
            {
                Program.MainMenu();
            }
        }

        public static void Bankroll()
        {
            using (var reader = new StreamReader("Sessions.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var sessions = csv.GetRecords<Session>();
                double buyIns = sessions.Sum(s => s.BuyIn); 
                double profits = sessions.Sum(s => s.Profit);
                double total =  profits + buyIns;
                Console.WriteLine($"\r\nYour total buy-ins are ${buyIns}");
                Console.WriteLine($"\r\nYour total profit is ${profits}");
                Console.WriteLine($"\r\nYour current bankroll is ${total}");
                Program.MainMenu();
            }
        }
    }

}


