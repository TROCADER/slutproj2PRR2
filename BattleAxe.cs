using System;

namespace slutproj2PRR2
{
    public class BattleAxe : Weapon
    {
        private string[] randomNames = new string[100];

        public BattleAxe()
        {
            Name = randomNames[random.Next(0, randomNames.Length)];

            for (int i = 0; i < randomNames.Length; i++)
            {
                // randomNames[i] = i;
            }

            if (isSpecial == true)
            {
                System.Console.WriteLine("This weapon is special, and the cost of the item is increased");

                Cost *= (int)1.2;
            }
        }
    }
}
