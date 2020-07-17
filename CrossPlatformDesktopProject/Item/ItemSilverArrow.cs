using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemSilverArrow : AbstractItem
    {
        public ItemSilverArrow()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteSilverArrow();
            Position = Constant.ItemStartPosition;
        }
        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.Inventory.HasArrows = true;


            IUsableItem bow;
            if(user.Inventory.ItemCache.TryGetValue(new ItemBow(), out bow))
            {
                UsableBow castbow = (UsableBow)bow;
                castbow.Type = Enumerations.ArrowType.silver;
            }
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.ItemEquipment;
    }
}
