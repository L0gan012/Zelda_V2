using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    class GameMusicSelectionCommand : ICommand
    {
        private List<Vector2> selectionPosition;
        private int listCounter;
        private SoundVolumeMixer vol;
        public GameMusicSelectionCommand()
        {
            selectionPosition = new List<Vector2>();
            selectionPosition.Add(new Vector2(200, 70));
            selectionPosition.Add(new Vector2(280, 90));
            selectionPosition.Add(new Vector2(370, 110));
            selectionPosition.Add(new Vector2(400, 130));
            selectionPosition.Add(new Vector2(250, 150));
            selectionPosition.Add(new Vector2(320, 170));
            selectionPosition.Add(new Vector2(670, 190));
            selectionPosition.Add(new Vector2(280, 210));
            selectionPosition.Add(new Vector2(200, 230));
            selectionPosition.Add(new Vector2(570, 250));
            selectionPosition.Add(new Vector2(570, 270));
            selectionPosition.Add(new Vector2(260, 50));
            listCounter = 0;
            vol = new SoundVolumeMixer();
        }

        public void Execute()
        {



            if (Keyboard.GetState().IsKeyDown(Keys.PageUp))
            {
                vol.MediaVolUp();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.PageDown))
            {
                vol.MediaVolDown();
            }


            //Mutes music
            if (Keyboard.GetState().IsKeyDown(Keys.M))
            {
                vol.MediaMute();
            }


        }
    }
}
