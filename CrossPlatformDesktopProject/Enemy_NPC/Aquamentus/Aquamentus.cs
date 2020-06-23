using Microsoft.Xna.Framework.Graphics;
using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Aquamentus : IEnemy
    {
        public IAquamentusState State { get; set; }
        private ISprite projectile;
        private Vector2 location;
        private bool left;
        private float limit;
        private int deltaX;
        private float prevX;
        private Color color;

        public Aquamentus()
        {
            State = new MouthClosedAquamentusState(this);
            location = Constant.EnemyStartPosition;
            color = Color.White;
           
            left = true;
            deltaX = -1;
            limit = Constant.RNG.Next(Constant.MinAquamentusXRange, Constant.MaxAquamentusXRange);
            prevX = location.X;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch, color, location);
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

            State.Update();
        }
    }
}
