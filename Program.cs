using System;
using System.Threading;
using System.Collections.Generic;

namespace slutproj2PRR2
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Hello and welcome to the program");
            // System.Console.WriteLine("Currently only the shop is available, but there might be more in the future");

            // Load();

            // Shop shop = new Shop();

            Action action = new Action();

            Console.ReadLine();
        }

        static void Load()
        {
            System.Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("Loading, please wait...");

            string[] dots = new string[5];

            for (int i = 0; i < dots.Length; i++)
            {
                dots[i] = ".";
                Console.WriteLine(dots[i]);
                Thread.Sleep(500);
            }

            Console.Clear();
        }

        public static int StringToInt(string playerInput)
        {
            int result = 0;
            bool sucess = int.TryParse(playerInput, out result);

            while (sucess != true)
            {
                System.Console.WriteLine("Du har inte skrivit ett giltigt tal, försök igen.");
                playerInput = Console.ReadLine().Trim();
                sucess = int.TryParse(playerInput, out result);
            }

            return result;
        }
    }
}
