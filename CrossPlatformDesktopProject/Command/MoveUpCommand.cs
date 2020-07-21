namespace Sprint2
{
    public class MoveUpCommand : ICommand
    {
 
        public MoveUpCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
            {
                Game1.Instance.Link.MoveUp();
            }
        }
    }
}
