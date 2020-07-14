﻿using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteHUDNoHeart : AbstractSprite
    {
        public SpriteHUDNoHeart(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            Rows = 1;
            Columns = 1;
        }
    }
}