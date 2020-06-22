using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemKey : AbstractItem
    {
        public ItemKey()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteKey();
            Location = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
