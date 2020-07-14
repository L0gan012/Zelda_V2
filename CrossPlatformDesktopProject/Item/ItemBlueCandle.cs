using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemBlueCandle : AbstractItem
    {
        public ItemBlueCandle()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBlueCandle();
            Position = Constant.ItemStartPosition;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.Inventory.ItemCache.Add(this, new UsableBlueCandle(user));
        }
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.ItemEquipment;
            set => _ = Enumerations.GameObjectType.ItemEquipment;
        }
    }
}
