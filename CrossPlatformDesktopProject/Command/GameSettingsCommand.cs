using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    class GameSettingsCommand : ICommand
    {
        private List<Vector2> selectionPosition;
        private int listCounter;
        public GameSettingsCommand()
        {
            selectionPosition = new List<Vector2>();
            selectionPosition.Add(new Vector2(400, 200));
            selectionPosition.Add(new Vector2(400, 300));
            selectionPosition.Add(new Vector2(400, 100));
            listCounter = 0;
        }

        public void Execute()
        {

            //Selects Music
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && StateSetting.vector.Y == 200)
            {
              Game1.Instance.State = new StateMusicSelection();
              Game1.Instance.Controllers[0].UpdateCommand(Keys.Space, new GameMusicSelectionCommand());
              Game1.Instance.Controllers[0].UpdateCommand(Keys.Tab, new GameMusicSelectionCommand());
            }

            //Select Resolution 
            /** if (Keyboard.GetState().IsKeyDown(Keys.Space) && StateOptionSelection.vector.X == 540)
             {
                 Game1.Instance.State = new StateClassicGame();

             }

            //Selects Controls
             if (Keyboard.GetState().IsKeyDown(Keys.Space) && StateOptionSelection.vector.X == 540)
             {
                 Game1.Instance.State = new StateClassicGame();

             }**/

            //Changes selection for game wanted
            if (Keyboard.GetState().IsKeyDown(Keys.Tab))
            {
                if(listCounter == selectionPosition.Count) {listCounter = 0;}
                StateSetting.vector = selectionPosition[listCounter];
                listCounter++;
            }


        }
    }
}
