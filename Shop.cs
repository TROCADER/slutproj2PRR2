using System;
using System.Collections.Generic;
using System.Linq;

namespace slutproj2PRR2
{
    public class Shop
    {
        // Alla generiska klasser som används av denna klassen
        private Queue<string> playerNames = new Queue<string>();
        private Queue<string> typeOfQueue = new Queue<string>();
        private HashSet<string> playerInputs = new HashSet<string>();
        private Dictionary<string, int> itemDict = new Dictionary<string, int>();
        private List<string> itemsOwned = new List<string>();

        // Alla instanserade klasser som denna klassen använder
        private Book[] books = new Book[3];
        private Potion[] potions = new Potion[3];
        private BattleAxe[] battleAxes = new BattleAxe[3];

        // Alla egna variabler som denna klassen använder sig av
        private string playerInput;
        private int playerMoney = 0;
        private int indexInt = 0;
        private int convertedString = 0;

        // Konstruktorn för klassen som innehåller all logik kopplad till denna klassen
        // --> egentligen kanske borde ha splittat denna metod till flera mindre, men den funkar som den är, trots att den är en aning för lång
        public Shop()
        {
            Console.Clear();

            // Spelaren kan skriva in namn till alla böcker
            for (int i = 0; i < books.Length; i++)
            {
                System.Console.WriteLine("What should be the name of the book?\nAll other items will have a random name.");
                playerInput = Console.ReadLine().Trim();

                // Spelaren kan inte skriva in samma namn flera gånger
                while (playerInput == "" || playerInputs.Contains(playerInput))
                {
                    System.Console.WriteLine("Name is either already used, or not valid, please try again");
                    playerInput = Console.ReadLine().Trim();
                }
                
                // Lägger till anvöndarens input till Hashset som är en del av den lösningen som finns ovan
                playerInputs.Add(playerInput);
                playerNames.Enqueue(playerInput);
            }

            // Lägger till alla objekt in i en Dicitionary
            // --> samt till en Queue
            // Detta är långt ifrån en optimal lösning, men ville få med flera olika generiska klasser
            // Denna lösning är relativt dynamisk då man kan ändra antalet av klassen och det bör ändå funka som planerat
            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new Book(playerNames.Dequeue());
                itemDict.Add(books[i].Name, books[i].Cost);
                typeOfQueue.Enqueue(books[i].TypeOf);
            }

            for (int i = 0; i < potions.Length; i++)
            {
                potions[i] = new Potion();
                itemDict.Add(potions[i].Name, potions[i].Cost);
                typeOfQueue.Enqueue(potions[i].TypeOf);
            }

            for (int i = 0; i < battleAxes.Length; i++)
            {
                battleAxes[i] = new BattleAxe();
                itemDict.Add(battleAxes[i].Name, battleAxes[i].Cost);
                typeOfQueue.Enqueue(battleAxes[i].TypeOf);
            }

            // En ganska onödig loop där det enda som den gör är att göra så att spelaren har lika mycket pengar som allt i shoppen kostar
            // --> så att spelaren kan garanterat köpa allt
            // --> det är inte så en riktig shop fungerar, man bör inte ha råd för allt
            foreach (string key in itemDict.Keys)
            {
                playerMoney += itemDict.ElementAt(indexInt).Value;
                indexInt++;
            }

            // Konverterar Queue:n till en List för att lättare kunna skriva ut alla objekt som finns
            // --> finns säkerligen en annan bättre lösning än den nedan, men med denna fick jag med användningen av fler generiska klasser
            List<string> typeOfList = typeOfQueue.ToList();

            indexInt = 0;
            while (playerMoney > 0)
            {
                // --> denna är den lösningen jag nämnde ovan
                System.Console.WriteLine("This are the items we sell:");
                foreach (string key in itemDict.Keys)
                {
                    System.Console.WriteLine(typeOfList[indexInt] + ": " + indexInt + ": Name: " + key + " | Price: " + itemDict[key]);
                    indexInt++;
                }
                indexInt = 0;

                System.Console.WriteLine("Which do you want to buy?\nType the indexnumber of item");
                System.Console.WriteLine("You have: " + playerMoney + " money left to spend");

                playerInput = Console.ReadLine().Trim();
                convertedString = Program.StringToInt(playerInput);
                
                // Säkerställer att spelaren inte skriver in ett felaktigt indexnummer, alltså ett som inte existerar
                // Märkte att den räknar antalet Keys i ett dictionay från 1, istället för 0 som vid indexering, vilket är logiskt
                // --> för att göra så att man inte indexerar utanför alla Keys så kollar jag med 1 mindre i värde (som vid indexering)
                while (convertedString >= itemDict.Count || convertedString < 0)
                {
                    System.Console.WriteLine("You have entered an index that does not exist. Please try again.");

                    playerInput = Console.ReadLine().Trim();
                    convertedString = Program.StringToInt(playerInput);
                }

                // Rensar alla generiska klasser från det man valde att köpa
                playerMoney -= itemDict.ElementAt(convertedString).Value;
                itemsOwned.Add(itemDict.ElementAt(convertedString).Key);
                itemDict.Remove(itemDict.ElementAt(convertedString).Key);
                typeOfList.RemoveAt(convertedString);

                Console.Clear();

                System.Console.WriteLine("Current owned items by name:");
                for (int i = 0; i < itemsOwned.Count; i++)
                {
                    System.Console.WriteLine(itemsOwned[i]);
                }

                System.Console.WriteLine("\nMoney left: " + playerMoney);
            }

            System.Console.WriteLine("You are out of money");
        }
    }
}
