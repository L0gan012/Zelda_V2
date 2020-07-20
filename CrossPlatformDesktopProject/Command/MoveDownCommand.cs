namespace Sprint2
{
    public class MoveDownCommand : ICommand
    {

        public MoveDownCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateInLevel)
            {
                Game1.Instance.Link.MoveDown();
            }
        }
    }
}