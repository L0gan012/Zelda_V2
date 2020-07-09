using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemWoodenArrow : AbstractItem
    {
        public ItemWoodenArrow()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteWoodenArrow();
            Position = Constant.ItemStartPosition;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.Inventory.HasArrows = true;


            IUsableItem bow;
            if (user.Inventory.ItemCache.TryGetValue(new ItemBow(), out bow))
            {
                UsableBow castbow = (UsableBow)bow;
                if (castbow.Type != Enumerations.ArrowType.silver)
                {
                    castbow.Type = Enumerations.ArrowType.silver;
                }
            }

        }
    }
}
