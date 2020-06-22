using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemMagicBoomerang : AbstractItem
    {
        public ItemMagicBoomerang()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteMagicBoomerang();
            Color = Color.White;
            Location = Constant.ItemStartPosition;
        }
    }
}
