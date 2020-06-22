using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class UpMovingDodongoState : IDodongoState
    {
        private Dodongo dodongo;
        private ISprite sprite;

        public UpMovingDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyDodongoUp();
        }

        public void BePuffed()
        {
            //dodongo.state = new BePuffedUpState();
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
            //dodongo.state = new RightMovingDodongoState(dodongo);
        }

        public void MoveUp()
        {
            throw new System.NotImplementedException();
        }

        public void takeDamage()
        {
            throw new System.NotImplementedException();
        }
    }
}