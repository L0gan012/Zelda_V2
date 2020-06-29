namespace Sprint2
{
    public class UseItem1Command : ICommand
    {

        public UseItem1Command()
        {
        }

        public void Execute()
        {
            Game1.Instance.Link.SecondaryItem = new UsableBomb(Game1.Instance.Link);
            Game1.Instance.Link.UseItem();
        }
    }
}