using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemCompass : AbstractItem
    {
        public ItemCompass()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteCompass();
            Position = Constant.ItemStartPosition;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.Inventory.HasCompass = true;
        }
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.ItemEquipment;

    }
}
