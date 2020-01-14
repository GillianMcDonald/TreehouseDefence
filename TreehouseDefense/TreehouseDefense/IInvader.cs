namespace TreehouseDefense
{

    //interfaces don't have constructors, like abstract classes they can't be instantiated. They don't need virutal or abstract     //modifiers or use public. keywords.  You set the setters in the subclasses  they are the recipe or what other subclasses should have. 
    //we copied all the public code from invader and tidied it up but can use a program to clean it up for you.  You can have multiple 
    //interfaces in one abstract class. 

    interface IMappable
    {
        MapLocation Location { get; }
    }

    interface IMovable
    {

        void Move();
    }

    //anything that implements IInvader, also implements Imappable and IMovable interfaces.  
    interface IInvader : IMappable, IMovable
    {

        bool HasScored { get; }

        int Health { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void DecreaseHealth(int factor);


    }

}