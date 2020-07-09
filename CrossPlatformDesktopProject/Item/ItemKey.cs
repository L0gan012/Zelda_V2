using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemKey : AbstractItem
    {
        public ItemKey()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteKey();
            Position = Constant.ItemStartPosition;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.Inventory.KeyCount++;
        }
    }
}
