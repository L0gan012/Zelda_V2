namespace Sprint2
{
    public class UseSecondaryItemCommand : ICommand
    {

        public UseSecondaryItemCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateInLevel)
            {
                Game1.Instance.Link.UseItem();
            }
        }
    }
}