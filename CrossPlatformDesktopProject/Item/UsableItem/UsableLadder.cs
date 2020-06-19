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
            Location = new Vector2(link.Position.X - Constant.ItemOffset, link.Position.Y);
        }

        public void UseRight()
        {
            Location = new Vector2(link.Position.X + Constant.ItemOffset, link.Position.Y);
        }

        public void UseUp()
        {
            Location = new Vector2(link.Position.X, link.Position.Y - Constant.ItemOffset);
        }

        public void UseDown()
        {
            Location = new Vector2(link.Position.X, link.Position.Y + Constant.ItemOffset);
        }
    }
}
