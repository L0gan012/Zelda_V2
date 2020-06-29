namespace Sprint2
{
    public class UseItem4Command : ICommand
    {

        public UseItem4Command()
        {
        }

        public void Execute()
        {
            Game1.Instance.Link.SecondaryItem = new UsableBoomerang(Game1.Instance.Link);
            Game1.Instance.Link.UseItem();
        }
    }
}