namespace Infrastructure.EventsBus.Signals
{
    public struct BotChoose
    {
        private readonly int _choose;

        public int Choose => _choose;
        public BotChoose(int rndChoose)
        {
            _choose = rndChoose;
        }
    }
}