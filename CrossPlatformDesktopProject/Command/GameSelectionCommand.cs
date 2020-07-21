using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
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
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
              Game1.Instance.State = new StateInLevel();
            }

            //Changes selection for game wanted
            if (Keyboard.GetState().IsKeyDown(Keys.Tab))
            {               
                StateGameTypeSelection.vector = new Vector2(540, 300);
            }


        }
    }
}
