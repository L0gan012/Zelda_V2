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
        private Color color;

        public Aquamentus()
        {
            State = new MouthClosedAquamentusState(this);
            location = Constant.EnemyStartPosition;
            color = Color.White;
           
            left = true;
            limit = location.X - Constant.RNG.Next(Constant.AquamentusXRange);
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
            if(left)
            {
                location.X--;
                if(Convert.ToInt32(location.X) < limit || location.X < 0)
                {
                    left = false;
                    limit = location.X + Constant.RNG.Next(Constant.AquamentusXRange);
                }

            } 
            else
            {
                location.X++;
                if (Convert.ToInt32(location.X) > limit || location.X > Constant.ScreenWidth)
                {
                    left = true;
                    limit = location.X - Constant.RNG.Next(Constant.AquamentusXRange);
                }
            }
            State.Update();
        }
    }
}
