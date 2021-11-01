using System;

namespace BankrollBuddy
{
    class Program
    {
        public static void Main(string[] args)
        {
            string title = @"


    $$$$$$$\                      $$\                           $$\ $$\       $$$$$$$\                  $$\       $$\           
    $$  __$$\                     $$ |                          $$ |$$ |      $$  __$$\                 $$ |      $$ |          
    $$ |  $$ | $$$$$$\  $$$$$$$\  $$ |  $$\  $$$$$$\   $$$$$$\  $$ |$$ |      $$ |  $$ |$$\   $$\  $$$$$$$ | $$$$$$$ |$$\   $$\ 
    $$$$$$$\ | \____$$\ $$  __$$\ $$ | $$  |$$  __$$\ $$  __$$\ $$ |$$ |      $$$$$$$\ |$$ |  $$ |$$  __$$ |$$  __$$ |$$ |  $$ |
    $$  __$$\  $$$$$$$ |$$ |  $$ |$$$$$$  / $$ |  \__|$$ /  $$ |$$ |$$ |      $$  __$$\ $$ |  $$ |$$ /  $$ |$$ /  $$ |$$ |  $$ |
    $$ |  $$ |$$  __$$ |$$ |  $$ |$$  _$$<  $$ |      $$ |  $$ |$$ |$$ |      $$ |  $$ |$$ |  $$ |$$ |  $$ |$$ |  $$ |$$ |  $$ |
    $$$$$$$  |\$$$$$$$ |$$ |  $$ |$$ | \$$\ $$ |      \$$$$$$  |$$ |$$ |      $$$$$$$  |\$$$$$$  |\$$$$$$$ |\$$$$$$$ |\$$$$$$$ |
    \_______/  \_______|\__|  \__|\__|  \__|\__|       \______/ \__|\__|      \_______/  \______/  \_______| \_______| \____$$ |
                                                                                                                      $$\   $$ |
                                                                                                                      \$$$$$$  |
                                                                                                                       \______/ 

";
            Console.WriteLine(title);
            getInfo();
            MainMenu();
        }
        public static void getInfo()
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your starting bankroll?");
            var starting = Console.ReadLine();
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
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Bankroll Buddy menu");
            Console.WriteLine("\r\nChoose an option:");
            Console.WriteLine("1) Reverse String");
            Console.WriteLine("2) Remove Whitespace");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                  //ReverseString();
                    return true;
                case "2":
                    //RemoveWhitespace();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
    }
}