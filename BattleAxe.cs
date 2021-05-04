using System;

namespace slutproj2PRR2
{
    public class BattleAxe : Weapon
    {
        // En string-array som används för att generera ett "namn", vilket är mer av ett ID än ett namn
        private string[] randomNames = new string[100];

        // Konstruktor som genererar namnet samt kontrollerar ifall vapnet är speciellt
        // --> om den är speciell så blir dess genererade pris högre
        public BattleAxe()
        {
            for (int i = 0; i < randomNames.Length; i++)
            {
                randomNames[i] = "Axe " + i;
            }

            Name = randomNames[random.Next(0, randomNames.Length)];

            if (isSpecial == true)
            {
                Cost *= (int)1.2;
            }
        }
    }
}
