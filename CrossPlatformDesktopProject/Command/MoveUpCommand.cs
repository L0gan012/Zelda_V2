namespace Sprint2
{
    public class MoveUpCommand : ICommand
    {
 
        public MoveUpCommand()
        {
        }

        public void Execute()
        {
            Game1.Instance.Link.MoveUp();
        }
    }
}
