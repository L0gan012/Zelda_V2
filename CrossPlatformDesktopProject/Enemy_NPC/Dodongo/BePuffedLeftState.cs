﻿using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class BePuffedLeftState : IDodongoState
    {
        private Dodongo dodongo;
        private ISprite sprite;

        public BePuffedLeftState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyDodongoLeftPuffed();
        }

        public void BePuffed()
        {

        }

        public void Update()
        {
            sprite.Update();
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
            //dodongo.state = new RightMovingDodongoState(dodongo);
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