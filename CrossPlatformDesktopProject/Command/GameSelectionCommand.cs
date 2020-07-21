using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    class GameSelectionCommand : ICommand
    {
        private List<Vector2> selectionPosition;
        private int listCounter;
        public GameSelectionCommand()
        {
            selectionPosition = new List<Vector2>();
            selectionPosition.Add(new Vector2(540, 300));
            selectionPosition.Add(new Vector2(600, 190));
            listCounter = 0;
        }

        public void Execute()
        {
            
            //Starts Classic Game
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && StateGameTypeSelection.vector.X == 600)
            {
              Game1.Instance.State = new StateInLevel();
            }

            //Changes selection for game wanted
            if (Keyboard.GetState().IsKeyDown(Keys.Tab))
            {
                if(listCounter == selectionPosition.Count) {listCounter = 0;}
                StateGameTypeSelection.vector = selectionPosition[listCounter];
                listCounter++;
            }


        }
    }
}
