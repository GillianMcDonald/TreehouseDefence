namespace TreehouseDefense
{//creating a global variable for Random.  
    static class Random
    {
        private static System.Random _random = new System.Random();

        public static double NextDouble()
        {
            return _random.NextDouble();
        }
    }

}