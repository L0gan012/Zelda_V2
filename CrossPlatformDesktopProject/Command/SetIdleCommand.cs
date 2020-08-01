namespace Sprint2
{
    public class SetIdleCommand : ICommand
    {

        public string Description { get; }

        public SetIdleCommand()
        {
            Description = StringConstants.SetIdleDescription;
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
            {
                Game1.Instance.Link.SetIdle();
            }
        }
    }
}