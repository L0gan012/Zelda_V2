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
            if (Game1.Instance.State is StateClassicGame)
            {
                Game1.Instance.State.Pause();
                Console.WriteLine("Paused!");
            }
            else
            {
                Game1.Instance.State.UnPause();
                Console.WriteLine("Unpaused!");
            }
            
        }
    }
}
