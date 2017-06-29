namespace PlayBoxMonitor
{
    public class CreateConsoleParameters
    {
        public GameConsoleSetup Setup { get; set; }
        public int Count { get; set; }

        public CreateConsoleParameters(GameConsoleSetup setup,int count)
        {
            Setup=setup;
            Count=count;
        }

        public CreateConsoleParameters()
        {
            Setup=new GameConsoleSetup();
            Count=0;
        }
    }
}