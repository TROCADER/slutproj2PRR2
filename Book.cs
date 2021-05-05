using System;

namespace slutproj2PRR2
{
    public class Book : Supportive
    {
        // Genererar ett pris, deklarerar ett namn samt vad för sorts föremål 
        // --> namnet är det som användaren skriver in i början av när Shop-klassen instanseras
        public Book(string playerInput)
        {
            Cost = Program.random.Next(20, 101);

            // Skriver över det tidigare genererade namnet
            // --> är på detta viset för att en annan klass ska kunna använda samma grund
            Name = playerInput;

            TypeOf = "Book";
        }
    }
}
