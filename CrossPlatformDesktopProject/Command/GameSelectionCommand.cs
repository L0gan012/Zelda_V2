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
            //Starts Classic Game
            //if ()
            {
              Game1.Instance.State = new StateInLevel();
            }

        }
    }
}
