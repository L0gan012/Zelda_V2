namespace Sprint2
{
    public class SetIdleCommand : ICommand
    {

        public SetIdleCommand()
        {

        }

        public void Execute()
        {
            Game1.Instance.Link.SetIdle();
        }
    }
}