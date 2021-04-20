using System;

namespace slutproj2PRR2
{
    public class Potion : Supportive
    {
        public Potion()
        {
            Cost = random.Next(1, 51);

            TypeOf = "Potion";
        }
    }
}
