namespace Sprint2
{
    public class MoveDownCommand : ICommand
    {

        public MoveDownCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.state is StateInLevel)
            {
                Game1.Instance.Link.MoveDown();
            }
        }
    }
}