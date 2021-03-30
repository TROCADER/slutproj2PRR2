using System;
using System.Collections.Generic;

namespace slutproj2PRR2
{
    class Program
    {
        public static Random random = new Random();


        static void Main(string[] args)
        {
            Book[] books = new Book[10];
            Queue<string> playerNames = new Queue<string>();

            System.Console.WriteLine("What should book be about?");

            string playerInput = Console.ReadLine().Trim();
            playerNames.Enqueue(playerInput);

            for (int i = 0; i < books.Length; i++)
            {
                playerInput = Console.ReadLine().Trim();
                playerNames.Enqueue(playerInput);
            }
            
            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new Book(playerInput);
            }


            System.Console.WriteLine("Welcome to shop!");
            System.Console.WriteLine("We sell this things: ");
        }
    }
}
