namespace TreehouseDefense
{
    class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }

        public bool IsOnPath(MapLocation location)
        {
            foreach (var pathLocation in _path)
            { //checks is the locations are the same to all intents and purpose not exactly alike as in the exact same object. 
                if (location.Equals(pathLocation))
                {
                    return true;
                }
            }
            return false;
        }
    }
}


////previous itteration
//namespace TreehouseDefense
//{
//    // this is a class for the path the invaders will take from one side of the map to the other.  They only have one possible route.  
//    class Path
//    {
//        //this is creating a private variable called _path without a current value.  Becuase it's private path is prefixed with an _
//        //and we should use the getter and setters to access the information rather than
//        //calling _path directly from elsewhere in the program.  
//        private readonly MapLocation[] _path;

//        //this is creating a variable called Length that is the path.length
//        public int Length => _path.Length;

//        //this is the constructor for Path which is using an array of MapLocations to create the path 
//        public Path(MapLocation[] path)
//        {
//            _path = path;
//        }

//        // this is a method called GetLcoationAt which takes one integer parameter called pathStep and returns a MapLocation
//        public MapLocation GetLocationAt(int pathStep)
//        {
//            //this is ternery operator (short version of if/ese) saying if pathStep is less than pathlength then do the first
//            //thing after the ? (which is move down the path) otherwise do nothing. 
//            return (pathStep < _path.Length) ? _path[pathStep] : null;
//        }


//    }

//}