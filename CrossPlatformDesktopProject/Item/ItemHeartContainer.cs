using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemHeartContainer : AbstractItem
    {
        public ItemHeartContainer()
        {
           Sprite = ItemsSpriteFactory.Instance.CreateSpriteHeartContainer();
           Position = Constant.ItemStartPosition;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.MaxHP++;
        }
    }
}
