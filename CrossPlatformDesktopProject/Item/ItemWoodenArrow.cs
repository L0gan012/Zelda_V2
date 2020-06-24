using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemWoodenArrow : AbstractItem
    {
        public ItemWoodenArrow()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteWoodenArrow();
            Position = Constant.ItemStartPosition;
            Color = Color = Color.White;
        }
    }
}
