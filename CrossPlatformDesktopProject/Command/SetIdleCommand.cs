namespace Sprint2
{
    public class SetIdleCommand : ICommand
    {

        public SetIdleCommand()
        {

        }

        public void Execute()
        {
            if (Game1.Instance.State is StateInLevel)
            {
                Game1.Instance.Link.SetIdle();
            }
        }
    }
}