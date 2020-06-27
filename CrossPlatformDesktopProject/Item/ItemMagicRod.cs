using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemMagicRod : AbstractItem
    {
        public ItemMagicRod()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteMagicRod();
            Position = Constant.ItemStartPosition;
        }
    }
}
