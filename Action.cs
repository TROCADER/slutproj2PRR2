using System;
using System.Threading;
using System.Collections.Generic;

namespace slutproj2PRR2
{
    public class Action : Shared
    {
        private Character fighterCharacter = new Fighter();

        private Dictionary<int, string> actions = new Dictionary<int, string>();
        private List<string> listOfActions = new List<string>() { "Punch", "Kick" };
        private List<string> commonFrases = new List<string>() { "The fighter recieved a ", " and took some damage." };

        private int convertedString;

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



        private void PunchAction()
        {
            System.Console.WriteLine("The fighter recieved a punch and took some damage.");

            RandomizeXp(1, 3, 10, 16);
            fighterCharacter.TakeDmg(random.Next(1, 10));
        }

        private void KickAction()
        {
            System.Console.WriteLine(commonFrases[0] + "punch" + commonFrases[1]);

        }

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
