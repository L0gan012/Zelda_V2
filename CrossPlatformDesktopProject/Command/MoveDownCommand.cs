namespace Sprint2
{
    public class MoveDownCommand : ICommand
    {

        public MoveDownCommand()
        {
        }

        public void Execute()
        {
            Game1.Instance.Link.MoveDown();
        }
    }
}