namespace Sprint2
{
    public class UseItem6Command : ICommand
    {

        public UseItem6Command()
        {
        }

        public void Execute()
        {
            Game1.Instance.Link.SecondaryItem = new UsableBow(Game1.Instance.Link, Enumerations.ArrowType.wooden);
            Game1.Instance.Link.UseItem();
        }
    }
}