using Microsoft.Xna.Framework.Media;
using System;

public class SoundVolumeMixer
{
    public SoundVolumeMixer()
    {
        MediaPlayer.Volume = 1.0f;
    }

    public void MediaMute()
    {
        MediaPlayer.Stop();
    }


    public void MediaVolUp()
    {
        if (MediaPlayer.Volume < 1.0f) { MediaPlayer.Volume += 0.1f; }
    }


    public void MediaVolDown()
    {
        if (MediaPlayer.Volume > 0f) { MediaPlayer.Volume -= 0.1f; }

    }
}
