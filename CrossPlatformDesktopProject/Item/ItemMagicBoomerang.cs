using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemMagicBoomerang : AbstractItem
    {
        public ItemMagicBoomerang()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteMagicBoomerang();
            Position = Constant.ItemStartPosition;
        }
    }
}
