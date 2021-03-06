﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class AquamentusProjectileStateFired 
    {
        private Aquamentus aquamentus;
        private ISprite sprite;

        public AquamentusProjectileStateFired(Aquamentus aquamentus)
        {
            this.aquamentus = aquamentus;
            //sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentusProjectile();
        }

        public void Update()
        {
            sprite.Update();
        }

        public void Draw(SpriteBatch spritebatch, Color color, Vector2 location)
        {
            sprite.Draw(spritebatch, color, location);
        }

        public void UseProjectile()
        {

        }
    }
}