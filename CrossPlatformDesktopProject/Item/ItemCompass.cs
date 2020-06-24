using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemCompass : AbstractItem
    {
        public ItemCompass()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteCompass();
            Position = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
