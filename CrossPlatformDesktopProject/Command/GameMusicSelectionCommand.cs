using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    class GameMusicSelectionCommand : ICommand
    {
        private List<Vector2> selectionPosition;
        private int listCounter;
        public GameMusicSelectionCommand()
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
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && StateSetting.vector.Y == 100)
            {
                SoundManager.Instance.PlayGerudoValleyOOTMusic();
            }

         
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
