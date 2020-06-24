using Microsoft.Xna.Framework.Graphics;
using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Aquamentus : IEnemy
    {
        private ISprite sprite;
        private Color color;
        private Vector2 location;
        private ISprite projectile;
        private bool left;
        private float limit;
        private int deltaX;
        private float prevX;
       

        public Aquamentus()
        {
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentus();
            location = Constant.EnemyStartPosition;
            color = Color.White;
           
            left = true;
            deltaX = -1;
            limit = Constant.RNG.Next(Constant.MinAquamentusXRange, Constant.MaxAquamentusXRange);
            prevX = location.X;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, color, location);
        }

        public void takeDamage()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            location.X += deltaX * Constant.AquamentusSpeed;

            if(Math.Abs(location.X - prevX) > limit)
            {
                left = !left;
                deltaX = -deltaX;
                limit = Constant.RNG.Next(Constant.MinAquamentusXRange, Constant.MaxAquamentusXRange);
                prevX = location.X;
            }

            sprite.Update();
        }
    }
}
