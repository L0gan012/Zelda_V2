namespace Sprint2
{
    public class MoveRightCommand : ICommand
    {
        public string Description { get; }

        public MoveRightCommand()
        {
            Description = StringConstants.MoveRightDescription;
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
            {
                Game1.Instance.Link.MoveRight();
            }
        }
    }
}