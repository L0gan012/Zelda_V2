using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemBomb : AbstractItem
    {
        public ItemBomb()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBomb();
            Position = Constant.ItemStartPosition;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.Inventory.ItemCache.Add(this, new UsableBomb(user));
            user.Inventory.BombCount+= 4;
        }
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.ItemEquipment;
    }
}
