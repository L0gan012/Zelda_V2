namespace Sprint2
{
    public class UseItem2Command : ICommand
    {

        public UseItem2Command()
        {
        }

        public void Execute()
        {
            Game1.Instance.Link.SecondaryItem = new UsableBlueCandle(Game1.Instance.Link);
            Game1.Instance.Link.UseItem();
        }
    }
}