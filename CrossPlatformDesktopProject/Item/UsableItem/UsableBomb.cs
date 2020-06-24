using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBomb : AbstractUsable
    {
        private int timer;

        public UsableBomb(ILink link)
        {
            Link = link;
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBomb();
            Color = Color.White;
            timer = Constant.BombTimer;
        }
        
        public override void Update()
        {
            Sprite.Update();
            timer--;

            if(timer == 0)
            {
                Link.SecondaryItem = null;
            }
        }
    }
}
