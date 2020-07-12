namespace Sprint2
{
    public class UseItem3Command : ICommand
    {

        public UseItem3Command()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.state is StateInLevel)
            {
                Game1.Instance.Link.SecondaryItem = new UsableLadder(Game1.Instance.Link);
                Game1.Instance.Link.UseItem();
            }
        }
    }
}