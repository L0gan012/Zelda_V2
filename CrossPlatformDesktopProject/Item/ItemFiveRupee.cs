using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemFiveRupee : AbstractItem
    {
        public ItemFiveRupee()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteRupee();
            Position = Constant.ItemStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.ItemFiveRupee;

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.Inventory.RupeeCount += 5;
        }
    }
}
