using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class Zol : IEnemy
    {
        private ISprite sprite;
        private Vector2 location;
        private Color color;

        public Zol()
        {
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyZol();
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
