using System;

namespace slutproj2PRR2
{
    public class Fighter : Character
    {
        // Variabler som denna klass använder sig av
        private float xpToLevelUp = 1;
        private float previousLvl = 1;

        // Konstruktor som ansvarar för att ändra fightern:s Xp, om den väl ändras
        // --> kommer ge ERROR om man försöker ta bort Xp istället för att ge
        // --> detta ligger med mer som en fail-safe ifall användaren skulle ge fel input eller liknande, bör inte uppstå som koden är nu
        public void XpChange(int input)
        {
            if (input > 0)
            {
                if (Lvl < 100)
                {
                    Xp += input;
                    Lvl = (int)(1 + Xp / xpToLevelUp);

                    if ((previousLvl - Lvl) >= 1)
                    {
                        xpToLevelUp += random.Next(1, 6);

                        System.Console.WriteLine("Character leveled up");

                        previousLvl = Lvl;
                    }
                }

                else
                {
                    System.Console.WriteLine("Already max lvl, can not recive more xp");
                }
            }

            else
            {
                System.Console.WriteLine("You cannot lose xp");
            }
        }
    }
}
