using System;

namespace slutproj2PRR2
{
    public class Potion : Item
    {
        public Potion(string playerInput)
        {
            Cost = random.Next(1, 101);
            Name = playerInput;
        }
    }
}
