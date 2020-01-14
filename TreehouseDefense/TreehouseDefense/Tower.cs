using System;

namespace TreehouseDefense
{
    class Tower
    { // a protected property should start with an upper case letter.  it's made a readonly property by only giving it a 
      //getter, it's initialised to the number assigned. 
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;


        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        private bool IsSuccessfulShot()
        {
            return Random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(IInvader[] invaders)
        {
            foreach (IInvader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader at " + invader.Location);
                        }
                    }

                    else
                    {
                        Console.WriteLine("Shot at and missed an invader");
                    }
                    break;

                }
            }
        }

    }
}


////previous itteration
//using System;

//namespace TreehouseDefense
//{

//    class Tower
//    {
//        //sets a private constant integer variable called _range set to 1
//        private const int _range = 1;

//        //sets a private constant integer variable called _power set to 1
//        private const int _power = 1;

//        //sets a private constant double variable called _accuracy set to 0.75
//        private const double _accuracy = .75;

//        //sets a private static readonly variable called _random of Class type Random - an inbuilt class name which when called as a function using the 
//        //() creates a new random number 
//        private static readonly Random _random = new Random();

//        //sets a private readonly variable called _location of type MapLocation 
//        private readonly MapLocation _location;

//        //this is the constructor for a Tower which takes location as a parameter which is of type MapLocation
//        public Tower(MapLocation location)
//        {
//            _location = location;
//        }

//        //this is a method expecting a boolean return.  if random.NextDouble() (which is a function generating the next random number) is less
//        //than accuracy then it returns true 
//        public bool IsSuccessfulShot()
//        {
//            return _random.NextDouble() < _accuracy;
//        }

//        //this is a method whithout a return which takes an array of invaders as a parameter.  
//        public void FireOnInvaders(Invader[] invaders)
//        {
//            //this is a foreach loop which cycles through every invader in the Invader array
//            foreach (Invader invader in invaders)
//            {
//                //these are nested if statements 
//                //the parameters of this are: if an invader is active and the location is in range of the invader
//                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
//                {
//                    //if the IsSuccessfulShot returns true
//                    if (IsSuccessfulShot())
//                    {
//                        //decrease invaders health by the amount store in power and log it 
//                        invader.DecreaseHealth(_power);
//                        Console.WriteLine("Shot at and hit an invader!");

//                        //self explanatory
//                        if (invader.IsNeutralized)
//                        {
//                            Console.WriteLine("Invader Neutralized!");
//                        }

//                    }

//                    else
//                    {
//                        Console.WriteLine("Shot at and missed an invader :(");
//                    }

//                    break;
//                }
//            }
//        }



//    }

//}


