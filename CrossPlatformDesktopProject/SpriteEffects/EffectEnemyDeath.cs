using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class EffectEnemyDeath : ISpriteEffect
    {

        public Vector2 Position { get; set; }
        public Color Color { get; set; } = Color.White;
        public ISprite Sprite { get; set; }
        public Vector2 Velocity { get; set; }
        public bool IsDestructable { get; set; } = false;

        private int timer;

        public EffectEnemyDeath(Vector2 position)
        {
            Sprite = SpriteEffectSpriteFactory.Instance.CreateSpriteEffectSwordBeamCollisionNE();
            timer = 0;
            Position = position;
        }
        public void Update()
        {
            if (timer >= Constant.TicksPerFrameEnemyDeath * 2)
            {
                IsDestructable = true;
            }
            timer++;
            Sprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Color, Position);
        }

    }
}
