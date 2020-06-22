﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpikeCross : IEnemy
    {
        private ISprite sprite;
        private Vector2 location;
        private Color color;

        public SpikeCross()
        {
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemySpikeCross();
            location = Constant.EnemyStartPosition;
            color = Color.White;
        }

        public void Draw(SpriteBatch spritebatch)
        {
            sprite.Draw(spritebatch, color, location);
        }

        public void takeDamage()
        {
        }

        public void Update()
        {
            sprite.Update();
        }
    }
}
