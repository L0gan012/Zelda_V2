namespace Sprint2
{
    public class MoveDownCommand : ICommand
    {
        public string Description { get; }

        public MoveDownCommand()
        {
            Description = StringConstants.MoveDownDescription;
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
            {
                Game1.Instance.Link.MoveDown();
            }
        }
    }
}