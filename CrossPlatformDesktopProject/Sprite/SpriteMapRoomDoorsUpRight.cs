﻿using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteMapRoomDoorsUpRight : AbstractSprite
    {
        public SpriteMapRoomDoorsUpRight(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            Rows = 1;
            Columns = 1;
        }
    }
}