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
    }
}
