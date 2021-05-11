using System;
using System.Collections.Generic;

namespace slutproj2PRR2
{
    class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            int convertedString;

            Dictionary<int, string> availableActions = new Dictionary<int, string>();
            availableActions.Add(1, "Shop");
            availableActions.Add(2, "Fighter");

            StartProgram(availableActions);

            System.Console.WriteLine("\nTo do the desired action, please enter the corresponding index key");
            convertedString = Program.CheckPlayerInput();

            // Behöver inte ha ett default-värde eftersom att jag har kod som säkerställer att den aldrig kommer komma utanför mängden switch-cases
            switch (convertedString)
            {
                case 1:
                    Shop shop = new Shop();
                    break;

                case 2:
                    Action action = new Action();
                    break;
            }
            System.Console.WriteLine("\nPress ENTER to exit program");

            Console.ReadLine();
        }
        
        // Konverterar en string till en int
        // --> om den lyckas så returneras stringen
        // --> om inte så ber den användaren att mata in en ny string
        // --> detta är då denna metod ska användas för att konvertera en användarinput
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

        // Kollar om användaren har skrivit ne ett giltigt alternativ
        // --> hämtar användarinput samt använder sig av StringToInt metoden för att konvertera stringen till en int
        // --> det är int:en som används för att göra kontrollen om användarens input är giltig
        public static int CheckPlayerInput()
        {
            string playerInput = Console.ReadLine().Trim();
            int convertedString = StringToInt(playerInput);

            // Har inte behövt göra koden dynamisk eftersom att alla gånger den referesras till så handlar det om nummren 1 och 2
            // --> däremot kan jag ändra om så att metoden hämtar in en int-array eller int-lista och därefter kollar med värdena i den
            while (convertedString != 1 && convertedString != 2)
            {
                System.Console.WriteLine("The chosen action does not exist.\nPlease try again.");

                playerInput = Console.ReadLine().Trim();
                convertedString = Program.StringToInt(playerInput);
            }

            return convertedString;
        }
        
        // Skriver ut alla objekt i ett Dictionary
        // --> används bara i början, därav namnet StartProgram
        // Kan inte användas lika väl i butiken då det finns mer information att skriva ut
        private static void StartProgram(Dictionary<int, string> actions)
        {
            foreach (int key in actions.Keys)
            {
                Console.WriteLine(key + ": " + actions[key]);
            }
        }
    }
}
