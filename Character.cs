using System;

namespace slutproj2PRR2
{
    public class Character : Shared
    {
        private int hp = 100;
        private int xp = 0;
        private int lvl = 1;

        public bool isDead = false;

        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
                if (hp < 0)
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

        public void TakeDmg(int input)
        {
            hp -= input;

            System.Console.WriteLine("The character took some damage\nThe character took: " + input + " damage");
            System.Console.WriteLine("The chacter has: " + hp + " hp remaining");
        }
    }
}
