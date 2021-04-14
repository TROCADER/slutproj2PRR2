using System;

namespace slutproj2PRR2
{
    public class Supportive : Item
    {
        public Supportive()
        {
            deadly = false;

            Power = random.Next(10, 21);
        }
    }
}
