namespace Sprint2
{
    public class ExitCommand : ICommand
    {
        public string Description { get; }

        public ExitCommand()
        {
            Description = StringConstants.ExitDescription;
        }

        public void Execute()
        {
            Game1.Instance.Quit();
        }
    }
}
