using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemMagicShield : AbstractItem
    {
        public ItemMagicShield()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteMagicShield();
            Position = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
