namespace Sprint2
{
    public class UseItem5Command : ICommand
    {

        public UseItem5Command()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.state is StateInLevel)
            {
                Game1.Instance.Link.SecondaryItem = new UsableMagicBoomerang(Game1.Instance.Link);
                Game1.Instance.Link.UseItem();
            }
        }
    }
}