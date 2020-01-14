namespace TreehouseDefense
{
    class FastInvader : Invader
    {
        //this is override so when it's called it uses the fastinvador version of stepsize rather than normal invader
        protected override int StepSize { get; } = 2;

        public override int Health { get; protected set; } = 2;

        public FastInvader(Path path) : base(path)
        { }

    }

}
