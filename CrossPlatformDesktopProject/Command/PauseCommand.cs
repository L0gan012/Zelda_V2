using System;

namespace Sprint2
{
    class PauseCommand : ICommand
    {
        public PauseCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.state is StatePaused)
            {
                Game1.Instance.state.UnPause();
                Console.WriteLine("Unpaused!");
            }
            else
            {
                Game1.Instance.state.Pause();
                Console.WriteLine("Paused!");
            }
            
        }
    }
}
