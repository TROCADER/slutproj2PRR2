using System;

namespace slutproj2PRR2
{
    public class Book : Item
    {
        public int Cost {get; set;}
        public string Name {get; set;}

        public Book(string playerInput)
        {
            Cost = random.Next(1, 101);
            Name = playerInput;
        }
    }
}
