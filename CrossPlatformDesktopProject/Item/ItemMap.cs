using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemMap : AbstractItem
    {
        public ItemMap()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteMap();
            Position = Constant.ItemStartPosition;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.Inventory.HasMap = true;
        }

        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.ItemEquipment;
            set => _ = Enumerations.GameObjectType.ItemEquipment;
        }
    }
}
