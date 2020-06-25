using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemPotionNote : AbstractItem
    {
        public ItemPotionNote()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpritePotionNote();
            Position = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
