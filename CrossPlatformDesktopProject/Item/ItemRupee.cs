using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemRupee : AbstractItem
    {
        public ItemRupee()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteRupee();
            Position = Constant.ItemStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.ItemRupee;

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.Inventory.RupeeCount++;
        }
    }
}
