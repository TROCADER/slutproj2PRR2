using System;
using System.Linq;

namespace slutproj2PRR2
{
    public class Supportive : Item
    {
        private string[] randomType = new string[10];

        public Supportive()
        {
            for (int i = 0; i < randomType.Length; i++)
            {
                randomType[i] = i.ToString();

            }
            
            Name = RandomString(randomType.Length);
        }

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
