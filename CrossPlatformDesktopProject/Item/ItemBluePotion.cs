using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemBluePotion : AbstractItem
    {
        public ItemBluePotion()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBluePotion();
            Position = Constant.ItemStartPosition;
        }
    }
}
