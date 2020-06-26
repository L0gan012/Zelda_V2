﻿using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ICollision
    {
        void Update();

        void Draw(SpriteBatch spritebatch);

        Enumerations.CollisionSide GetSide();

        int GetCollisionAmount();
    }
}
