using Microsoft.Xna.Framework.Input;
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
                Game1.Instance.Controllers[0].UpdateCommand(Keys.F, new NullCommand());
                Game1.Instance.Controllers[0].UpdateCommand(Keys.B, new NullCommand());
            }
            else
            {
                Game1.Instance.State.UnPause();
                Game1.Instance.Controllers[0].UpdateCommand(Keys.F, new GameSettingsCommand());
                Game1.Instance.Controllers[0].UpdateCommand(Keys.B, new GameSettingsCommand());
            }

        }
    }
}
