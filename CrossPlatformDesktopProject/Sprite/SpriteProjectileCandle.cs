﻿using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteProjectileCandle : AbstractAnimatedSprite
    {
        public SpriteProjectileCandle(Texture2D texture)
        {
            Texture = texture;
            Rows = 1;
            Columns = 2;
            CurrentFrame = 0;
            CurrentTick = 0;
            TotalFrames = Rows * Columns;
            TicksPerFrame = 8;
        }
    }
}
