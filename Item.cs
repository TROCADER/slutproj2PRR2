using System;

namespace slutproj2PRR2
{
    public class Item : Extra
    {
        public int Cost {get; set;}
        public string Name {get; set;}
        public int Name2 {get; set;}

        private string typeOf = "";

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
