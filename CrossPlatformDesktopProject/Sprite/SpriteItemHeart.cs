﻿using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteItemHeart : AbstractAnimatedSprite
    {
        public SpriteItemHeart(Texture2D texture)
        {
            Texture = texture;
            Rows = 1;
            Columns = 2;
            CurrentFrame = 0;
            CurrentTick = 0;
            TotalFrames = Rows * Columns;
            TicksPerFrame = 16;
        }
    }
}
