using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemWoodenBoomerang : AbstractItem
    {
        public ItemWoodenBoomerang()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteItemWoodenBoomerang();
            Position = Constant.ItemStartPosition;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.Inventory.ItemCache.Add(this, new UsableMagicBoomerang(user));
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.ItemEquipment;
    }
}
