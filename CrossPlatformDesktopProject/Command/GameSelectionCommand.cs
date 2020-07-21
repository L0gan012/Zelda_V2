using System;

namespace Sprint2
{
    class GameSelectionCommand : ICommand
    {
        public GameSelectionCommand()
        {
        }

        public void Execute()
        {
            Game1.Instance.State = new StateInLevel();
        }
    }
}
