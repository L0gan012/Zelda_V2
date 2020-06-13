using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public interface ICollision
    {
       
        void Update();

        void Draw(SpriteBatch spritebatch);
    }
}
