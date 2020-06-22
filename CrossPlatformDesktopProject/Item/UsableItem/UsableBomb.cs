using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBomb : AbstractItem, IUsableItem
    {
        private ILink link;
        private int timer;

        public UsableBomb(ILink link)
        {
            this.link = link;
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
                link.Item = null;
            }
        }

        public void UseLeft()
        {
            Location = new Vector2(link.Center.X - Constant.ItemOffset - Sprite.GetWidth() / 2, link.Center.Y - Sprite.GetHeight() / 2);
        }

        public void UseRight()
        {
            Location = new Vector2(link.Center.X + Constant.ItemOffset - Sprite.GetWidth() / 2, link.Center.Y - Sprite.GetHeight() / 2);
        }

        public void UseUp()
        {
            Location = new Vector2(link.Center.X - Sprite.GetWidth() / 2, link.Center.Y - Constant.ItemOffset - Sprite.GetHeight() / 2);
        }

        public void UseDown()
        {
            Location = new Vector2(link.Center.X - Sprite.GetWidth() / 2, link.Center.Y + Constant.ItemOffset - Sprite.GetHeight() / 2);
        }
    }
}
