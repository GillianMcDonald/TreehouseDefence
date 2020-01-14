using System;

namespace TreehouseDefense
{
    class LongrangeTower : Tower
    { // a protected property should start with an upper case letter.  it's made a readonly property by only giving it a 
      //getter, it's initialised to the number assigned. 
        protected override int Range { get; } = 2;
        //        protected virutal int Power { get; } = 1;
        //        protected virutal double Accuracy { get; } = .75;
        public LongrangeTower(MapLocation location) : base(location)
        { }
    }

}