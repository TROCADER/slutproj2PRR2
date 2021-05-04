using System;

namespace slutproj2PRR2
{
    public class Weapon : Item
    {
        protected bool isSpecial;

        // Konstruktor som genererar ett pris och om vapnet är speciellt eller ej
        // --> "speciell-faktorn" används i vapnets riktiga klass, se BattleAxe för mer information
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
