namespace TreehouseDefense
{
    class ShieldedInvader : Invader
    {
        public override int Health { get; protected set; } = 2;


        public ShieldedInvader(Path path) : base(path)
        { }

        //the override word below shows that in this class this is the DecreaseHealth method that should be used, not the method of the
        //same name in the invader (parent) class.  
        public override void DecreaseHealth(int factor)
        { //if the random number is under .5
            if (Random.NextDouble() < .5)
            {  //use the base class DecreaseHealth method to decrease health by the factor 
                base.DecreaseHealth(factor);
            }
            else
            {
                System.Console.WriteLine("Shot at a shielded invader but it sustained no damage");
            }
        }

    }

}