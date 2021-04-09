using System;
using System.Collections.Generic;
using System.Linq;

namespace slutproj2PRR2
{
    class Program
    {
        public static Random random = new Random();
        static Queue<string> playerNames = new Queue<string>();
        static HashSet<string> playerInputs = new HashSet<string>();
        static Dictionary<string, int> itemDict = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            Book[] books = new Book[10];
            string playerInput;
            int playerMoney = 0;
            int indexInt = 0;

            for (int i = 0; i < books.Length; i++)
            {
                System.Console.WriteLine("What should be the name of the book");
                playerInput = Console.ReadLine().Trim();

                while (playerInput == "" || playerInputs.Contains(playerInput))
                {
                    System.Console.WriteLine("Name is either already used, or not valid, please try again");
                    playerInput = Console.ReadLine().Trim();
                }

                playerInputs.Add(playerInput);
                playerNames.Enqueue(playerInput);
            }

            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new Book(playerNames.Dequeue());

                itemDict.Add(books[i].Name, books[i].Cost);
            }

            foreach (string key in itemDict.Keys)
            {
                playerMoney += itemDict.ElementAt(indexInt).Value;
                indexInt++;
            }

            indexInt = 0;
            while (playerMoney > 0)
            {
                System.Console.WriteLine("This are the items we sell:");
                foreach (string key in itemDict.Keys)
                {
                    System.Console.WriteLine(indexInt + ": Name: " + key + " | Price: " + itemDict[key]);
                    indexInt++;
                }

                indexInt = 0;

                System.Console.WriteLine("Which do you want to buy?\nType the indexnumber of item");
                System.Console.WriteLine("You have: " + playerMoney + " money left to spend");
                playerInput = Console.ReadLine().Trim();

                int convertedString = StringToInt(playerInput);

                playerMoney -= itemDict.ElementAt(convertedString).Value;
                itemDict.Remove(itemDict.ElementAt(convertedString).Key);
                System.Console.WriteLine("Money left: " + playerMoney);
            }

            System.Console.WriteLine("You are out of money, press ENTER to exit");

            Console.ReadLine();
        }

        private static int StringToInt(string playerInput)
        {
            int result = 0;
            bool sucess = int.TryParse(playerInput, out result);

            while (sucess != true)
            {
                playerInput = Console.ReadLine().Trim();
                sucess = int.TryParse(playerInput, out result);
            }

            return result;
        }
    }
}
