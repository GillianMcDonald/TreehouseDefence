namespace TreehouseDefense
{
    //made this an abstract class so we can't instantiate an invader any more.  can only create subclasses of invader and 
    //instantiate them.  e.g. BasicInvader. we then created an IInvader file to abstract even further.  the : IInvader syntax doesn't
    //mean subclass in this instance but it implements the IInvader Interface (what the I stands for);
    abstract class Invader : IInvader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        //virtual property with only a getter which returns one (initialises to one)  read only property.
        //set to protected so invader and it's subclasses can use it but no other class can
        protected virtual int StepSize { get; } = 1;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        // True if the invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        // by making this abstract instead of virtual we're saying the health property must be overwritten in subclasses.  Abstract 
        //properties can't have implementation so we need to delete the =2 at the end which initialized it perviously 
        public abstract int Health { get; protected set; }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += StepSize;

        //want to make this method polymorphic so that any subclasses of Invader can provide their own implementations of the method.  
        //sheilded invaders should have a method for their health different to invaders health.  
        //adding virtual to the method name means subclasses can provide their own implementation of this method. 
        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            System.Console.WriteLine("Shot at and hit an invader!");
        }
    }
}



////previous itteration of code

//namespace TreehouseDefense
//{

//    class Invader
//    {
//        //this sets the variable path to private and readonly from the Path class
//        private readonly Path _path;

//        //sets a variable _pathStep to 0 initially.  so we can track how far down the path the invador goes
//        private int _pathStep = 0;

//        //the below is a property called location that is expecting a MapLocation to be returned.  the MapLocation uses the method
//        //GetLocation at from the Path class and _pathStep(variable set above).  A computed property that gets the location of the
//        //based on it's path step 
//        public MapLocation Location => _path.GetLocationAt(_pathStep);

//        //this creates a property called Health which is expecting an integer return, it has a built in getter and setter so the Health can be accessed
//        //from outside the class.  the getter can be called to get the info and change the info. the setter is private so once set
//        //it can't then be changed.  
//        public int Health { get; private set; } = 2;

//        //this is a property called HasScored which is expecting a boolean return.  It has a built in getter, the boolean return true if the
//        //_pathStep is greater or equal to the pathLength.  computed property - different syntax to location which is also a computed property. 
//        public bool HasScored { get { return _pathStep >= _path.Length; } }

//        //this is a property called IsNeutralized which is expecting a boolean return.  It returns true when Health is less than or equal to 0
//        public bool IsNeutralized => Health <= 0;

//        //this is a property called IsActive which is expecting a boolean return.  It returns true when neither IsNeutralized
//        //or HasScored is true.  
//        public bool IsActive => !(IsNeutralized || HasScored);


//        //this is the constructor for an Invader with parameter path
//        public Invader(Path path)
//        {
//            _path = path;

//        }

//        //method without return moving one step down the path when called 
//        public void Move() => _pathStep += 1;

//        //method without return decreasing health by the factor amount when called.  
//        public void DecreaseHealth(int factor)
//        {
//            Health -= factor;
//        }



//    }

//}