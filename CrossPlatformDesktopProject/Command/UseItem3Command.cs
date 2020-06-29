namespace Sprint2
{
    public class UseItem3Command : ICommand
    {

        public UseItem3Command()
        {
        }

        public void Execute()
        {
            Game1.Instance.Link.SecondaryItem = new UsableLadder(Game1.Instance.Link);
            Game1.Instance.Link.UseItem();
        }
    }
}