﻿using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteProjectileAquamentus : AbstractAnimatedSprite
    {
        public SpriteProjectileAquamentus(Texture2D texture)
        {
            Texture = texture;
            Rows = 1;
            Columns = 4;
            CurrentFrame = 0;
            CurrentTick = 0;
            TotalFrames = Rows * Columns;
            TicksPerFrame = 2;
        }
    }
}
