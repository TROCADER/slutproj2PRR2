using System;
using System.Linq;

namespace slutproj2PRR2
{
    abstract public class Supportive : Item
    {
        public Supportive()
        {         
            Name = RandomString(10);
        }

        // Hittade denna på stackoverflow
        // --> genererar en random string utifrån bokstäverna som står listade i chars stringen
        // --> går enkelt att ändra
        public string RandomString(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
