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

            if (user.Inventory.ItemCache.ContainsKey(new ItemWoodenBoomerang()))
            {
                user.Inventory.ItemCache.Remove(new ItemWoodenBoomerang());
            }
            user.Inventory.ItemCache.Add(this, new UsableMagicBoomerang(user));
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.ItemEquipment;
    }
}
