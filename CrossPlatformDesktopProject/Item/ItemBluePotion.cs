using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemBluePotion : AbstractItem
    {
        public ItemBluePotion()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBluePotion();
            Location = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
