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
            selectionPosition.Add(new Vector2(300, 150));
            selectionPosition.Add(new Vector2(200, 100));
            selectionPosition.Add(new Vector2(300, 50));
            listCounter = 0;
        }

        public void Execute()
        {

            Game1.Instance.Controllers[0].UpdateCommand(Keys.B, new GameSettingsCommand());

            //Selects Music
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && StateMusicSelection.vector.Y == 50)
            {
                SoundManager.Instance.PlayGerudoValleyOOTMusic();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && StateMusicSelection.vector.Y == 100)
            {
                SoundManager.Instance.PlayLostWoodsOOTMusic();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && StateMusicSelection.vector.Y == 150)
            {
                SoundManager.Instance.PlayPrincessZeldaTimeOOTMusic();
            }

            //Changes selection for music wanted
            if (Keyboard.GetState().IsKeyDown(Keys.Tab))
            {
                if(listCounter == selectionPosition.Count) {listCounter = 0;}
                StateMusicSelection.vector = selectionPosition[listCounter];
                listCounter++;
            }


        }
    }
}
