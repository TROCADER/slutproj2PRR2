using System.Linq.Expressions;
using System.Collections.Generic;
using System;

namespace slutproj2PRR2
{
    abstract public class Item
    {
        // Dena klass har bara variabler som är relaterade till alla saker
        public int Cost { get; set; }
        public string Name { get; set; }
        public string TypeOf { get; set; }
    }
}
