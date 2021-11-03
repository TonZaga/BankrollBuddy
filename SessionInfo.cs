using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Collections.Generic;
using CsvHelper.Configuration;

namespace BankrollBuddy
{
    public class SessionInfo
    {
        public static string location { get; set; }
        public static string date { get; set; }
        public static int buyIn { get; set; }
        public static int cashOut { get; set; }
        public static string answer { get; set; }

        public static void GetSession()
        {
            Console.WriteLine("\r\nWhere did you play?");
            location = Console.ReadLine();
            Console.WriteLine("\r\nWhat date did you play? *mm/dd/yyyy format*");
            date = Console.ReadLine();
            DateTime newDate;
            try
            {
                newDate = DateTime.Parse(date);
            }
            catch (FormatException)
            {
                Console.WriteLine("Valid date/format not entered.  Please try again.");
                
            }
            
            Console.WriteLine("\r\nHow much did you buy in for?");
            int buyIn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r\nHow much did you cash out with?");
            int cashOut = Convert.ToInt32(Console.ReadLine());

            var sessions = new List<Session>()
                {
                    new Session() {Location = location, Date = date, BuyIn = buyIn, CashOut = cashOut },
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

            Console.WriteLine("\r\nWould you like to add another entry? Y or N");
            answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "Y")
            {
                SessionInfo.GetSession();
            }
            else
            {
                Program.MainMenu();
            }
        }
    }
    internal class Session
    {
        public string Location { get; internal set; }
        public string Date { get; internal set; }
        public int BuyIn { get; internal set; }
        public int CashOut { get; internal set; }
    }
}


