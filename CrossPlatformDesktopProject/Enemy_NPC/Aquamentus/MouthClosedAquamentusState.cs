using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class MouthClosedAquamentusState : IAquamentusState
    {
        private Aquamentus aquamentus;
        private ISprite sprite;

        public MouthClosedAquamentusState(Aquamentus aquamentus)
        {
            this.aquamentus = aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentus();
        }

        public void Update()
        {
            sprite.Update();
        }

        public void Draw(SpriteBatch spritebatch, Color color, Vector2 location)
        {
            sprite.Draw(spritebatch, color, location);
        }

        public void MouthClose()
        {

        }

        public void MouthOpen()
        {
            aquamentus.State = new MouthOpenAquamentusState(aquamentus);     
        }
    }
}