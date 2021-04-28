using System;

namespace slutproj2PRR2
{
    public class Fighter : Character
    {
        private float xpToLevelUp = 1;
        private float previousLvl = 1;

        public void XpChange(int input)
        {
            if (input > 0)
            {
                if (Lvl < 100)
                {
                    Xp += input;
                    Lvl = (int)(1 + Xp / xpToLevelUp);

                    if ((previousLvl - Lvl) >= 1)
                    {
                        xpToLevelUp += random.Next(1, 6);

                        System.Console.WriteLine("Character leveled up");

                        previousLvl = Lvl;
                    }
                }

                else
                {
                    System.Console.WriteLine("Already max lvl, can not recive more xp");
                }
            }

            else
            {
                System.Console.WriteLine("You cannot lose xp");
            }
        }
    }
}
