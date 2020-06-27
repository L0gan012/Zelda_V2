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
    }
}
