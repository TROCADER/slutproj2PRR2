using System;

namespace slutproj2PRR2
{
    public class Character
    {
        // Variabler som denna klass använder sig av
        private int hp = 100;
        private int xp = 0;
        private int lvl = 1;

        public bool isDead = false;

        // Propertys för att få publika variabler utan att användare eller liknande ska kunna sabotera/misslyckas
        // --> mer av en fail-safe

        // Denna property skiljer sig från de andra då denna deklarerar karaktären som död ifall att Hp skulle nå eller under stiga 0 i värde
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
                if (hp <= 0)
                {
                    hp = 0;

                    System.Console.WriteLine("Hp less than 0, the character is now declared as dead");
                    isDead = true;
                }
            }
        }

        public int Xp
        {
            get
            {
                return xp;
            }
            set
            {
                xp = value;
                if (xp < 0)
                {
                    xp = 0;
                }
            }
        }

        public int Lvl
        {
            get
            {
                return lvl;
            }
            set
            {
                lvl = value;
                if (lvl < 1)
                {
                    lvl = 1;
                }
            }
        }

        // Anvsarar för att karaktären tar skada
        // --> minskar Hp med hur mycket som karaktären skadas med, tas emot som int-parameter
        // --> denna informationen skriva även ut så att användaren kan se vad som hände
        public void TakeDmg(int input)
        {
            hp -= input;

            System.Console.WriteLine("The character took some damage\nThe character took: " + input + " damage");
            System.Console.WriteLine("The chacter has: " + hp + " hp remaining");
        }
    }
}
