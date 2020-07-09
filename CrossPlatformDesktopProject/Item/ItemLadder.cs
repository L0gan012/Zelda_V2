using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemLadder : AbstractItem
    {
        public ItemLadder()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteLadder();
            Position = Constant.ItemStartPosition;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.Inventory.ItemCache.Add(this, new UsableLadder(user));
        }
    }
}
