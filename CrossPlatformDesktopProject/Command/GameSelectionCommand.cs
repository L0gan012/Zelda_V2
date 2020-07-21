using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;

namespace Sprint2
{
    class GameSelectionCommand : ICommand
    {
        StateGameTypeSelection gameSelection;
        public GameSelectionCommand()
        {
            gameSelection = new StateGameTypeSelection(Game1.Instance.State);
        }

        public void Execute()
        {
            
            //Starts Classic Game
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
              Game1.Instance.State = new StateInLevel();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Tab))
            {
                StateGameTypeSelection.vector = new Vector2(0, 0);
            }


        }
    }
}
