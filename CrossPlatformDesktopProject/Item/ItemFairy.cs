using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemFairy : AbstractItem
    {
        public ItemFairy()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteFairy();
            Position = Constant.ItemStartPosition;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.HP += 5;
        }
    }
}
