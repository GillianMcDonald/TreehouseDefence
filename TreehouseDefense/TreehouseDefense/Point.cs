using System;

namespace TreehouseDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X + "," + Y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point))
            {
                return false;
            }

            Point that = obj as Point;

            return this.X == that.X && this.Y == that.Y;
        }

        //above we determine in the point objects are equal.  if they are we want the unique hashtag assigned to all objects to be equal      //too.  we get a warning if we set equaly with hascode and vice versa.  we can only return a single integer as the hashcode. In
        //order to get a unique as possible hashcode we have to do something to the number, simply adding isn't unique enough so we take  
        //the hashcode they've already been assigned and multiply it by one of them before adding to the other. 
        public override int GetHashCode()
        {
            return X.GetHashCode() * 31 + Y.GetHashCode();
        }

        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}

////previous itteration
//using System;

//namespace TreehouseDefense
//{
//    //this is a class for pinpointing points on the map so we can track our towers and invaders
//    class Point
//    {
//        //this declares the variables X and Y (for points on the map) making them public files so anyone can access the information
//        //but they are readonly so can't be changed once the instance has been created 
//        public readonly int X;
//        public readonly int Y;

//        // this is the constuctor, two integer parameters need to be passed when the constructor / method is called 
//        public Point(int x, int y)
//        {
//            X = x;
//            Y = y;
//        }

//        //this is a method telling us the distance  between the point object the distanceTo method is being called
//        //on and the x & y coordinates passed in
//        public int DistanceTo(int x, int y)
//        {
//            int xDiff = X - x;
//            int yDiff = Y - y;

//            int xDiffSquared = xDiff * xDiff;
//            int yDiffSquared = yDiff * yDiff;

//            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
//        }

//        //this is an overload method, meaning there are two methods with the same name but that accept different parameters
//        //this is a method that returns the distance from one point to another point
//        public int DistanceTo(Point point)
//        {
//            return DistanceTo(point.X, point.Y);
//        }
//    }

//}