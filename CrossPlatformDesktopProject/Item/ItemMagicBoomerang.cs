using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemMagicBoomerang : AbstractItem
    {
        public ItemMagicBoomerang()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteMagicBoomerang();
            Position = Constant.ItemStartPosition;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.Inventory.ItemCache.Add(this, new UsableMagicBoomerang(user));
        }
    }
}
