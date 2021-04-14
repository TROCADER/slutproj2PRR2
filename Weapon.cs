using System;

namespace slutproj2PRR2
{
    public class Weapon : Item
    {
        protected bool isSpecial;

        public Weapon()
        {
            deadly = true;

            Cost = random.Next(50, 101);
            Power = random.Next(20, 31);

            if (random.Next(0, 2) == 2)
            {
                isSpecial = true;
            }

            else
            {
                isSpecial = false;
            }
        }
    }
}
