using Microsoft.Xna.Framework;
using Sprint2.Factory;

namespace Sprint2
{
    public class UsableLadder : AbstractItem, IUsableItem
    {
        private ILink link;

        public UsableLadder(ILink link)
        {
            this.link = link;
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteLadder();
            Color = Color.White;
        }

        public override void Update()
        {

        }

        public void UseLeft()
        {
            Location = new Vector2(link.Center.X - Constant.ItemOffset, link.Center.Y);
        }

        public void UseRight()
        {
            Location = new Vector2(link.Center.X + Constant.ItemOffset, link.Center.Y);
        }

        public void UseUp()
        {
            Location = new Vector2(link.Center.X, link.Center.Y - Constant.ItemOffset);
        }

        public void UseDown()
        {
            Location = new Vector2(link.Center.X, link.Center.Y + Constant.ItemOffset);
        }
    }
}
