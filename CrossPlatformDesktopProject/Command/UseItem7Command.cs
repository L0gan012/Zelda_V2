namespace Sprint2
{
    public class UseItem7Command : ICommand
    {

        public UseItem7Command()
        {
        }

        public void Execute()
        {
            Game1.Instance.Link.SecondaryItem = new UsableBow(Game1.Instance.Link, Enumerations.ArrowType.silver);
            Game1.Instance.Link.UseItem();
        }
    }
}