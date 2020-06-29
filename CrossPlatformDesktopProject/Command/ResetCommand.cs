namespace Sprint2
{
    public class ResetCommand : ICommand
    {

        public ResetCommand()
        {

        }

        public void Execute()
        {
            Game1.Instance.Link = new Link();
        }
    }
}
