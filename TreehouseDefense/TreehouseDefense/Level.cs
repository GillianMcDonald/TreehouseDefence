namespace TreehouseDefense
{
    class Level
    {
        private readonly IInvader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(IInvader[] invaders)
        {
            _invaders = invaders;
        }

        // Returns: true if the player wins, false otherwise.
        public bool Play()
        {
            // Run until all invaders are neutralized or an invader reaches the end of the path.
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                // Each tower has opportunity to fire on invaders.
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                // Count and move the invaders that are still active.
                remainingInvaders = 0;
                foreach (IInvader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }
            }

            return true;
        }
    }
}



////previous itteration
//namespace TreehouseDefense
//{
//    class Level
//    {
//        //setting a variable called _invaders which takes and array of Invader
//        private readonly Invader[] _invaders;

//        //This is an object called Towers which has automatic getter and setter methods and is an array of type Tower
//        public Tower[] Towers { get; set; }

//        //this is the constructor for Level which takes a parameter invaders which is an array of Invader
//        public Level(Invader[] invaders)
//        {
//            _invaders = invaders;
//        }

//        //returns true if the player wins, false otherwise.  most of the logic for the game
//        public bool Play()
//        {
//            //Run until all invaders are neutralized or an invader reaches the end of the path.
//            //setting a variable called reamining invaders which equals the amount of invaders in the array 
//            int remainingInvaders = _invaders.Length;

//            //while loop which runs when remaining invaders is greater than 0
//            while (remainingInvaders > 0)
//            {
//                // Each tower has an opportunity to fire on invaders
//                //a foreach loop saying for every tower that exists it can fire on the invaders 
//                foreach (Tower tower in Towers)
//                {
//                    tower.FireOnInvaders(_invaders);
//                }

//                // count and move the invaders that are still active. 
//                remainingInvaders = 0;
//                foreach (Invader invader in _invaders)
//                {
//                    if (invader.IsActive)
//                    {   //for every invader which is active, it moves.  
//                        invader.Move();

//                        //if the invader has scored the player looses so return false / game over   
//                        if (invader.HasScored)
//                        {
//                            return false;
//                        }
//                        remainingInvaders++;
//                    }

//                }
//            }//otherwise the player wins
//            return true;
//        }
//    }
//}