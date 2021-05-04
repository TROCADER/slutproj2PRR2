using System;
using System.Threading;
using System.Collections.Generic;

namespace slutproj2PRR2
{
    public class Action : Shared
    {
        // Instanserad klass som denna klassen anvönder sig av
        private Character fighterCharacter = new Fighter();

        // Alla generiska klasser som denna klassen använder sig av
        private Dictionary<int, string> actions = new Dictionary<int, string>();
        private List<string> listOfActions = new List<string>() { "Punch", "Kick" };
        private List<string> commonFrases = new List<string>() { "The fighter recieved a ", " and took some damage." };

        // Egen varibel som denna klassen använder sig av
        private int convertedString;

        // Konstruktorn till denna klassen som anvsarar för logiken kopplad till denna klassen
        // --> är delvis uppsplittad i flera metoder för att inte verka allt för stor/tjock
        public Action()
        {
            for (int i = 0; i < listOfActions.Count; i++)
            {
                actions.Add(i, listOfActions[i]);
            }

            while (fighterCharacter.isDead == false)
            {
                System.Console.WriteLine("Fighter level: " + fighterCharacter.Lvl);
                System.Console.WriteLine("Fighter total Xp: " + fighterCharacter.Xp);

                System.Console.WriteLine("\nThese are the things you can choose between:\n");

                foreach (int key in actions.Keys)
                {
                    Console.WriteLine(key + 1 + ": " + actions[key]);
                }

                System.Console.WriteLine("To do the desired action, please enter the corresponding index key");
                convertedString = Program.CheckPlayerInput();

                switch (convertedString)
                {
                    case 1:
                        PunchAction();
                        break;

                    case 2:
                        KickAction();
                        break;

                    default:
                        System.Console.WriteLine("The requested action does not exist...\nPlease try again");
                        break;
                }

                Thread.Sleep(3000);
                Console.Clear();
            }
        }
        
        // Ansvarar för all logik som händer när fightern blir slagen
        private void PunchAction()
        {
            System.Console.WriteLine(commonFrases[0] + "punch" + commonFrases[1]);

            RandomizeXp(1, 3, 10, 16);
            fighterCharacter.TakeDmg(random.Next(1, 10));
        }

        // Ansvarar för all logik som händer när fightern blir sparkad
        private void KickAction()
        {
            System.Console.WriteLine(commonFrases[0] + "kick" + commonFrases[1]);

            RandomizeXp(1, 5, 15, 20);
            fighterCharacter.TakeDmg(random.Next(5, 10));
        }

        // Genererar Xp till fightern om den får Xp
        // --> användaren ställer in parametrar om hur stor chansen är att fightern ska kunna få Xp, samt hur mycket Xp som den får om den väl får Xp
        // --> går att ändra som så att metoden tar emot en int-array eller int-lista istället för individuella int
        // --> ansåg att det blir tydligare kod om det är separata int:s istället, så lät det vara kvar med separata int:s
        private void RandomizeXp(int randomMin, int randomMax, int xpAmountMin, int xpAmountMax)
        {
            
            if (random.Next(randomMin, randomMax) == 1)
            {
                int temp = random.Next(xpAmountMax, xpAmountMax);

                System.Console.WriteLine("The fighter recived Xp\nRecieved: " + temp + " Xp");
                ((Fighter)fighterCharacter).XpChange(temp);
            }

            else
            {
                System.Console.WriteLine("No Xp gain");
            }
        }
    }
}
