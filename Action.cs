using System;
using System.Collections.Generic;

namespace slutproj2PRR2
{
    public class Action
    {
        // private List<string> actions = new List<string>() {"Punch", "Kick"};
        private Character fighterCharacter = new Fighter();

        private Dictionary<int, string> actions = new Dictionary<int, string>();
        private List<string> listOfActions = new List<string>() {"Punch", "Kick"};

        private string playerInput;
        private int convertedString;

        public Action()
        {
            for (int i = 0; i < listOfActions.Count; i++)
            {
                actions.Add(i, listOfActions[i]);
            }

            System.Console.WriteLine("These are the things you can choose between:\n");

            foreach (int key in actions.Keys)
            {
                Console.WriteLine(key + ": " + actions[key]);
            }

            System.Console.WriteLine("To do the desired action, please enter the corresponding index key");
        }

        private void CheckPlayerInput()
        {
            playerInput = Console.ReadLine().Trim();
            convertedString = Program.StringToInt(playerInput);
        }
    }
}
