namespace Sprint2
{
    public class ResetCommand : ICommand
    {

        public ResetCommand()
        {

        }

        public void Execute()
        {
            if (Game1.Instance.state is StateInLevel)
            {
                Game1.Instance.Link = new Link();
            }
        }
    }
}
