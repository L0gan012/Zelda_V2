namespace Sprint2
{
    public class SetIdleCommand : ICommand
    {

        public SetIdleCommand()
        {

        }

        public void Execute()
        {
            if (Game1.Instance.state is StateInLevel)
            {
                Game1.Instance.Link.SetIdle();
            }
        }
    }
}