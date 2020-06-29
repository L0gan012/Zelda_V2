﻿using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Sprite
{
    class SpriteBlockRightStatue : AbstractSprite
    {
        public SpriteBlockRightStatue(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            Rows = 1;
            Columns = 1;
        }
    }
}