namespace Sprint2
{
    public class UseItem2Command : ICommand
    {

        public UseItem2Command()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.state is StateInLevel)
            {
                //Game1.Instance.Link.SecondaryItem = new UsableBlueCandle(Game1.Instance.Link);
                Game1.Instance.Link.UseItem();
            }
        }
    }
}