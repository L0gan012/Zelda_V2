using Microsoft.Xna.Framework.Input;
using System;

namespace Sprint2
{
    class StartCommand : ICommand
    {
        public StartCommand()
        {
        }

        public void Execute()
        {
            Game1.Instance.State = new StateOptionSelection(Game1.Instance.State);
            Game1.Instance.Controllers[0].UpdateCommand(Keys.Space, new GameSelectionCommand());
        }
    }
}
