using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace slutproj2PRR2
{
    public class Shop : Extra
    {
        private Queue<string> playerNames = new Queue<string>();
        private Queue<string> typeOfQueue = new Queue<string>();
        private HashSet<string> playerInputs = new HashSet<string>();
        private Dictionary<string, int> itemDict = new Dictionary<string, int>();

        private Book[] books = new Book[10];
        private Potion[] potions = new Potion[10];
        private BattleAxe[] battleAxes = new BattleAxe[10];

        private string playerInput;
        private int playerMoney = 0;
        private int indexInt = 0;
        private int convertedString = 0;

        public Shop()
        {
            for (int i = 0; i < books.Length + potions.Length; i++)
            {
                System.Console.WriteLine("What should be the name of the item?");
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
                typeOfQueue.Enqueue(books[i].TypeOf);
            }

            for (int i = 0; i < potions.Length; i++)
            {
                potions[i] = new Potion(playerNames.Dequeue());
                itemDict.Add(potions[i].Name, potions[i].Cost);
                typeOfQueue.Enqueue(potions[i].TypeOf);
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
                    System.Console.WriteLine(typeOfQueue.Dequeue() + ": " + indexInt + ": Name: " + key + " | Price: " + itemDict[key]);
                    indexInt++;
                }

                indexInt = 0;

                System.Console.WriteLine("Which do you want to buy?\nType the indexnumber of item");
                System.Console.WriteLine("You have: " + playerMoney + " money left to spend");
                playerInput = Console.ReadLine().Trim();

                convertedString = StringToInt(playerInput);

                playerMoney -= itemDict.ElementAt(convertedString).Value;
                itemDict.Remove(itemDict.ElementAt(convertedString).Key);
                System.Console.WriteLine("Money left: " + playerMoney);
            }

            System.Console.WriteLine("You are out of money, press ENTER to exit");

            Console.ReadLine();
        }

        private int StringToInt(string playerInput)
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
