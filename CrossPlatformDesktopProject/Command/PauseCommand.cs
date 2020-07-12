namespace Sprint2
{
    class PauseCommand : ICommand
    {
        public PauseCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.state.GetType() == typeof(StatePaused))
            {
                Game1.Instance.state.UnPause();
            }
            else
            {
                Game1.Instance.state.Pause();
            }
            
        }
    }
}
