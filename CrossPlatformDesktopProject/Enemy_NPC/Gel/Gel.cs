using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class Gel : IEnemy
    {
        private ISprite sprite;
        private Vector2 location;
        Color color;

        public Gel()
        {
            this.sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGel();
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
