namespace Sprint2
{
    public class MoveLeftCommand : ICommand
    {

        public MoveLeftCommand()
        {
        }

        public void Execute()
        {
            Game1.Instance.Link.MoveLeft();
        }
    }
}
