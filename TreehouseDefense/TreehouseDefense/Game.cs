using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new[] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                );



                IInvader[] invaders =
                {
                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new StrongInvader(path),
                    new BasicInvader(path),
                    new ResurrectingInvader(path)
                };

                Tower[] towers = {
                    new Tower(new MapLocation(1, 3, map)),
                    new PowerfulTower(new MapLocation(3, 3, map)),
                    new LongrangeTower(new MapLocation(4, 4, map)),
                    new AccurateTower(new MapLocation(5, 3, map))
                };

                Level leve1 = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = leve1.Play();

                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }
        }
    }
}


////previous itteration
//using System;

//namespace TreehouseDefense
//{
//    class Game
//    {   //this is the entry point (main file) which runs first, taking all the incformation it needs from the other classes set out in different files 
//        public static void Main()
//        {
//            // this creates an instance of map using the class written out in Map.cs
//            Map map = new Map(8, 5);

//            try
//            {   //this is creating the Path for the invaders calling the constructor in the Path class and passing in an array of MapLocations
//                Path path = new Path(
//                  new[] {
//                  new MapLocation(0, 2, map),
//                  new MapLocation(1, 2, map),
//                  new MapLocation(2, 2, map),
//                  new MapLocation(3, 2, map),
//                  new MapLocation(4, 2, map),
//                  new MapLocation(5, 2, map),
//                  new MapLocation(6, 2, map),
//                  new MapLocation(7, 2, map),
//                        }
//                  );

//                //this is creating our invaders calling the constructor in the Invader class and creating 4 instances 
//                Invader[] invaders =
//                   {
//                   new Invader(path),
//                   new Invader(path),
//                   new Invader(path),
//                   new Invader(path)
//                   };

//                //this is creating our towers calling the constructor in the Towers class and creating 3 instances 
//                Tower[] towers =
//                    {
//                    new Tower(new MapLocation(1, 3, map)),
//                    new Tower(new MapLocation(3, 3, map)),
//                    new Tower(new MapLocation(5, 3, map))
//                    };

//                //this is creating our Level and passing in our invaders.  not typically how it's done 
//                 Level level = new Level(invaders)
//                    {
//                        Towers = towers
//                    };

//                //playerwon is a boolean whcih calls the function level.Play()
//                bool playerWon = level.Play();

//                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));

//            }

//            //order of exceptions is important.  Put the most general (closest to system.Exception) last and the least general first
//            // also if building in preparation and don't have an instance of that exception yet, remove ex from parameter until used 
//            catch (OutOfBoundsException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            catch (TreehouseDefenseException)
//            {
//                Console.WriteLine("Unhandled TreehouseDefenseException");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Unhandled Exception: " + ex);
//            }
//        }
//    }
//}