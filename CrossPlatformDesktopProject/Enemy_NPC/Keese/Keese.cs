using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class Keese : IEnemy
    {
        private ISprite sprite;
        private Vector2 location;
        private Color color;

        public Keese()
        {
            this.sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyKeese();
            location = Constant.EnemyStartPosition;
            color = Color.White;
        }

        public void Draw(SpriteBatch spritebatch)
        {
            sprite.Draw(spritebatch, color, location);
        }

        public void takeDamage()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            sprite.Update();
        }
    }
}
