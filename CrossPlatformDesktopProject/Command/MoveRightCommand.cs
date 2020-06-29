namespace Sprint2
{
    public class MoveRightCommand : ICommand
    {

        public MoveRightCommand()
        {
        }

        public void Execute()
        {
            Game1.Instance.Link.MoveRight();
        }
    }
}