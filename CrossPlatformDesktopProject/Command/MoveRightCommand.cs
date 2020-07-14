namespace Sprint2
{
    public class MoveRightCommand : ICommand
    {

        public MoveRightCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.state is StateInLevel)
            {
                Game1.Instance.Link.MoveRight();
            }
        }
    }
}