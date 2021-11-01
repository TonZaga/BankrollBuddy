using System;
using System.IO;
using System.Runtime.InteropServices;

namespace BankrollBuddy
{
    class Program
    {

        [DllImport("kernel32.dll", ExactSpelling = true)]

        private static extern IntPtr GetConsoleWindow();

        private static IntPtr ThisConsole = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int HIDE = 0;

        private const int MAXIMIZE = 3;

        private const int MINIMIZE = 6;

        private const int RESTORE = 9;

        public static void Main(string[] args)
        {
            ShowWindow(ThisConsole, MAXIMIZE);
            
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
            GetInfo();
            MainMenu();
            Console.ReadLine();
        }

        public static string firstName { get; set; }

        public static int bankroll { get; set; }

        public static void GetInfo()
        {
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your starting bankroll?");
            var starting = Console.ReadLine();
            try
            {
                bankroll = Convert.ToInt32(starting);
            }
            catch (FormatException)
            {
                Console.WriteLine("Amount that you entered is not valid.  Please try again.");
                GetInfo();
            }
        }
        public static bool MainMenu()
        {
            Console.WriteLine("\r\nBankroll Buddy menu");
            Console.WriteLine($"Hello, {firstName}. Your bankroll is set to ${bankroll}");
            Console.WriteLine("\r\nChoose an option:");
            Console.WriteLine("1) Enter a session");
            Console.WriteLine("2) Recommended stake based on bankroll");
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