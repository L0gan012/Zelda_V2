namespace Sprint2
{
    public class UseSecondaryItemCommand : ICommand
    {
        public string Description { get; }

        public UseSecondaryItemCommand()
        {
            Description = StringConstants.UseSecondaryDescription;
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
            {
                Game1.Instance.Link.UseItem();
            }
        }
    }
}