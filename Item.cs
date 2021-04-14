using System;

namespace slutproj2PRR2
{
    public class Item : Extra
    {
        public int Cost {get; set;}
        public string Name {get; set;}
        protected int Power {get; set;}

        protected bool deadly;

        private string typeOf;
        public string TypeOf
        {
            get
            {
                return typeOf;
            }

            set
            {
                typeOf = value;
            }
        }

        public Item()
        {

        }
    }
}
