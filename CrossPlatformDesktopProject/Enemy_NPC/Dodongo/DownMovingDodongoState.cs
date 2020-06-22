using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class DownMovingDodongoState : IDodongoState
    {
        private Dodongo dodongo;
        private ISprite sprite;

        public DownMovingDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyDodongoDown();
        }

        public void BePuffed()
        {
            //dodongo.state = new BePuffedDownState(dodongo);
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