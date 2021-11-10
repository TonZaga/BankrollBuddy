using System;
using System.Runtime.InteropServices;

namespace BankrollBuddy
{
    public class Program
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
            MainMenu();
        }

        public static bool MainMenu()
        {
            Console.WriteLine("\r\nTrack your poker sessions with Bankroll Buddy!");
            Console.WriteLine("\r\nChoose an option:");
            Console.WriteLine("1) Enter a session");
            Console.WriteLine("2) Bankroll breakdown");
            Console.WriteLine("3) Recommended stake");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    SessionInfo.GetSession();
                    return true;
                case "2":
                    SessionInfo.Bankroll();
                    return true;
                case "3":
                    SessionInfo.Stakes();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }
    }
}