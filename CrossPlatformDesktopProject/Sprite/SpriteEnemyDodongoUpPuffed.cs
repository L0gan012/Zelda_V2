﻿using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteEnemyDodongoUpPuffed : AbstractSprite
    {
        public SpriteEnemyDodongoUpPuffed(Texture2D texture)
        {
            Texture = texture;
            Rows = 1;
            Columns = 1;
            CurrentFrame = 0;
        }
    }
}
