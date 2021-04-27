using System;
using System.Collections.Generic;

namespace slutproj2PRR2
{
    public class Action : Shared
    {
        private Character fighterCharacter = new Fighter();

        private Dictionary<int, string> actions = new Dictionary<int, string>();
        private List<string> listOfActions = new List<string>() {"Punch", "Kick"};

        private string playerInput;
        private int convertedString;
        private int xpChange;

        public Action()
        {
            for (int i = 0; i < listOfActions.Count; i++)
            {
                actions.Add(i, listOfActions[i]);
            }

            System.Console.WriteLine("These are the things you can choose between:\n");

            foreach (int key in actions.Keys)
            {
                Console.WriteLine(key + 1 + ": " + actions[key]);
            }

            System.Console.WriteLine("To do the desired action, please enter the corresponding index key");

            convertedString = CheckPlayerInput();

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
        }

        private int CheckPlayerInput()
        {
            playerInput = Console.ReadLine().Trim();
            convertedString = Program.StringToInt(playerInput);

            while (convertedString != 1 && convertedString != 2)
            {
                System.Console.WriteLine("The chosen action does not exist");

                playerInput = Console.ReadLine().Trim();
                convertedString = Program.StringToInt(playerInput);
            }

            return convertedString;
        }

        private void PunchAction()
        {
            System.Console.WriteLine("The fighter recieved a punch and took some damage.");
            System.Console.WriteLine("Got Xp");

            ((Fighter)fighterCharacter).XpChange(random.Next(10, 16));

            System.Console.WriteLine(fighterCharacter.Xp);
        }

        private void KickAction()
        {

        }
    }
}
