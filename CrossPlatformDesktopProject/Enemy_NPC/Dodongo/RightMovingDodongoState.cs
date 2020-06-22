﻿using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class RightMovingDodongoState : IDodongoState
    {
        private Dodongo dodongo;
        private ISprite sprite;

        public RightMovingDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyDodongoRight();
        }

        public void BePuffed()
        {
            //dodongo.state = new BePuffedRightState();
        }

        public void Update()
        {
            //sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //sprite.Draw(spriteBatch);
        }

        public void MoveDown()
        {
            //dodongo.state = new DownMovingDodongoState(dodongo);
        }

        public void MoveLeft()
        {
            //dodongo.state = new LeftMovingDodongoState(dodongo);
        }

        public void MoveRight()
        {

        }

        public void MoveUp()
        {
            //dodongo.state = new UpMovingDodongoState(dodongo);
        }

        public void takeDamage()
        {
            throw new System.NotImplementedException();
        }
    }
}