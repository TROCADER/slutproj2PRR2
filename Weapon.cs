using System;

namespace slutproj2PRR2
{
    public class Weapon : Item
    {
        protected bool isSpecial;

        public Weapon()
        {
            Cost = random.Next(50, 101);

            TypeOf = "Weapon";

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
