using System;

namespace slutproj2PRR2
{
    public class Item : Extra
    {
        public int Cost {get; set;}
        public string Name {get; set;}
        public string TypeOf {get; set;}
        
        public int IncreaseCost(int a)
        {


            return Cost;
        }
    }
}
