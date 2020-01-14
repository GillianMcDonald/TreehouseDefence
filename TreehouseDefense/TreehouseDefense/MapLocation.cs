namespace TreehouseDefense
{
    // the below creates a class called MapLocation which is extended from the Point class
    class MapLocation : Point
    {
        //the below is a method called MapLocation setting the parameters for the MapLocation class (same as for Point) and saying these are the same
        // as the point class by using the base(x, y) we're calling the base class's constructor here and giving it the parameters it needs.
        //now any MapLocation objects we create will also be Point objects.

        //mapLocation takes a third parameter which is map so it knows the size of the map and has access to it's methods / information 
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            //'this' is keyword referring to current object only.  saying if not on the map throw this exception
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(this + " is outside the boundaries of the map.");
            }
        }

        //this is a method called InRangeOf expcting a booleon return, it takes the parameters location and range, range is an integer, location is a MapLocation.
        //it returns true if the DistanceTo the location is smaller than the range.  
        // this is used by the Towers to see if they are in range of the invaders. 
        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
        //determines if this maplocation obejct is in range of the maplocation passed in 

    }

}