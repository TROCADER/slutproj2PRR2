using System;

namespace slutproj2PRR2
{
    abstract public class Item : Shared
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
