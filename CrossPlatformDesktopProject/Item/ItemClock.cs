 using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemClock : AbstractItem
    {
        public ItemClock()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteClock();
            Position = Constant.ItemStartPosition;
            Color = Color.White;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            //oof
        }
    }
}
