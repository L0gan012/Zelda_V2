using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemCompass : AbstractItem
    {
        public ItemCompass()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteCompass();
            Location = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
