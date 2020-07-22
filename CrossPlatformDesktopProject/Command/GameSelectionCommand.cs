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
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && StateOptionSelection.vector.X == 600)
            {
              Game1.Instance.State = new StateClassicGame();
            }

            //Starts Setting
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && StateOptionSelection.vector.X == 540)
            {
                Game1.Instance.State = new StateSetting();
                Game1.Instance.Controllers[0].UpdateCommand(Keys.Space, new GameSettingsCommand());
                Game1.Instance.Controllers[0].UpdateCommand(Keys.Tab, new GameSettingsCommand());

            }

            //Changes selection
            if (Keyboard.GetState().IsKeyDown(Keys.Tab))
            {
                if(listCounter == selectionPosition.Count) {listCounter = 0;}
                StateOptionSelection.vector = selectionPosition[listCounter];
                listCounter++;
            }


        }
    }
}
