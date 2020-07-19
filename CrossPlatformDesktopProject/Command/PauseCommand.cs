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
            if (Game1.Instance.state is StateInLevel)
            {
                Game1.Instance.state.Pause();
                Console.WriteLine("Paused!");
            }
            else
            {
                Game1.Instance.state.UnPause();
                Console.WriteLine("Unpaused!");
            }
            
        }
    }
}
