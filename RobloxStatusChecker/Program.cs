using System;
using System.Net;

namespace RobloxStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Roblox Status Checker");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("Checking Roblox Status... ");

                bool isOnline = true;

                try
                {
                    using (var client = new WebClient())
                    using (client.OpenRead("https://www.roblox.com"))
                    {
                        // do nothing
                    }
                }
                catch
                {
                    isOnline = false;
                }

                try
                {
                    using (var client = new WebClient())
                    using (client.OpenRead("https://web.roblox.com"))
                    {
                        // do nothing
                    }
                }
                catch
                {
                    isOnline = false;
                }

                if (isOnline)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Online");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Offline");
                }

                Console.ResetColor();

                Console.WriteLine();
                Console.Write("Checking again in ");

                for (int i = 5; i > 0; i--)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}
