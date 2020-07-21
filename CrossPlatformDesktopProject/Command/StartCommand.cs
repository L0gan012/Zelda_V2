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
            Game1.Instance.State = new StateInLevel();
        }
    }
}
