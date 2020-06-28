using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBomb : AbstractUsable
    {
        private int timer;

        public UsableBomb(ILink link)
        {
            User = link;
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBomb();
            timer = Constant.BombTimer;
        }
        
        public override void Update()
        {
            base.Update();
            timer--;

            if(timer == 0)
            {
                IsDestructable = true;
                // set damage amount only when exploding, otherwise set it to 0
            }

        }
    }
}
