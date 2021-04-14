using System;

namespace slutproj2PRR2
{
    public class BattleAxe : Weapon
    {
        private string[] randomNames = {"Name1", "Name2", "Name3", "Name3"};

        public BattleAxe()
        {
            Name = randomNames[random.Next(0, randomNames.Length)];

            if (isSpecial == true)
            {
                System.Console.WriteLine("This weapon is special, and the cost of the item is increased");

                Cost *= (int)1.2;
            }
        }
    }
}
