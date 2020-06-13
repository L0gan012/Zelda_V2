﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ILinkState
    {
        void Update();

        void Draw(SpriteBatch spriteBatch, Color color);

        void DamageLink(Game1 game);

        void UseItem();

        void SetLinkIdle();

        void MoveLinkLeft();

        void MoveLinkRight();

        void MoveLinkUp();

        void MoveLinkDown();

        void Attack();
    }
}
