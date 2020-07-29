using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    class MusicVolumeCommand : ICommand
    {

        private SoundVolumeMixer vol;
        public MusicVolumeCommand()
        {

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
