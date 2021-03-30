using System;

namespace slutproj2PRR2
{
    public class Book
    {
        public int Cost {get; set;}
        public string Info {get; set;}

        public Book(string playerInput)
        {
            Cost = Program.random.Next(1, 101);
            Info = playerInput;
        }
    }
}
