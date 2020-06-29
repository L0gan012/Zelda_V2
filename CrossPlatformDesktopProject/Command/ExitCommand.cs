namespace Sprint2
{
    public class ExitCommand : ICommand
    {

        public ExitCommand()
        {
        }

        public void Execute()
        {
            Game1.Instance.Exit();
        }
    }
}
