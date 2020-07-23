namespace Sprint2
{
    public class MoveRightCommand : ICommand
    {

        public MoveRightCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
            {
                Game1.Instance.Link.MoveRight();
            }
        }
    }
}