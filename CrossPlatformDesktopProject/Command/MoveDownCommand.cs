namespace Sprint2
{
    public class MoveDownCommand : ICommand
    {

        public MoveDownCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
            {
                Game1.Instance.Link.MoveDown();
            }
        }
    }
}