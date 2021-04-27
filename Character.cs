using System;

namespace slutproj2PRR2
{
    public class Character : Shared
    {
        private int hp = 100;
        private int xp = 0;
        private int lvl = 1;

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
                }
            }
        }

        public int Xp
        {
            get
            {
                return hp;
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
        }
    }
}
