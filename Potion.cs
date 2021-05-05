using System;

namespace slutproj2PRR2
{
    public class Potion : Supportive
    {
        // Genererar ett pris samt deklarerar vad för sorts objekt det är
        public Potion()
        {
            Cost = Program.random.Next(1, 51);

            TypeOf = "Potion";
        }
    }
}
