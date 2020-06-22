using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class Dodongo : IEnemy
    {
        public IDodongoState State { get; set; }
        private Vector2 location;
        private float limit;

        public Dodongo()
        {
            State = new RightMovingDodongoState(this);
        }

        public void Update()
        {
            State.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch);
        }

        public void BePuffed()
        {
            State.BePuffed();
        }

        public void MoveDown()
        {
            //State.MoveDown();
        }

        public void MoveLeft()
        {
            //State.MoveLeft();
        }

        public void MoveRight()
        {
            //State.MoveRight();
        }

        public void MoveUp()
        {
            //State.MoveUp();
        }

        public void takeDamage()
        {
            throw new NotImplementedException();
        }
    }
}
