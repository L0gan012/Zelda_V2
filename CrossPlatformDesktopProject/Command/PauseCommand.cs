using Microsoft.Xna.Framework.Input;
using System;

namespace Sprint2
{
    class PauseCommand : ICommand
    {
        public string Description { get; }

        public PauseCommand()
        {
            Description = StringConstants.PauseDescription;
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
            {
                Game1.Instance.State.Pause();

            }
            else
            {
                Game1.Instance.State.UnPause();

            }

        }
    }
}
