using System;
using System.Threading;
using System.Collections.Generic;

namespace slutproj2PRR2
{
    class Program
    {
        static void Main(string[] args)
        {
            int convertedString;

            Dictionary<int, string> availableActions = new Dictionary<int, string>();
            availableActions.Add(1, "Shop");
            availableActions.Add(2, "Do an action");

            StartProgram(availableActions);

            System.Console.WriteLine("To do the desired action, please enter the corresponding index key");
            convertedString = Program.CheckPlayerInput();

            switch (convertedString)
            {
                case 1:
                    Shop shop = new Shop();
                    break;

                case 2:
                    Action action = new Action();
                    break;

                default:
                    System.Console.WriteLine("The desired action does not exist");
                    break;
            }

            Console.ReadLine();
        }

        private static void Load()
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
                System.Console.WriteLine("Please enter a number. Try again.");
                playerInput = Console.ReadLine().Trim();
                sucess = int.TryParse(playerInput, out result);
            }

            return result;
        }

        public static int CheckPlayerInput()
        {
            string playerInput = Console.ReadLine().Trim();
            int convertedString = StringToInt(playerInput);

            while (convertedString != 1 && convertedString != 2)
            {
                System.Console.WriteLine("The chosen action does not exist");

                playerInput = Console.ReadLine().Trim();
                convertedString = Program.StringToInt(playerInput);
            }

            return convertedString;
        }

        private static void StartProgram(Dictionary<int, string> actions)
        {
            System.Console.WriteLine("Hello and welcome to the program");

            // Load();

            foreach (int key in actions.Keys)
            {
                Console.WriteLine(key + ": " + actions[key]);
            }
        }
    }
}
