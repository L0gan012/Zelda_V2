namespace Sprint2
{
    public class MoveUpCommand : ICommand
    {
 
        public MoveUpCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.state is StateInLevel)
            {
                Game1.Instance.Link.MoveUp();
            }
        }
    }
}
