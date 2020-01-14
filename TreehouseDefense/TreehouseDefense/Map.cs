namespace TreehouseDefense
{
    //this is a class to create the map size and has a method which access the point class to check if points are on the map
    class Map
    {
        //this declares the variables height and width making them public files so anyone can access the information
        //but they are readonly so can't be changed once the instance has been created 
        public readonly int Width;
        public readonly int Height;

        // this is the constuctor, two integer parameters need to be passed when the constructor / method is called 
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        //this is a method checking whether the 'point' is on the map
        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X < Width &&
                   point.Y >= 0 && point.Y < Height;

        }
    }

}