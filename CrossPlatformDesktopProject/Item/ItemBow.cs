using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemBow : AbstractItem
    {
        public ItemBow()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBow();
            Position = Constant.ItemStartPosition;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.Inventory.ItemCache.Add(this, new UsableBow(user));
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.ItemEquipmentBow;

    }
}
