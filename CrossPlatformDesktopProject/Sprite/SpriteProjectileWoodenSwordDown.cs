﻿using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteProjectileWoodenSwordDown : AbstractAnimatedSprite
    {
        public SpriteProjectileWoodenSwordDown(Texture2D texture)
        {
            Texture = texture;
            Rows = 1;
            Columns = 4;
            CurrentFrame = 0;
            CurrentTick = 0;
            TotalFrames = Rows * Columns;
            TicksPerFrame = Constant.TicksPerFrameSwordProjectiles;
        }
    }
}
