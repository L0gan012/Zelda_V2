using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemWhiteSword : AbstractItem
    {
        public ItemWhiteSword()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteWhiteSword();
            Position = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
