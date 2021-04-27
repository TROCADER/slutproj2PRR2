using System;

namespace slutproj2PRR2
{
    public class Fighter : Character
    {
        private float xpToLevelUp;

        public void XpChange(int input)
        {
            if (input > 0)
            {
                Xp += input;

                Lvl = (int) (1 + Xp / xpToLevelUp);
                xpToLevelUp += 1;
            }

            else
            {
                System.Console.WriteLine("You cannot lose xp");
            }
        }
    }
}
