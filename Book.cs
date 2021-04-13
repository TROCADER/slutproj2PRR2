using System;

namespace slutproj2PRR2
{
    public class Book : Item
    {
        public Book(string playerInput)
        {
            Cost = random.Next(21, 101);
            Name = playerInput;

            TypeOf = "Book";
        }
    }
}
