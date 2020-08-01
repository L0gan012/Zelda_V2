namespace Sprint2
{
    public class MoveUpCommand : ICommand
    {
        public string Description { get; }

        public MoveUpCommand()
        {
            Description = StringConstants.MoveUpDescription;
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
            {
                Game1.Instance.Link.MoveUp();
            }
        }
    }
}
